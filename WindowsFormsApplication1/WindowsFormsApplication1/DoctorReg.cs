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

namespace Presentation
{
    public partial class frmDoctorReg : Form
    {
        List<Specialization> specializations = new List<Specialization>();
        List<Doctor> doctors = new List<Doctor>();
       
        UnitOfWork unitOfWork = new UnitOfWork();
        
        public frmDoctorReg()
        {
            InitializeComponent();
            specializations = unitOfWork.Specializations.GetAll();
            comboBoxSpecDoc.DataSource = specializations;
        }

        private void frmDoctorReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart main = this.Owner as frmStart;
             if (main != null)
             {
                 main.doctorButton.Enabled = true;
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
           frmStart main = this.Owner as frmStart;
            if (main != null)
            {
                main.enterButton.Visible = true;
                Doctor doc = (Doctor)comboBoxNameDoc.SelectedItem;
                main.labelDoctor.Text ="Вы вошли как: " + doc.name;
                main.docPanel.Visible = true;
            }
            this.Close();


        }

        private void frmDoctorReg_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxNameDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        
        private void comboBoxSpecDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNameDoc.Enabled = true;
            comboBoxNameDoc.Text = "";
            specializations = unitOfWork.Specializations.GetAll();
            Specialization spec = (Specialization)comboBoxSpecDoc.SelectedItem;
            comboBoxNameDoc.DataSource = spec.doctors;
            
            
            
        }
    }
}
