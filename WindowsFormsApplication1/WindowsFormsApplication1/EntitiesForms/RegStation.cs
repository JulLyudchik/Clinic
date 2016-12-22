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
        public List<Street> streets;
        UnitOfWork unitOfWork = new UnitOfWork();
        public frmRegStation()
        {
            InitializeComponent();
            streets = new List<Street>();           
            listBox1.DataSource = streets;
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Name";
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            streets = (List<Street>)listBox1.DataSource;
            Street street = new Street { name = (string)textBox2.Text };
            
            MessageBox.Show(Controller.Service.Add.add(street));
            if (Controller.Service.Add.error==false)
            {
                streets.Add(street);                             
            }
            listBox1.DataSource = streets;
            refreshListBox();
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            streets = (List<Street>)listBox1.DataSource; 
            Street selectedStreet=(Street)listBox1.SelectedItem;            
            MessageBox.Show(Controller.Service.Remove.remove(selectedStreet));
            streets.Remove(selectedStreet);
            listBox1.DataSource = streets;
            refreshListBox();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void frmRegStation_Load(object sender, EventArgs e)
        {

        }
        private void refreshListBox() 
        {
            listBox1.DisplayMember = "Id";
            listBox1.DisplayMember = "Name";
        }
    }
}
