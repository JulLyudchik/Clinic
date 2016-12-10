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
    public partial class frmTicket : Form
    {
        public frmTicket()
        {
            InitializeComponent();
            
        }

        private void frmTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            frmStart main = this.Owner as frmStart;
            if (main != null)
            {
                labelPac.Text = main.comboBoxNamePac.SelectedItem.ToString();
                labelDocName.Text = main.comboBoxNameDoc.SelectedItem.ToString();
                labelDocSpec.Text = main.comboBoxSpec.SelectedItem.ToString();

            }
        }
    }
}
