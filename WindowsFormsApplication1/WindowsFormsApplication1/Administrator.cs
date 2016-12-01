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
    public partial class frmAdmin : Form
    {
        private frmStart m_parent;
               
                frmCab formC;
                frmDoct formD;
                frmSpec formS;
                frmAdr formA;
                frmDiag formDi;
                frmDrug formDr;
        public frmAdmin(frmStart frm1, frmCab frmC, frmDoct frmD, frmSpec frmS, frmAdr frmA, frmDiag frmDi, frmDrug frmDr)
        {
            InitializeComponent();
            m_parent = frm1;
            
            formC = frmC;
            formD = frmD;
            formS = frmS;
            formA = frmA;
            formDi = frmDi;
            formDr = frmDr;        }
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            m_parent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formC.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formD.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formA.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formDi.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formDr.Show();
        }
    }
}
