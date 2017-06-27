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
    public partial class frmBoDe : Form
    {
        private bool isSaved;
        private string maMH;
        private string tenMH;
        public frmBoDe(string maMH, string tenMH)
        {
            isSaved = true;
            this.maMH = maMH;
            this.tenMH = tenMH;
            InitializeComponent();
        }

        public bool isMe(string maMH)
        {
            if (this.maMH == maMH) return true;
            return false;
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUYEN_DEDataSet);

        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.FillByMaMonHoc(this.cHUYEN_DEDataSet.BODE, maMH);

        }

        private void fillByMaMonHocToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bODETableAdapter.FillByMaMonHoc(this.cHUYEN_DEDataSet.BODE, this.maMH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bODEGridControl.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHoanTat.Enabled = true;
            btnHuy.Enabled = true;
            tbA.Enabled = true;
            tbB.Enabled = true;
            tbC.Enabled = true;
            tbD.Enabled = true;
            tbNoiDung.Enabled = true;
            cbDa.Enabled = true;
            cbTrinhDo.Enabled = true;
            tbNoiDung.Focus();
            this.bODEBindingSource.AddNew();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSaved = true;
            try
            {
                bODETableAdapter.Update(this.cHUYEN_DEDataSet);
                MessageBox.Show("Lưu cơ sở dữ liệu thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu cơ sở dữ liệu bị lỗi");
            }
            this.bODETableAdapter.FillByMaMonHoc(this.cHUYEN_DEDataSet.BODE, maMH);
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            isSaved = false;
            DataRow row = gridView1.GetFocusedDataRow();
            row["MAGV"] = Program.mlogin;
            row["MAMH"] = maMH;
            for (int i = 0; i < 10; i++)
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
                this.bODEBindingSource.EndEdit();
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Lỗi: dữ liệu không hợp lệ");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Lỗi: dữ liệu không hợp lệ");
                return;
            }
            bODEGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            tbA.Enabled = false;
            tbB.Enabled = false;
            tbC.Enabled = false;
            tbD.Enabled = false;
            tbNoiDung.Enabled = false;
            cbDa.Enabled = false;
            cbTrinhDo.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSaved = false;
            DataRow row = gridView1.GetFocusedDataRow();
            row["ACTIVE"] = 0;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSaved = false;
            DataRow row = gridView1.GetFocusedDataRow();
            row["ACTIVE"] = 1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bODEBindingSource.CancelEdit();
            bODEGridControl.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnHoanTat.Enabled = false;
            btnHuy.Enabled = false;
            tbA.Enabled = false;
            tbB.Enabled = false;
            tbC.Enabled = false;
            tbD.Enabled = false;
            tbNoiDung.Enabled = false;
            cbDa.Enabled = false;
            cbTrinhDo.Enabled = false;
        }
    }
}
