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
    public partial class frmDoc : Form
    {
        private frmStart m_parent;
        frmDiag formDiag;
        frmDrug formDrug;
        public frmDoc(frmStart frm1, frmDiag frmDi, frmDrug frmDrug)
        {
            InitializeComponent();
            m_parent = frm1;
            formDiag = frmDi;
            formDrug = frmDrug;
            formVisit = new frmVis();
        }
        frmVis formVisit;
        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void Form4_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            m_parent.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formDiag.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formDrug.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formVisit.Show();
        }
    }
}
