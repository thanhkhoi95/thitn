using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmThiTracNghiem : Form
    {

        private int time;
        private string masv;
        private string malop;
        private string mamh;
        private int lan;
        private string trinhdo;
        private string ngaythi;

        private int curCauhoi;
        private List<CauHoi> dsCauHoi;
        private bool isChanged;
        private bool isQuerying;

        public frmThiTracNghiem(int time, string masv, string malop, string mamh, int lan, string trinhdo, string ngaythi)
        {
            this.time = time;
            this.malop = malop;
            this.masv = masv;
            this.mamh = mamh;
            this.trinhdo = trinhdo;
            this.lan = lan;
            this.ngaythi = ngaythi;
            isChanged = false;
            isQuerying = false;

            curCauhoi = 1;
            dsCauHoi = new List<CauHoi>();
            InitializeComponent();

            MessageBox.Show("Bắt đầu thi");
            SqlCommand cmd = new SqlCommand("BODE_THI", Program.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAMH", mamh);
            cmd.Parameters.AddWithValue("@MALOP", malop);
            cmd.Parameters.AddWithValue("@TRINHDO", trinhdo);
            cmd.Parameters.AddWithValue("@LAN", lan);

            SqlParameter outPutParameter = new SqlParameter();
            outPutParameter.ParameterName = "@OUTPUT";
            outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
            outPutParameter.Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add(outPutParameter);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                string output;
                if (outPutParameter.Value != null) output = outPutParameter.Value.ToString().Trim();
                else output = "0";
                if (output == "1")
                {
                    MessageBox.Show("Bài thi đã quá hạn.");
                    this.Close();
                    return;
                }
                string mach, noidung, a, b, c, d;
                while (reader.Read())
                {
                    mach = String.Format("{0}", reader["CAUHOI"].ToString().Trim());
                    noidung = String.Format("{0}", reader["NOIDUNG"].ToString().Trim());
                    a = String.Format("{0}", reader["A"].ToString().Trim());
                    b = String.Format("{0}", reader["B"].ToString().Trim());
                    c = String.Format("{0}", reader["C"].ToString().Trim());
                    d = String.Format("{0}", reader["D"].ToString().Trim());
                    CauHoi ch = new CauHoi(mach, noidung, a, b, c, d);
                    dsCauHoi.Add(ch);
                }
            }

            MessageBox.Show(GetBaiThiString());

            cmd = new SqlCommand();
            cmd.Connection = Program.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into BangDiem (MASV, MAMH , NGAYTHI, LAN, DIEM, BAITHI) VALUES (@MASV, @MAMH, @NGAYTHI, @LAN, @DIEM, @BAITHI)";
            cmd.Parameters.AddWithValue("@MASV", Program.mlogin);
            cmd.Parameters.AddWithValue("@MAMH", mamh);
            DateTime date;
            DateTime.TryParse(ngaythi, out date);
            cmd.Parameters.AddWithValue("@NGAYTHI", date);
            cmd.Parameters.AddWithValue("@LAN", lan);
            cmd.Parameters.AddWithValue("@DIEM", 0);
            cmd.Parameters.AddWithValue("@BAITHI", GetBaiThiString());

            try
            {
                int recordsAffected = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi chức năng vui lòng thử lại\n" + ex.Message);
                this.Close();
                return;
                // MessageBox.Show(ex.Errors[0].Number.ToString());
            }

            lbCauTitle.Text = "CÂU " + curCauhoi;
            lbCauHoi.Text = dsCauHoi.ElementAt(0).noidung;
            ckbA.Text = dsCauHoi.ElementAt(0).cauA;
            ckbB.Text = dsCauHoi.ElementAt(0).cauB;
            ckbC.Text = dsCauHoi.ElementAt(0).cauC;
            ckbD.Text = dsCauHoi.ElementAt(0).cauD;
            updateLbCauHoi();
            this.Show();
            timer1.Enabled = true;
        }

        private void KetThucThi()
        {
            timer1.Enabled = false;
            SqlCommand cmd = new SqlCommand("Bangdiem_ChamThi", Program.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MAMH", SqlDbType.NChar, 5).Value = mamh.Trim();
            cmd.Parameters.Add("@MALOP", SqlDbType.NChar, 8).Value = malop.Trim();
            cmd.Parameters.Add("@LAN", SqlDbType.SmallInt).Value = lan;
            cmd.Parameters.Add("@MASV", SqlDbType.NChar, 8).Value = Program.mlogin.Trim();
            cmd.Parameters.Add("@BAITHI", SqlDbType.Text).Value = GetBaiThiString();

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("sp_ketquathi", Program.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MAMH", SqlDbType.NChar, 5).Value = mamh.Trim();
            cmd.Parameters.Add("@LAN", SqlDbType.SmallInt).Value = lan;
            cmd.Parameters.Add("@MASV", SqlDbType.NChar, 8).Value = Program.mlogin.Trim();

            SqlParameter outPutParameter = new SqlParameter();
            outPutParameter.ParameterName = "@diem";
            outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
            outPutParameter.Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add(outPutParameter);

            cmd.ExecuteNonQuery();

            string diem = outPutParameter.Value.ToString().Trim();

            MessageBox.Show(String.Format("Kết thúc bài thi\nĐiểm của bạn là {0}\nSử dụng chức năng xem điểm để xem chi tiết bài thi", diem));

            this.Close();
        }

        private string GetBaiThiString()
        {
            string s = "";
            if (dsCauHoi.Count == 0) return "";
            foreach (CauHoi c in dsCauHoi)
            {
                s += string.Format("{0} {1}|", c.mach, c.dapan);
            }
            return s.Substring(0, s.Length - 1);
        }

        private void HienThiCauHoi()
        {
            lbCauTitle.Text = "CÂU " + curCauhoi;
            lbCauHoi.Text = dsCauHoi.ElementAt(curCauhoi-1).noidung;
            ckbA.Text = "A. " +  dsCauHoi.ElementAt(curCauhoi-1).cauA;
            ckbB.Text = "B. " + dsCauHoi.ElementAt(curCauhoi - 1).cauB;
            ckbC.Text = "C. " + dsCauHoi.ElementAt(curCauhoi - 1).cauC;
            ckbD.Text = "D. " + dsCauHoi.ElementAt(curCauhoi - 1).cauD;
            string da = dsCauHoi.ElementAt(curCauhoi-1).dapan;

            ckbA.Enabled = false;
            ckbB.Enabled = false;
            ckbC.Enabled = false;
            ckbD.Enabled = false;

            ckbA.CheckedChanged -= ckbA_CheckedChanged;
            ckbB.CheckedChanged -= ckbB_CheckedChanged;
            ckbC.CheckedChanged -= ckbC_CheckedChanged;
            ckbD.CheckedChanged -= ckbD_CheckedChanged;
            ckbA.Checked = false;
            ckbB.Checked = false;
            ckbC.Checked = false;
            ckbD.Checked = false;
            if (da == "A") ckbA.Checked = true;
            else if (da == "B") ckbB.Checked = true;
            else if (da == "C") ckbC.Checked = true;
            else if (da == "D") ckbD.Checked = true;
            ckbA.CheckedChanged += ckbA_CheckedChanged;
            ckbB.CheckedChanged += ckbB_CheckedChanged;
            ckbC.CheckedChanged += ckbC_CheckedChanged;
            ckbD.CheckedChanged += ckbD_CheckedChanged;

            ckbA.Enabled = true;
            ckbB.Enabled = true;
            ckbC.Enabled = true;
            ckbD.Enabled = true;
            updateLbCauHoi();
        }

        private void updateLbCauHoi()
        {
            lbCauTitle.Text = dsCauHoi.Count.ToString().Trim();
            int i;
            if (dsCauHoi.Count == 100) i = 3;
            else i = 2;
            string s = string.Format("CÂU {0} / {1}:", curCauhoi.ToString("D" + i), lbCauTitle.Text);
            lbCauTitle.Text = s;
        }

        private void frmThiTracNghiem_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time <= 0)
            {
                KetThucThi();
                return;
            }
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            tbTG.Text = timeSpan.ToString(@"hh\:mm\:ss");
            if (isChanged)
            {
                if (isQuerying) return;
                else
                {
                    isChanged = false;
                    isQuerying = true;
                    SqlCommand cmd = new SqlCommand("Bangdiem_ChamThi", Program.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MAMH", SqlDbType.NChar, 5).Value = mamh.Trim();
                    cmd.Parameters.Add("@MALOP", SqlDbType.NChar, 8).Value = malop.Trim();
                    cmd.Parameters.Add("@LAN", SqlDbType.SmallInt).Value = lan;
                    cmd.Parameters.Add("@MASV", SqlDbType.NChar, 8).Value = Program.mlogin.Trim();
                    cmd.Parameters.Add("@BAITHI", SqlDbType.Text).Value = GetBaiThiString();

                    cmd.ExecuteNonQuery();
                    isQuerying = false;
                    isChanged = false;
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            curCauhoi++;
            if (curCauhoi > dsCauHoi.Count) curCauhoi = 1;
            HienThiCauHoi();
        }

        private void ckbA_CheckedChanged(object sender, EventArgs e)
        {
            ckbB.CheckedChanged -= ckbB_CheckedChanged;
            ckbC.CheckedChanged -= ckbC_CheckedChanged;
            ckbD.CheckedChanged -= ckbD_CheckedChanged;
            ckbB.Checked = false;
            ckbC.Checked = false;
            ckbD.Checked = false;
            if (ckbA.Checked == false) dsCauHoi.ElementAt(curCauhoi-1).dapan = "X";
            else dsCauHoi.ElementAt(curCauhoi-1).dapan = "A";
            isChanged = true;
            ckbB.CheckedChanged += ckbB_CheckedChanged;
            ckbC.CheckedChanged += ckbC_CheckedChanged;
            ckbD.CheckedChanged += ckbD_CheckedChanged;
        }

        private void ckbB_CheckedChanged(object sender, EventArgs e)
        {
            ckbA.CheckedChanged -= ckbA_CheckedChanged;
            ckbC.CheckedChanged -= ckbC_CheckedChanged;
            ckbD.CheckedChanged -= ckbD_CheckedChanged;
            ckbA.Checked = false;
            ckbC.Checked = false;
            ckbD.Checked = false;
            if (ckbB.Checked == false) dsCauHoi.ElementAt(curCauhoi-1).dapan = "X";
            else dsCauHoi.ElementAt(curCauhoi-1).dapan = "B";
            isChanged = true;
            ckbA.CheckedChanged += ckbA_CheckedChanged;
            ckbC.CheckedChanged += ckbC_CheckedChanged;
            ckbD.CheckedChanged += ckbD_CheckedChanged;
        }

        private void ckbC_CheckedChanged(object sender, EventArgs e)
        {
            ckbB.CheckedChanged -= ckbB_CheckedChanged;
            ckbA.CheckedChanged -= ckbA_CheckedChanged;
            ckbD.CheckedChanged -= ckbD_CheckedChanged;
            ckbB.Checked = false;
            ckbA.Checked = false;
            ckbD.Checked = false;
            if (ckbC.Checked == false) dsCauHoi.ElementAt(curCauhoi-1).dapan = "X";
            else dsCauHoi.ElementAt(curCauhoi-1).dapan = "C";
            isChanged = true;
            ckbB.CheckedChanged += ckbB_CheckedChanged;
            ckbA.CheckedChanged += ckbA_CheckedChanged;
            ckbD.CheckedChanged += ckbD_CheckedChanged;
        }

        private void ckbD_CheckedChanged(object sender, EventArgs e)
        {
            ckbB.CheckedChanged -= ckbB_CheckedChanged;
            ckbC.CheckedChanged -= ckbC_CheckedChanged;
            ckbA.CheckedChanged -= ckbA_CheckedChanged;
            ckbB.Checked = false;
            ckbC.Checked = false;
            ckbA.Checked = false;
            if (ckbD.Checked == false) dsCauHoi.ElementAt(curCauhoi-1).dapan = "X";
            else dsCauHoi.ElementAt(curCauhoi-1).dapan = "D";
            isChanged = true;
            ckbB.CheckedChanged += ckbB_CheckedChanged;
            ckbC.CheckedChanged += ckbC_CheckedChanged;
            ckbA.CheckedChanged += ckbA_CheckedChanged;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            curCauhoi--;
            if (curCauhoi == 0) curCauhoi = dsCauHoi.Count;
            HienThiCauHoi();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbGo.EditValue != null)
            {
                try
                {
                    int i = Int32.Parse(tbGo.EditValue.ToString().Trim());
                    if (i > 0 && i <= dsCauHoi.Count)
                    {
                        curCauhoi = i;
                        HienThiCauHoi();
                    }
                }
                catch{}
            }
        }

        private void btnKetThuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KetThucThi();
        }
    }
}
