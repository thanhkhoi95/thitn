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

        private void tbMatKhau_TextChanged(object sender, System.EventArgs e)
        {
            if (tbMatKhau.ReadOnly == true) return;
            try
            {
                Int32.Parse(this.tbMatKhau.Text);
            }
            catch (FormatException )
            {
                MessageBox.Show("Chi duoc nhap so");
                if (tbMatKhau.Text.ToString().Trim().Length == 0) return;
                tbMatKhau.ReadOnly = true;
                tbMatKhau.Text = tbMatKhau.Text.ToString().Trim().Substring(0, tbMatKhau.Text.ToString().Trim().Length - 1);
                tbMatKhau.ReadOnly = false;
                tbMatKhau.SelectionStart = tbMatKhau.Text.Length;
            }
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
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.\n", "Thông báo", MessageBoxButtons.OK);
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
                    catch (Exception)
                    {
                        Program.mlogin = null;
                        Program.mHoten = null;
                        Program.password = null;
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.\n", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    Program.mlogin = null;
                    Program.mHoten = null;
                    Program.password = null;
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.\n", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Close();
            }   
        }
    }
}
