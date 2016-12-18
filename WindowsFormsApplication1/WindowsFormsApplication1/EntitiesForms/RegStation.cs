using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using System.Data.Entity;

namespace Presentation
{
    public partial class frmRegStation : Form
    {      
        public frmRegStation()
        {
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //сделать проверку на наличие улицы в другом участке
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
    }
}
