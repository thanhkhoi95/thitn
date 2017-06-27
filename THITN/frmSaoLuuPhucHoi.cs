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
    public partial class frmSaoLuuPhucHoi : Form
    {
        public frmSaoLuuPhucHoi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.SP_ListBackup' table. You can move, or remove it, as needed.
            this.sP_ListBackupTableAdapter.Fill(this.masterDataSet.SP_ListBackup);

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Program.conn.Close();
                Program.database = "MASTER";
                Program.KetNoi();
                SqlCommand cmd = new SqlCommand("SP_Restore", Program.conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                DataRow row = gridView1.GetFocusedDataRow();

                cmd.Parameters.Add("id", SqlDbType.Int).Value = row["position"].ToString().Trim();

                cmd.ExecuteNonQuery();

                Program.conn.Close();
                Program.database = "CHUYEN_DE";
                Program.KetNoi();

                MessageBox.Show("Phục hồi thành công");
                this.sP_ListBackupTableAdapter.Fill(this.masterDataSet.SP_ListBackup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Program.conn.Close();
                Program.database = "MASTER";
                Program.KetNoi();
                SqlCommand cmd = new SqlCommand("SP_BackUp", Program.conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                DataRow row = gridView1.GetFocusedDataRow();

                cmd.ExecuteNonQuery();

                Program.conn.Close();
                Program.database = "CHUYEN_DE";
                Program.KetNoi();

                MessageBox.Show("Tạo sao lưu thành công");
                this.sP_ListBackupTableAdapter.Fill(this.masterDataSet.SP_ListBackup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
