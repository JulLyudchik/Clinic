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
    public partial class frmDrug : Form
    {
        public frmDrug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDrug_Load(object sender, EventArgs e)
        {

        }
    }
}
