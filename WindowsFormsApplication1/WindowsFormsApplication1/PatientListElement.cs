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
    public partial class frmPat : Form
    {
        public List<Ticket> dayPlan;
        public frmPat()
        {
            InitializeComponent();

   
        }

        private void frmPat_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void frmPat_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            frmStart main = this.Owner as frmStart;
            if (main != null)
            {
                main.listBoxPatientsVisit.DataSource = dayPlan;
                main.listBoxPatientsVisit.DisplayMember = "time";
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//диагнозы
        {
            
        }

        private void button2_Click(object sender, EventArgs e)//добавить диагноз
        {
            if (!listBoxDiag.Items.Contains(comboBox1.SelectedItem))
            {
                listBoxDiag.Items.Add(comboBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)//добавить лекарство
        {
            if (!listBoxDrug.Items.Contains(comboBox2.SelectedItem))
            {
                listBoxDrug.Items.Add(comboBox2.SelectedItem);
            }
        }

        private void listBoxDiag_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void listBoxDrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)//удалить диагноз
        {
            listBoxDiag.Items.Remove(listBoxDiag.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)//удалить лекарство
        {
            listBoxDrug.Items.Remove(listBoxDrug.SelectedItem);
        }
    }
}
