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
    public partial class frmLop : Form
    {

        private bool isSaved;
        public frmLop()
        {
            isSaved = true;
            InitializeComponent();
        }

        private void lopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUYEN_DEDataSet);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.cHUYEN_DEDataSet.Lop);

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSaved = false;
            lopGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            tbMaLop.Enabled = true;
            tbTenLop.Enabled = true;
            tbMaLop.Focus();
            this.lopBindingSource.AddNew();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                lopTableAdapter.Update(this.cHUYEN_DEDataSet);
                MessageBox.Show("Lưu cơ sở dữ liệu thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu cơ sở dữ liệu bị lỗi");
            }
            isSaved = true;
            this.lopTableAdapter.Fill(this.cHUYEN_DEDataSet.Lop);
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            for (int i = 0; i < 2; i++)
            {
                if (row[i].ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }
            try
            {
                this.lopBindingSource.EndEdit();
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Lỗi: Trùng mã lớp");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Lỗi: Mã lớp quá dài");
                return;
            }

            lopGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            tbMaLop.Enabled = false;
            tbTenLop.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lopBindingSource.CancelEdit();
            lopGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            tbMaLop.Enabled = false;
            tbTenLop.Enabled = false;
        }

        private void btnQlsv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!isSaved)
            {
                MessageBox.Show("Vui lòng lưu dữ liệu trước.");
                return;
            }
            DataRow row = gridView1.GetFocusedDataRow();
            foreach (Form f in Program.mainForm.MdiChildren)
            {
                if (f.GetType() == typeof(frmSinhVien))
                {
                    frmSinhVien form = (frmSinhVien)f;
                    if (form.isMe(row["MALOP"].ToString().Trim()))
                    {
                        f.Activate();
                        return;
                    }
                }
            }
            frmSinhVien newForm = new frmSinhVien(row["MALOP"].ToString().Trim(), row["TENLOP"].ToString().Trim()) 
            {
                MdiParent = Program.mainForm, 
                Text = string.Format("Quản lí sinh viên (Lớp: {0})", row["TENLOP"].ToString().Trim()) 
            };
            newForm.Show();
        }
    }
}
