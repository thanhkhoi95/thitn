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
    public partial class frmMonHoc : Form
    {

        private bool isSaved;
        public frmMonHoc()
        {
            isSaved = true;
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet1.Monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.cHUYEN_DEDataSet.Monhoc);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            monhocGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            tbMaMonHoc.Enabled = true;
            tbTenMonHoc.Enabled = true;
            tbMaMonHoc.Focus();
            this.monhocBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // monhocBindingSource.RemoveCurrent();
            DataRow row = gridView1.GetFocusedDataRow();
            row["ACTIVE"] = 0;
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            row["ACTIVE"] = 1;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                monhocTableAdapter.Update(this.cHUYEN_DEDataSet);
                this.monhocTableAdapter.Fill(this.cHUYEN_DEDataSet.Monhoc);
                MessageBox.Show("Ghi thành công");
            } catch (Exception) {
                MessageBox.Show("Ghi bị lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            monhocBindingSource.CancelEdit();
            monhocGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            tbMaMonHoc.Enabled = false;
            tbTenMonHoc.Enabled = false;
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            isSaved = false;
            DataRow row = gridView1.GetFocusedDataRow();
            for (int i = 0; i < 2; i++)
            {
                if (row[i].ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }
            row["ACTIVE"] = 1;
            try
            {
                this.monhocBindingSource.EndEdit();
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Lỗi: Trùng mã môn học");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Lỗi: Mã môn học quá dài");
                return;
            }
            monhocGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            tbMaMonHoc.Enabled = false;
            tbTenMonHoc.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            monhocGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            tbMaMonHoc.Enabled = true;
            tbTenMonHoc.Enabled = true;
            tbMaMonHoc.Focus();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            monhocGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            tbMaMonHoc.Enabled = true;
            tbTenMonHoc.Enabled = true;
            tbMaMonHoc.Focus();
            this.monhocBindingSource.AddNew();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSaved = false;
            monhocGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            tbTenMonHoc.Enabled = true;
            tbMaMonHoc.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSaved = false;
            DataRow row = gridView1.GetFocusedDataRow();
            row["ACTIVE"] = 0;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSaved = false;
            DataRow row = gridView1.GetFocusedDataRow();
            row["ACTIVE"] = 1;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSaved = true;
            try
            {
                monhocTableAdapter.Update(this.cHUYEN_DEDataSet);
                MessageBox.Show("Lưu cơ sở dữ liệu thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu cơ sở dữ liệu bị lỗi");
            }
            this.monhocTableAdapter.Fill(this.cHUYEN_DEDataSet.Monhoc);
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!isSaved)
            {
                MessageBox.Show("Vui lòng lưu dữ liệu trước.");
                return;
            }
            DataRow row = gridView1.GetFocusedDataRow();
            foreach (Form f in Program.mainForm.MdiChildren)
            {
                if (f.GetType() == typeof(frmBoDe))
                {
                    frmSinhVien form = (frmSinhVien)f;
                    if (form.isMe(row["MAMH"].ToString().Trim()))
                    {
                        f.Activate();
                        return;
                    }
                }
            }
            frmBoDe newForm = new frmBoDe(row["MAMH"].ToString().Trim(), row["TENMH"].ToString().Trim())
            {
                MdiParent = Program.mainForm,
                Text = string.Format("Quản lí bộ đề (Môn học: {0})", row["TENMH"].ToString().Trim())
            };
            newForm.Show();
        }
    }
}
