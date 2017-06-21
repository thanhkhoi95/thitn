using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (numberOfNewGiaoVien > 0) 
            {
                
            }
            try
            {
                giaovienTableAdapter.Update(this.cHUYEN_DEDataSet);
                this.giaovienTableAdapter.Fill(this.cHUYEN_DEDataSet.Giaovien);
                MessageBox.Show("Ghi thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Ghi bị lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            giaovienBindingSource.CancelEdit();
            if (isAdding)
            {
                numberOfNewGiaoVien--;
                isAdding = false;
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
            row["ACTIVE"] = 0;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            row["ACTIVE"] = 1;
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
        }
    }
}
