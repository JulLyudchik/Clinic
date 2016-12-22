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
        UnitOfWork unitOfWork = new UnitOfWork();
        public Doctor doctor;
        public List<Doctor> therapists;
        public Specialization specialization_old=new Specialization();
        public frmDoctor()
        {
            InitializeComponent();

        }

        private void frmCreateDoc_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Specialization spec = (Specialization)comboBox1.SelectedItem;
            //if (spec.name == "Терапевт") comboBox3.Enabled = true; else comboBox3.Enabled = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            List<RegStation> regStations = unitOfWork.RegStations.GetAll();
            List<RegStation> regStations_t = new List<RegStation>();     
            Specialization specialization = (Specialization)comboBox1.SelectedItem;
            if (specialization.name == "Терапевт")
            {
                if (specialization_old.name == "Терапевт")
                {
                    regStations_t.Add(doctor.regStation); //его собственный участок
                }

                for (int i = 0; i < regStations.Count; i++)
                {
                    Doctor doctor_t = therapists.Find(doc => doc.regStation.name == regStations.ElementAt(i).name);
                    if (doctor_t == null)
                    {
                        regStations_t.Add(regStations.ElementAt(i));
                    }
                }
                comboBox3.DataSource = regStations_t;
                if (specialization_old.name == "Терапевт") //если раньше был терапевтом, то выделить его участок
                {
                    comboBox3.SelectedItem = doctor.regStation;           
                }
                comboBox3.Enabled = true;
            }
            else comboBox3.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedItem != null &&( (comboBox3.Enabled==true&&comboBox3.SelectedItem!=null)|| comboBox3.Enabled == false))
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
    }
    
}
