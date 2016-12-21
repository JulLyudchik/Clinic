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
        BindingList<Street> streets;
        UnitOfWork unitOfWork = new UnitOfWork();
        public frmRegStation()
        {
            InitializeComponent();           
            streets=new BindingList<Street>();
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
            Street street = new Street { name = (string)textBox2.Text };
            
            MessageBox.Show(Controller.Service.Add.add(street));
            if (Controller.Service.Add.error==false)
            {
                streets.Add(street);                             
            }                       
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {           
            Street selectedStreet=(Street)listBox1.SelectedItem;            
            MessageBox.Show(Controller.Service.Remove.remove(selectedStreet));
            streets.Remove(selectedStreet);           
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
