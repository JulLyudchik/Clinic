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
        public CabinetPlan cabinetPlan;
        public List<Doctor> doctors;
        //UnitOfWork unitOfWork = new UnitOfWork();
        private BindingSource BindingSource = new BindingSource();
        //List<Specialization> specializations;
        public frmCabinet()
        {
            InitializeComponent();
            cabinetPlan = new CabinetPlan();
            doctors = new List<Doctor>();

            DataGridViewRow row1 = new DataGridViewRow();
            dataGridView1.Rows.Add(row1);

            DataGridViewRow row2 = new DataGridViewRow();
            dataGridView1.Rows.Add(row2);

            DataGridViewRow row3 = new DataGridViewRow();
            dataGridView1.Rows.Add(row3);

            DataGridViewRow row4 = new DataGridViewRow();
            dataGridView1.Rows.Add(row4);

            DataGridViewRow row5 = new DataGridViewRow();
            dataGridView1.Rows.Add(row5);

            DataGridViewRow row6 = new DataGridViewRow();
            dataGridView1.Rows.Add(row6);

            DataGridViewRow row7 = new DataGridViewRow();
            dataGridView1.Rows.Add(row7);
       
            dataGridView1.Rows[0].Cells[0].Value = "Понедельник";           
            dataGridView1.Rows[1].Cells[0].Value = "Вторник";
            dataGridView1.Rows[2].Cells[0].Value = "Среда";
            dataGridView1.Rows[3].Cells[0].Value = "Четверг";
            dataGridView1.Rows[4].Cells[0].Value = "Пятница";
            dataGridView1.Rows[5].Cells[0].Value = "Суббота";
            dataGridView1.Rows[6].Cells[0].Value = "Воскресенье";

            button2.Enabled = false;
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""&&!isNotFool())
            {              
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните номер кабинета и график загруженности!");
                this.DialogResult = DialogResult.None;
            }
            
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
            if (dataGridView1.SelectedCells[0].ColumnIndex!=0)
                {
                    dataGridView1.SelectedCells[0].Value = ((Doctor)comboBox2.SelectedItem).name;
                    if (!doctors.Contains((Doctor)comboBox2.SelectedItem))
                    {
                        doctors.Add((Doctor)comboBox2.SelectedItem);
                    }
                    if (dataGridView1.SelectedCells[0].ColumnIndex == 1)
                    {
                        if (dataGridView1.SelectedCells[0].RowIndex == 0)
                        {
                            cabinetPlan.firstShift_mon=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 1)
                        {
                            cabinetPlan.firstShift_tues=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 2)
                        {
                            cabinetPlan.firstShift_wednes=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 3)
                        {
                            cabinetPlan.firstShift_thurs=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 4)
                        {
                            cabinetPlan.firstShift_fri=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 5)
                        {
                            cabinetPlan.firstShift_satur=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 6)
                        {
                            cabinetPlan.firstShift_sun = (Doctor)comboBox2.SelectedItem;
                        }
                    }
                    else
                    {
                        if (dataGridView1.SelectedCells[0].RowIndex == 0)
                        {
                            cabinetPlan.secondShift_mon=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 1)
                        {
                            cabinetPlan.secondShift_tues=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 2)
                        {
                            cabinetPlan.secondShift_wednes=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 3)
                        {
                            cabinetPlan.secondShift_thurs=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 4)
                        {
                            cabinetPlan.secondShift_fri=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 5)
                        {
                            cabinetPlan.secondShift_satur=(Doctor)comboBox2.SelectedItem;
                        }
                        if (dataGridView1.SelectedCells[0].RowIndex == 6)
                        {
                            cabinetPlan.secondShift_sun = (Doctor)comboBox2.SelectedItem;
                        }
                    }
                }
                      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCells();
            Specialization spec = (Specialization)comboBox1.SelectedItem;
            comboBox2.DataSource = spec.doctors;     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        private void clearCells()
        {
            dataGridView1.Rows[0].Cells[1].Value = null;
            dataGridView1.Rows[1].Cells[1].Value = null;
            dataGridView1.Rows[2].Cells[1].Value = null;
            dataGridView1.Rows[3].Cells[1].Value = null;
            dataGridView1.Rows[4].Cells[1].Value = null;
            dataGridView1.Rows[5].Cells[1].Value = null;
            dataGridView1.Rows[6].Cells[1].Value = null;

            dataGridView1.Rows[0].Cells[2].Value = null;
            dataGridView1.Rows[1].Cells[2].Value = null;
            dataGridView1.Rows[2].Cells[2].Value = null;
            dataGridView1.Rows[3].Cells[2].Value = null;
            dataGridView1.Rows[4].Cells[2].Value = null;
            dataGridView1.Rows[5].Cells[2].Value = null;
            dataGridView1.Rows[6].Cells[2].Value = null;        
        }

        private bool isNotFool( )
        {
            bool c = false;

            for (int j = 0; j < dataGridView1.Rows.Count-1; j++)
                for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    if (dataGridView1.Rows[j].Cells[i].Value == null)
                        c = true;
            
            return c;
        }
    }
}
