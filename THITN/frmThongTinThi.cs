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
    public partial class frmThongTinThi : Form
    {
        private string maLop;
        private string curMaMH;
        private int curLan;
        private string curTrinhDo;
        private int curThoiGian;
        private string curNgayThi;
        public frmThongTinThi()
        {
            maLop = "";
            InitializeComponent();
        }

        private void monhocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monhocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUYEN_DEDataSet);

        }

        private void frmThongTinThi_Load(object sender, EventArgs e)
        {
            this.monhocTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.cHUYEN_DEDataSet.Monhoc);
            deNgayThi.EditValue = DateTime.Now;
            //deNgayThi.Properties.MinValue = DateTime.Now;
            SqlCommand command = new SqlCommand(string.Format("Select MALOP from Sinhvien where MASV = '{0}'", Program.mlogin), Program.conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    this.maLop = String.Format("{0}", reader["MALOP"]);
                }
            }
            lbMaLop.Text = maLop;
            lbMaSV.Text = Program.mlogin;
            lbCTLanThi.Text = "Không có";
            lbCTLop.Text = "Không có";
            lbCTMH.Text = "Không có";
            lbCTNgayThi.Text = "Không có";
            lbCTSoCau.Text = "Không có";
            lbCTThoiGian.Text = "Không có";
            lbCTTrinhDo.Text = "Không có";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbLanThi == null || cbMaMH == null || deNgayThi == null ||
                    cbLanThi.Text.ToString().Trim() == "" ||
                    cbMaMH.Text.ToString().Trim() == "" ||
                    deNgayThi.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            SqlCommand cmd = new SqlCommand("SP_KTKITHI", Program.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAMH", cbMaMH.EditValue.ToString().Trim());
            cmd.Parameters.AddWithValue("@MALOP", lbMaLop.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@NGAYTHI", deNgayThi.EditValue);
            cmd.Parameters.AddWithValue("@LAN", Int32.Parse(cbLanThi.Text.ToString().Trim()));

            SqlParameter outPutParameter = new SqlParameter();
            outPutParameter.ParameterName = "@RET";
            outPutParameter.SqlDbType = System.Data.SqlDbType.SmallInt;
            outPutParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outPutParameter);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                        lbCTLanThi.Text = String.Format("{0}", reader["LAN"]);
                        lbCTLop.Text = String.Format("{0} - {1}", reader["TENLOP"].ToString().Trim(), reader["MALOP"].ToString().Trim());
                        lbCTMH.Text = String.Format("{0} - {1}", reader["TENMH"].ToString().Trim(), reader["MAMH"].ToString().Trim());
                        lbCTNgayThi.Text = String.Format("{0}", reader["NGAYTHI"]);
                        lbCTSoCau.Text = String.Format("{0}", reader["SOCAUTHI"]);
                        DateTime d;
                        DateTime.TryParse(reader["NGAYTHI"].ToString(), out d);
                        lbCTNgayThi.Text = d.ToString("dd/MM/yyyy");
                        lbCTThoiGian.Text = String.Format("{0} phút", reader["THOIGIAN"].ToString().Trim());
                        lbCTTrinhDo.Text = String.Format("{0}", reader["TRINHDO"]);
                        curNgayThi = String.Format("{0}", reader["NGAYTHI"]).Trim();
                        curLan = Int32.Parse(String.Format("{0}", reader["LAN"]));
                        curMaMH = String.Format("{0}", reader["MAMH"]);
                        curTrinhDo = String.Format("{0}", reader["TRINHDO"]);
                        curThoiGian = Int32.Parse(reader["THOIGIAN"].ToString().Trim());
                        btnBatDauThi.Enabled = true;
                }
                else
                {
                    lbCTLanThi.Text = "Không có";
                    lbCTLop.Text = "Không có";
                    lbCTMH.Text = "Không có";
                    lbCTNgayThi.Text = "Không có";
                    lbCTSoCau.Text = "Không có";
                    lbCTThoiGian.Text = "Không có";
                    lbCTTrinhDo.Text = "Không có";
                    btnBatDauThi.Enabled = true;
                    btnBatDauThi.Enabled = false;
                }
            }
        }

        private void btnBatDauThi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_ktbangdiem", Program.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("MASV", SqlDbType.NChar, 8).Value = Program.mlogin;
            cmd.Parameters.Add("MAMH", SqlDbType.NVarChar, 5).Value = curMaMH;
            cmd.Parameters.Add("LAN", SqlDbType.SmallInt).Value = curLan;

            SqlParameter outPutParameter = new SqlParameter();
            outPutParameter.ParameterName = "@RET";
            outPutParameter.SqlDbType = System.Data.SqlDbType.NChar;
            outPutParameter.Size = 8;
            outPutParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outPutParameter);

            cmd.ExecuteNonQuery();

            string ret = outPutParameter.Value.ToString().Trim();

            if (ret == "1")
            {
                MessageBox.Show("Bạn đã thi môn học này");
                return; 
            }

            frmThiTracNghiem f = new frmThiTracNghiem(curThoiGian*60, Program.mlogin, maLop, curMaMH, curLan, curTrinhDo, curNgayThi);
            f.Activate();
            f.MdiParent = Program.mainForm;
            this.Close();
        }
    }
}
