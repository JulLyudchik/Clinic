using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmVis : Form
    {
        public frmVis()
        {
            InitializeComponent();
            formPatList = new frmPat();
        }
        frmPat formPatList;
        private void frmVis_Load(object sender, EventArgs e)
        {

        }

        private void frmVis_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                formPatList.Show();
            }
        }
    }
}
