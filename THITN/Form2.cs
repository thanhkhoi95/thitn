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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sP_BANGDIEMLOPTableAdapter.Connection.ConnectionString = Program.connstr;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            XtraReport1 rp = new XtraReport1() { DataSource = this.cHUYEN_DEDataSet1, DataAdapter = sP_BANGDIEMLOPTableAdapter };
            try
            {
                this.sP_BANGDIEMLOPTableAdapter.Fill(this.cHUYEN_DEDataSet1.SP_BANGDIEMLOP, mALOPToolStripTextBox.Text, mAMHToolStripTextBox.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(lANToolStripTextBox.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            documentViewer1.DocumentSource = rp;
            documentViewer1.Show();

        }
    }
}
