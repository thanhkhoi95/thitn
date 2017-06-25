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
    public partial class frmSinhVien : Form
    {
        private string maLop;
        private string tenLop;
        public frmSinhVien(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
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
            this.sinhvienTableAdapter.Fill(this.cHUYEN_DEDataSet.Sinhvien);

        }
    }
}
