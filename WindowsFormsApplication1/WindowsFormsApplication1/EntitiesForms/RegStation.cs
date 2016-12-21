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
        List<Street> streets = new List<Street>();
        UnitOfWork unitOfWork = new UnitOfWork();
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
           
            Street street = new Street { name = (string)textBox2.Text };
            MessageBox.Show(Controller.Service.Add.add(street));
           
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = Convert.ToInt32(listBox1.SelectedValue.ToString());
            streets = unitOfWork.Streets.GetAll();
            Street street = streets.Find(str => str.name == listBox1.SelectedItem.ToString());
            MessageBox.Show(Controller.Service.Remove.remove(street));

            streets = unitOfWork.Streets.GetAll();
            listBox1.DataSource = streets;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void frmRegStation_Load(object sender, EventArgs e)
        {

        }
    }
}
