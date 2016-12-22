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
    public partial class frmPatientCard : Form
    {
        public frmPatientCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null &&textBox4.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
                this.DialogResult = DialogResult.None;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
