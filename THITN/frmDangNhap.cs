using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THITN
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String strLenh;
            Program.mlogin = tbTenNguoiDung.Text;
            Program.password = tbMatKhau.Text;
            strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            MessageBox.Show(Program.mlogin + " " + Program.password);
            if (Program.KetNoi() == 1)
            {
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Login đăng nhập chưa có quyền truy cập");
                    return;
                }
                if (Program.myReader.Read())
                {
                    try
                    {
                        Program.username = Program.myReader.GetString(0).Trim();
                        Program.mHoten = Program.myReader.GetString(1).Trim();
                        Program.mGroup = Program.myReader.GetString(2).Trim();
                        MessageBox.Show(Program.username + " " + Program.mHoten + " " + Program.mGroup);
                        this.Close();
                        Program.mainForm.DangNhapThanhCong();
                    }
                    catch (Exception ex)
                    {
                        Program.mHoten = null;
                        MessageBox.Show("Login nay chua co username.\n" + ex.Message, "Thong bao", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi xác định nhóm quyền của nhân viên. ", "", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}
