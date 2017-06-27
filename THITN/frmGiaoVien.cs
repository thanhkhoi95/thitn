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
    public partial class frmGiaoVien : Form
    {
        private int numberOfNewGiaoVien;
        private Dictionary<string, string> passList = new Dictionary<string, string>();
        private List<string> deletedGiaoVien = new List<string>();
        private List<string> restoredGiaoVien = new List<string>();
        private bool isAdding;
        public frmGiaoVien()
        {
            numberOfNewGiaoVien = 0;
            isAdding = false;
            InitializeComponent();
        }

        private void giaovienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giaovienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUYEN_DEDataSet);

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            this.giaovienTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Giaovien' table. You can move, or remove it, as needed.
            this.giaovienTableAdapter.Fill(this.cHUYEN_DEDataSet.Giaovien);

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            giaovienGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            //tbMaGV.Enabled = true;
            tbTen.Enabled = true;
            tbHo.Enabled = true;
            tbDiaChi.Enabled = true;
            tbSoDienThoai.Enabled = true;
            tbHo.Focus();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<String> messageList = new List<string>();
            String err = "";
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                if (row["MAGV"].ToString().Substring(0, 3).Equals("NEW"))
                {
                    SqlCommand cmd = new SqlCommand("Giaovien_Them_Request", Program.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("HO", SqlDbType.NVarChar, 40).Value = row["HO"].ToString().Trim();
                    cmd.Parameters.Add("TEN", SqlDbType.NVarChar, 10).Value = row["TEN"].ToString().Trim();
                    cmd.Parameters.Add("SODTLL", SqlDbType.NVarChar, 12).Value = row["SODTLL"].ToString().Trim();
                    cmd.Parameters.Add("DIACHI", SqlDbType.NVarChar, 40).Value = row["DIACHI"].ToString().Trim();
                    cmd.Parameters.Add("PASSWORD", SqlDbType.NVarChar, 20).Value = passList[row["MAGV"].ToString().Trim()];

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
                                messageList.Add("#GV: " + row["HO"] + " " + row["TEN"] +
                                    "\n -Login name bi trùng.");
                                break;
                            }
                        case "2":
                            {
                                messageList.Add("#GV: " + row["HO"] + " " + row["TEN"] +
                                    "\n -Giáo viên đã có login name.");
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
                giaovienTableAdapter.Update(this.cHUYEN_DEDataSet);
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
                    if (s == row["MAGV"].ToString().Trim())
                    {
                        MessageBox.Show("1");
                        SqlCommand cmd = new SqlCommand("Giaovien_Xoa", Program.conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MAGV", SqlDbType.NChar, 8).Value = row["MAGV"].ToString().Trim();

                        SqlParameter outPutParameter = new SqlParameter();
                        outPutParameter.ParameterName = "@RET";
                        outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                        outPutParameter.Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add(outPutParameter);

                        cmd.ExecuteNonQuery();

                        if (!outPutParameter.Value.ToString().Equals("0"))
                        {
                            messageList.Add("#Mã GV: " + row["MAGV"].ToString()
                                + "\n -Xóa giáo viên bị lỗi.");
                        }
                        cmd.Dispose();
                        break;
                    }
                }

                foreach (string s in restoredGiaoVien)
                {
                    if (s == row["MAGV"].ToString().Trim())
                    {
                        SqlCommand cmd = new SqlCommand("Giaovien_PhucHoi", Program.conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MAGV", SqlDbType.NChar, 8).Value = row["MAGV"].ToString().Trim();

                        SqlParameter outPutParameter = new SqlParameter();
                        outPutParameter.ParameterName = "@RET";
                        outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                        outPutParameter.Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add(outPutParameter);

                        cmd.ExecuteNonQuery();

                        if (!outPutParameter.Value.ToString().Equals("0"))
                        {
                            messageList.Add("#Mã GV: " + row["MAGV"].ToString()
                                + "\n -Phục hồi giáo viên bị lỗi.");
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
            this.giaovienTableAdapter.Fill(this.cHUYEN_DEDataSet.Giaovien);

            MessageBox.Show(err);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            giaovienBindingSource.CancelEdit();
            if (isAdding)
            {
                numberOfNewGiaoVien--;
                isAdding = false;
                tbMatKhau.Visible = false;
                lbMatKhau.Visible = false;
            }
            giaovienGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            //tbMaGV.Enabled = true;
            tbTen.Enabled = false;
            tbHo.Enabled = false;
            tbDiaChi.Enabled = false;
            tbSoDienThoai.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            if (row["ACTIVE"].Equals("1")) 
            {
                row["ACTIVE"] = "0";
                for (int i = 0; i < restoredGiaoVien.Count; i++)
                {
                    if (restoredGiaoVien.ElementAt(i) == row["MAGV"].ToString().Trim())
                    {
                        restoredGiaoVien.RemoveAt(i);
                        return;
                    }
                }
                
                string s = row["MAGV"].ToString().Trim();
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
                    if (deletedGiaoVien.ElementAt(i) == row["MAGV"].ToString().Trim())
                    {
                        deletedGiaoVien.RemoveAt(i);
                        return;
                    }
                }
                string s = row["MAGV"].ToString().Trim();
                restoredGiaoVien.Add(s);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            numberOfNewGiaoVien++;
            isAdding = true;
            giaovienGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            //tbMaGV.Enabled = true;
            tbTen.Enabled = true;
            tbHo.Enabled = true;
            tbDiaChi.Enabled = true;
            tbSoDienThoai.Enabled = true;
            tbMatKhau.Visible = true;
            lbMatKhau.Visible = true;
            tbHo.Focus();
            this.giaovienBindingSource.AddNew();
            tbMaGV.Text = "NEW" + numberOfNewGiaoVien;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            int i;
            for (i = 1; i < 5; i++)
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
                this.giaovienBindingSource.EndEdit();
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
            giaovienGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            //tbMaGV.Enabled = true;
            tbTen.Enabled = false;
            tbHo.Enabled = false;
            tbDiaChi.Enabled = false;
            tbSoDienThoai.Enabled = false;
            if (isAdding)
            {
                passList.Add(row["MAGV"].ToString().Trim(), tbMatKhau.Text.Trim());
                tbMatKhau.Text = "";
                tbMatKhau.Visible = false;
                lbMatKhau.Visible = false;
                isAdding = false;
            }
        }
    }
}
