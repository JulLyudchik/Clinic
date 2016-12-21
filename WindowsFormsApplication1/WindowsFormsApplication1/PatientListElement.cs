using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmPat : Form
    {
        public frmPat()
        {
            InitializeComponent();
            labelFIO.Text = this.Text;
        }

        private void frmPat_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void frmPat_Load(object sender, EventArgs e)
        {
            frmStart main = this.Owner as frmStart;
            if (main != null)
            {
                labelFIO.Text = main.listBoxPatientsVisit.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxDiag.Items.Add(comboBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxDrug.Items.Add(comboBox2.SelectedItem);

        }

        private void listBoxDiag_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void listBoxDrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxDiag.Items.Remove(listBoxDiag.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBoxDrug.Items.Remove(listBoxDrug.SelectedItem);
        }
    }
}
