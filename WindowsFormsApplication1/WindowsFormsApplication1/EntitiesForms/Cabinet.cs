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
    public partial class frmCabinet : Form
    {
        public List<CabinetPlan> cabinetPlans;
        UnitOfWork unitOfWork = new UnitOfWork();
        private BindingSource BindingSource = new BindingSource();
        public frmCabinet()
        {
            InitializeComponent();
            cabinetPlans = new List<CabinetPlan>();

          //  this.BindingSource.DataSource = cabinetPlans;
            dataGridView1.DataSource = cabinetPlans; ;
            dataGridView1.Columns[0].HeaderText = "День недели";
            dataGridView1.Columns[1].HeaderText = "Врач первой смены";
            dataGridView1.Columns[2].HeaderText = "Врач второй смены";
            dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.


            /*DataGridViewRow row1 = new DataGridViewRow();
            row1.HeaderCell.Value = "Пн";
            dataGridView1.Rows.Add(row1);

            DataGridViewRow row2 = new DataGridViewRow();
            row2.HeaderCell.Value = "Вт";
            dataGridView1.Rows.Add(row2);

            DataGridViewRow row3 = new DataGridViewRow();
            row3.HeaderCell.Value = "Ср";
            dataGridView1.Rows.Add(row3);

            DataGridViewRow row4 = new DataGridViewRow();
            row4.HeaderCell.Value = "Чт";
            dataGridView1.Rows.Add(row4);

            DataGridViewRow row5 = new DataGridViewRow();
            row5.HeaderCell.Value = "Пт";
            dataGridView1.Rows.Add(row5);

            DataGridViewRow row6 = new DataGridViewRow();
            row6.HeaderCell.Value = "Сб";
            dataGridView1.Rows.Add(row6);*/
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            

        }

        /*private void frmCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BindingSource = (BindingSource)dataGridView1.DataSource;
            cabinetPlans = (List<CabinetPlan>)dataGridView1.DataSource;
            CabinetPlan cabPlan = new CabinetPlan { day = (string)comboBoxDay.SelectedItem, firstShift = (Doctor)comboBoxFirstS.SelectedItem, secondShift = (Doctor)comboBoxSecondS.SelectedItem};
            MessageBox.Show(Controller.Service.Add.add(cabPlan));    
            cabinetPlans.Add(cabPlan);
            // this.BindingSource.DataSource = cabinetPlans;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cabinetPlans;
            //refresh();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Specialization spec = (Specialization)comboBox1.SelectedItem;
            comboBoxFirstS.DataSource = spec.doctors;
            comboBoxSecondS.DataSource = spec.doctors;
        }
    }
}
