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
    public partial class frmReg : Form
    {
        private frmStart m_parent;
                frmCard formCard;
        public frmReg(frmStart frm1, frmCard frmC)
        {
            InitializeComponent();
            m_parent = frm1;
            formCard = frmC;
            
        }
        frmRec formRec;
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            m_parent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formRec = new frmRec();
            formRec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formCard.Show();
        }
    }
}
