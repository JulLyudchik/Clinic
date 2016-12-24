using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmSpecialization : Form
    {
        public frmSpecialization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("[1-9^-]{1}[0-9^-]*");

            if (textBox1.Text != "" && textBox2.Text != "" && regex.IsMatch(textBox2.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля корректно!");
                this.DialogResult = DialogResult.None;
            }
        }

        private void frmSpecialization_Load(object sender, EventArgs e)
        {

        }
    }
}
