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
    public partial class frmChuanBiThi : Form
    {

        private bool onClosed = false;
        public frmChuanBiThi()
        {
            InitializeComponent();
        }

        private void giaovien_DangkyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giaovien_DangkyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUYEN_DEDataSet);

        }

        private void frmChuanBiThi_Load(object sender, EventArgs e)
        {
            this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.monhocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.cHUYEN_DEDataSet.Lop);
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.cHUYEN_DEDataSet.Monhoc);
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Giaovien_Dangky' table. You can move, or remove it, as needed.
            this.giaovien_DangkyTableAdapter.Fill(this.cHUYEN_DEDataSet.Giaovien_Dangky);
            deNgayThi.EditValue = DateTime.Now;
            deNgayThi.Properties.MinValue = DateTime.Now;
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (onClosed) return;
            if (cbMaLop.Text != null && cbMaLop.Text.ToString().Trim() != "" &&
                   cbMaMH.Text != null && cbMaMH.Text.ToString().Trim() != "")
            {
                SqlCommand cmd = new SqlCommand("Giaovien_Dangky_LanThi", Program.conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("MAMH", SqlDbType.NChar, 5).Value = cbMaMH.SelectedValue.ToString().Trim();
                cmd.Parameters.Add("MALOP", SqlDbType.NChar, 8).Value = cbMaLop.SelectedValue.ToString().Trim();

                SqlParameter outPutParameter = new SqlParameter();
                outPutParameter.ParameterName = "@LAN";
                outPutParameter.SqlDbType = System.Data.SqlDbType.SmallInt;
                outPutParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outPutParameter);

                cmd.ExecuteNonQuery();

                string lan = outPutParameter.Value.ToString();
                switch (lan)
                {
                    case "2":
                        {
                            MessageBox.Show("không thể tổ chức thi nữa");
                            break;
                        }
                    case "1":
                        {
                            tbLanThi.Text = "2";
                            break;
                        }
                    default:
                        {
                            tbLanThi.Text = "1";
                            break;
                        }
                }
            }
        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (onClosed) return;
            if (cbMaLop.Text != null && cbMaLop.Text.ToString().Trim() != "" &&
                   cbMaMH.Text != null && cbMaMH.Text.ToString().Trim() != "")
            {
                SqlCommand cmd = new SqlCommand("Giaovien_Dangky_LanThi", Program.conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("MAMH", SqlDbType.NChar, 5).Value = cbMaMH.SelectedValue.ToString().Trim();
                cmd.Parameters.Add("MALOP", SqlDbType.NChar, 8).Value = cbMaLop.SelectedValue.ToString().Trim();

                SqlParameter outPutParameter = new SqlParameter();
                outPutParameter.ParameterName = "@LAN";
                outPutParameter.SqlDbType = System.Data.SqlDbType.SmallInt;
                outPutParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outPutParameter);

                cmd.ExecuteNonQuery();

                string lan = outPutParameter.Value.ToString();
                switch (lan)
                {
                    case "2":
                        {
                            MessageBox.Show("không thể tổ chức thi nữa");
                            break;
                        }
                    case "1":
                        {
                            tbLanThi.Text = "2";
                            break;
                        }
                    default:
                        {
                            tbLanThi.Text = "1";
                            break;
                        }
                }
            }
        }

        private void tbSoCau_TextChanged(object sender, EventArgs e)
        {
            if (tbSoCau.ReadOnly == true) return;
            try
            {
                Int32.Parse(this.tbSoCau.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Chỉ được nhập số");
                if (tbSoCau.Text.ToString().Trim().Length == 0) return;
                tbSoCau.ReadOnly = true;
                tbSoCau.Text = tbSoCau.Text.ToString().Trim().Substring(0, tbSoCau.Text.ToString().Trim().Length - 1);
                tbSoCau.ReadOnly = false;
                tbSoCau.SelectionStart = tbSoCau.Text.Length;
            }
        }

        private void tbThoiGian_TextChanged(object sender, EventArgs e)
        {
            if (tbThoiGian.ReadOnly == true) return;
            try
            {
                Int32.Parse(this.tbThoiGian.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Chỉ được nhập số");
                if (tbThoiGian.Text.ToString().Trim().Length == 0) return;
                tbThoiGian.ReadOnly = true;
                tbThoiGian.Text = tbThoiGian.Text.ToString().Trim().Substring(0, tbThoiGian.Text.ToString().Trim().Length - 1);
                tbThoiGian.ReadOnly = false;
                tbThoiGian.SelectionStart = tbThoiGian.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand("SP_GETCURRENTDATETIME", Program.conn);
            sc.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter op = new SqlParameter();
            op.ParameterName = "@CURRENT";
            op.SqlDbType = System.Data.SqlDbType.DateTime;
            op.Direction = System.Data.ParameterDirection.Output;
            sc.Parameters.Add(op);

            sc.ExecuteNonQuery();

            DateTime datetime;
            bool b = DateTime.TryParse(op.Value.ToString(), out datetime);
           // DateTime c = DateTime.ParseExact(op.Value.ToString().Trim(), 
           //     "yyyy-MM-dd HH:mm:ss,fff",
        //        System.Globalization.CultureInfo.InvariantCulture);

            MessageBox.Show(datetime.ToString());
            System.Threading.Thread.Sleep(5000);
            TimeSpan timeSpan;
            TimeSpan.TryParse((DateTime.Now - datetime).ToString(), out timeSpan);
            var seconds = timeSpan.TotalSeconds;
            MessageBox.Show(timeSpan.ToString(@"hh\:mm\:ss"));

            if (!(cbMaLop.Text != null && cbMaLop.Text.ToString().Trim() != "" &&
                   cbMaMH.Text != null && cbMaMH.Text.ToString().Trim() != "" &&
                   tbLanThi.Text != null && tbLanThi.Text.ToString().Trim() != "" &&
                   deNgayThi.Text != null && deNgayThi.Text.ToString().Trim() != "" &&
                   tbSoCau.Text != null && tbSoCau.Text.ToString().Trim() != "" &&
                   cbTrinhDo.Text != null && cbTrinhDo.Text.ToString().Trim() != "" &&
                   tbThoiGian.Text != null && tbThoiGian.Text.ToString().Trim() != ""
                   ))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            int time = Int32.Parse(this.tbThoiGian.Text);
            int socauhoi = Int32.Parse(this.tbSoCau.Text);

            SqlCommand cmd = new SqlCommand("SP_KIEMTRACAUHOI", Program.conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("MAMH", SqlDbType.NChar, 5).Value = cbMaMH.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("TD", SqlDbType.NChar, 8).Value = cbTrinhDo.Text.ToString().Trim();
            cmd.Parameters.Add("SOCH", SqlDbType.Int).Value = socauhoi;

            SqlParameter outPutParameter = new SqlParameter();
            outPutParameter.ParameterName = "@RET";
            outPutParameter.SqlDbType = System.Data.SqlDbType.SmallInt;
            outPutParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outPutParameter);

            cmd.ExecuteNonQuery();

            string ret = outPutParameter.Value.ToString();

            if (ret == "0")
            {
                MessageBox.Show("Không đủ số câu hỏi trong bộ đề");
                return;
            }
            else if (ret == "-1")
            {
                MessageBox.Show("Số câu hỏi >= 10 và <= 100 ");
                return;
            }
            
            if (time < 5 || time > 60)
            {
                MessageBox.Show("Thời gian thi >= 5 và <= 60 ");
                return;
            }

            cmd = new SqlCommand("SP_KIEMTRACAUHOI", Program.conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Giaovien_Dangky (MAGV, MAMH , MALOP, TRINHDO, NGAYTHI, LAN, SOCAUTHI, THOIGIAN) VALUES (@MAGV, @MAMH, @MALOP, @TRINHDO, @NGAYTHI, @LAN, @SOCAUTHI, @THOIGIAN)";
            cmd.Parameters.AddWithValue("@MAGV", Program.mlogin);
            cmd.Parameters.AddWithValue("@MAMH", cbMaMH.SelectedValue.ToString().Trim());
            cmd.Parameters.AddWithValue("@MALOP", cbMaLop.SelectedValue.ToString().Trim());
            cmd.Parameters.AddWithValue("@TRINHDO", cbTrinhDo.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@NGAYTHI", deNgayThi.EditValue);
            cmd.Parameters.AddWithValue("@LAN", Int32.Parse(tbLanThi.Text.ToString().Trim()));
            cmd.Parameters.AddWithValue("@SOCAUTHI", socauhoi);
            cmd.Parameters.AddWithValue("@THOIGIAN", time);
            try
            {
                int recordsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng kí thi thành công");
                this.giaovien_DangkyTableAdapter.Fill(this.cHUYEN_DEDataSet.Giaovien_Dangky);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi đăng kí thi\n" + ex.Message);

                // MessageBox.Show(ex.Errors[0].Number.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            onClosed = true;
            this.Close();
        }
    }
}
