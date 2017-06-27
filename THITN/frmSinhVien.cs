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
    public partial class frmSinhVien : Form
    {
        private int numberOfNewGiaoVien;
        private Dictionary<string, string> passList = new Dictionary<string, string>();
        private List<string> deletedGiaoVien = new List<string>();
        private List<string> restoredGiaoVien = new List<string>();
        private bool isAdding;

        private string maLop;
        private string tenLop;
        public frmSinhVien(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            numberOfNewGiaoVien = 0;
            isAdding = false;
            InitializeComponent();
        }

        public bool isMe(string maLop)
        {
            if (this.maLop == maLop) return true;
            return false;
        }

        private void sinhvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUYEN_DEDataSet);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            this.sinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.FillBy(this.cHUYEN_DEDataSet.Sinhvien, this.maLop);

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            numberOfNewGiaoVien++;
            isAdding = true;
            sinhvienGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            tbTen.Enabled = true;
            tbHo.Enabled = true;
            tbDiaChi.Enabled = true;
            tbNgaySinh.Enabled = true;
            tbMatKhau.Visible = true;
            lbMatKhau.Visible = true;
            tbHo.Focus();
            sinhvienBindingSource.AddNew();
            tbMaSinhVien.Text = "NEW" + numberOfNewGiaoVien;
            tbMaLop.Text = maLop;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sinhvienGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            tbTen.Enabled = true;
            tbHo.Enabled = true;
            tbDiaChi.Enabled = true;
            tbNgaySinh.Enabled = true;
            tbHo.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            if (row["ACTIVE"].Equals("1"))
            {
                row["ACTIVE"] = "0";
                for (int i = 0; i < restoredGiaoVien.Count; i++)
                {
                    if (restoredGiaoVien.ElementAt(i) == row["MASV"].ToString().Trim())
                    {
                        restoredGiaoVien.RemoveAt(i);
                        return;
                    }
                }

                string s = row["MASV"].ToString().Trim();
                deletedGiaoVien.Add(s);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            if (row["ACTIVE"].Equals("0"))
            {
                row["ACTIVE"] = "1";
                for (int i = 0; i < deletedGiaoVien.Count; i++)
                {
                    if (deletedGiaoVien.ElementAt(i) == row["MASV"].ToString().Trim())
                    {
                        deletedGiaoVien.RemoveAt(i);
                        return;
                    }
                }
                string s = row["MASV"].ToString().Trim();
                restoredGiaoVien.Add(s);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sinhvienBindingSource.CancelEdit();
            if (isAdding)
            {
                numberOfNewGiaoVien--;
                isAdding = false;
                tbMatKhau.Visible = false;
                lbMatKhau.Visible = false;
            }
            sinhvienGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            tbTen.Enabled = false;
            tbHo.Enabled = false;
            tbDiaChi.Enabled = false;
            tbNgaySinh.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<String> messageList = new List<string>();
            String err = "";
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                if (row["MASV"].ToString().Substring(0, 3).Equals("NEW"))
                {
                    SqlCommand cmd = new SqlCommand("Sinhvien_Them_Request", Program.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("HO", SqlDbType.NVarChar, 40).Value = row["HO"].ToString().Trim();
                    cmd.Parameters.Add("TEN", SqlDbType.NVarChar, 10).Value = row["TEN"].ToString().Trim();
                    cmd.Parameters.Add("DIACHI", SqlDbType.NVarChar, 40).Value = row["DIACHI"].ToString().Trim();
                    cmd.Parameters.Add("PASSWORD", SqlDbType.NVarChar, 20).Value = passList[row["MASV"].ToString().Trim()];
                    cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = row["NGAYSINH"].ToString().Trim();
                    cmd.Parameters.Add("@MALOP", SqlDbType.NChar, 8).Value = maLop;

                    SqlParameter outPutParameter = new SqlParameter();
                    outPutParameter.ParameterName = "@RET";
                    outPutParameter.SqlDbType = System.Data.SqlDbType.NChar;
                    outPutParameter.Size = 8;
                    outPutParameter.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outPutParameter);

                    cmd.ExecuteNonQuery();

                    string ret = outPutParameter.Value.ToString();
                    switch (ret)
                    {
                        case "1":
                            {
                                messageList.Add("#SV: " + row["HO"] + " " + row["TEN"] +
                                    "\n -Login name bi trùng.");
                                break;
                            }
                        case "2":
                            {
                                messageList.Add("#SV: " + row["HO"] + " " + row["TEN"] +
                                    "\n -Sinh viên đã có login name.");
                                break;
                            }
                    }
                    cmd.Dispose();
                    gridView1.DeleteRow(i);
                    numberOfNewGiaoVien--;
                    i--;
                }
            }

            passList.Clear();

            if (messageList.Count > 0)
            {
                err = "Lỗi khi lưu cơ sở dữ liệu.\n" +
                    "Chi tiết: \n" + String.Join("\n", messageList.ToArray());
                messageList.Clear();
            }

            try
            {
                sinhvienTableAdapter.Update(this.cHUYEN_DEDataSet);
            }
            catch (Exception)
            {
                if (err.Equals(""))
                {
                    err = "Lỗi khi lưu cơ sở dữ liệu.";
                }
            }

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                foreach (string s in deletedGiaoVien)
                {
                    if (s == row["MASV"].ToString().Trim())
                    {
                        MessageBox.Show("1");
                        SqlCommand cmd = new SqlCommand("Sinhvien_Xoa", Program.conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MASV", SqlDbType.NChar, 8).Value = row["MASV"].ToString().Trim();

                        SqlParameter outPutParameter = new SqlParameter();
                        outPutParameter.ParameterName = "@RET";
                        outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                        outPutParameter.Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add(outPutParameter);

                        cmd.ExecuteNonQuery();

                        if (!outPutParameter.Value.ToString().Equals("0"))
                        {
                            messageList.Add("#Mã SV: " + row["MASV"].ToString()
                                + "\n -Xóa sinh viên bị lỗi.");
                        }
                        cmd.Dispose();
                        break;
                    }
                }

                foreach (string s in restoredGiaoVien)
                {
                    if (s == row["MASV"].ToString().Trim())
                    {
                        SqlCommand cmd = new SqlCommand("Sinhvien_PhucHoi", Program.conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MASV", SqlDbType.NChar, 8).Value = row["MASV"].ToString().Trim();

                        SqlParameter outPutParameter = new SqlParameter();
                        outPutParameter.ParameterName = "@RET";
                        outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                        outPutParameter.Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add(outPutParameter);

                        cmd.ExecuteNonQuery();

                        if (!outPutParameter.Value.ToString().Equals("0"))
                        {
                            messageList.Add("#Mã SV: " + row["MAGV"].ToString()
                                + "\n -Phục hồi sinh viên bị lỗi.");
                        }
                        cmd.Dispose();
                        break;
                    }
                }
            }

            if (messageList.Count > 0)
            {
                if (err.Equals(""))
                    err = "Lỗi khi lưu cơ sở dữ liệu.\n" + "Chi tiết: \n";
                else if (err.Equals("Lỗi khi lưu cơ sở dữ liệu."))
                    err += "Chi tiết: \n";
                err += String.Join("\n", messageList.ToArray());
            }
            else err = "Lưu cơ sở dữ liệu thành công.";

            deletedGiaoVien.Clear();
            this.sinhvienTableAdapter.FillBy(this.cHUYEN_DEDataSet.Sinhvien, maLop);

            MessageBox.Show(err);

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            row["MASV"] = tbMaSinhVien.Text;
            row["MALOP"] = tbMaLop.Text;
            int i;
            for (i = 0; i < 6; i++)
            {
                if (row[i].ToString() == "")
                {
                    MessageBox.Show(i + "Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }
            if (isAdding && tbMatKhau.Equals(""))
            {
                MessageBox.Show(i + "Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (tbMatKhau.Text == "")
            {
                MessageBox.Show(i + "Vui lòng nhập đầy đủ thông tin");
                return;
            }
            row["ACTIVE"] = 1;
            try
            {
                this.sinhvienBindingSource.EndEdit();
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Lỗi: Trùng mã giáo viên");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Lỗi: Dữ liệu nhập không hợp lệ\nChi Tiết: " + ex.Message);
                return;
            }
            sinhvienGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            tbTen.Enabled = false;
            tbHo.Enabled = false;
            tbDiaChi.Enabled = false;
            tbNgaySinh.Enabled = false;
            if (isAdding)
            {
                passList.Add(row["MASV"].ToString().Trim(), tbMatKhau.Text.Trim());
                tbMatKhau.Text = "";
                tbMatKhau.Visible = false;
                lbMatKhau.Visible = false;
                isAdding = false;
            }
        }

    }
}
