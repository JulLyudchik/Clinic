using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Model;
using Controller;

namespace Presentation
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
            
        }

        /*private void CreateDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCreateDoc_Load(object sender, EventArgs e)
        {
            
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Specialization spec = (Specialization)comboBox1.SelectedItem;
            // if (spec.name == "Терапевт") comboBox3.Enabled = true; else comboBox3.Enabled = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Specialization spec = (Specialization)comboBox1.SelectedItem;
            if (spec.name == "Терапевт") comboBox3.Enabled = true; else comboBox3.Enabled = false;
        }
    }
}
