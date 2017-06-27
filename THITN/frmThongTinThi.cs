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
    public partial class frmThongTinThi : Form
    {
        public frmThongTinThi()
        {
            InitializeComponent();
        }

        private void monhocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monhocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUYEN_DEDataSet);

        }

        private void frmThongTinThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUYEN_DEDataSet.Monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.cHUYEN_DEDataSet.Monhoc);

        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
