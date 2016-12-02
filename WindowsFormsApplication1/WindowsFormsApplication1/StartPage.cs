using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
            formCreate = new frmCreate();
            formEdit = new frmEdit();
            formTicket = new frmTicket();
            formPatList = new frmPat();
        }
        frmTicket formTicket;
        frmPat formPatList;
        frmCreate formCreate;
        frmEdit formEdit;

        private void Start_Load(object sender, EventArgs e)
        {
            bottomPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxStripe.BackgroundImage = Properties.Resources.палка_администратор;
            bottomPanel.Visible = true;
            pictureBoxStripe.Visible = true;
            adminPanel.Visible = true;
            docPanel.Visible = false;
            regPanel.Visible = false;
            
            mainPanel.Visible = false;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxStripe.BackgroundImage = Properties.Resources.палка_регистратор;
            bottomPanel.Visible = true;
            pictureBoxStripe.Visible = true;
            regPanel.Visible = true;
            docPanel.Visible = false;
            adminPanel.Visible = false;
            
            mainPanel.Visible = false;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBoxStripe.BackgroundImage = Properties.Resources.палка_врач;
            bottomPanel.Visible = true;
            pictureBoxStripe.Visible = true;
            regPanel.Visible = false;
            adminPanel.Visible = false;
            docPanel.Visible = true;
            
            mainPanel.Visible = false;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            doctorButton.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            doctorButton.ForeColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            registratorButton.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            registratorButton.ForeColor = Color.Black;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            administratorButton.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            administratorButton.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelAll.Text = "ДИАГНОЗЫ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bottomPanel.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelAll.Text = "КАБИНЕТЫ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            labelAll.Text = "ВРАЧИ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            labelAll.Text = "СПЕЦИАЛИЗАЦИИ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            labelAll.Text = "АДРЕСА";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            labelAll.Text = "ДИАГНОЗЫ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            labelAll.Text = "ЛЕКАРСТВА";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            patientRecPanel.Visible = true;
            mainPanel.Visible = false;
            comboBoxNamePac.SelectedIndex = -1;
            comboBoxNamePac.Text = "Имя пациента";
            comboBoxNameDoc.Enabled = false;
            comboBoxNameDoc.SelectedIndex = -1;
            comboBoxNameDoc.Text = "Имя врача";
            comboBoxSpec.Enabled = false;
            comboBoxSpec.SelectedIndex = -1;
            comboBoxSpec.Text = "Специализация";
            comboBoxTime.Enabled = false;
            comboBoxTime.SelectedIndex = -1;
            comboBoxTime.Text = "Время";
            dateTimePicker1.Enabled = false;
            comboBoxNameDoc.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelAll.Text = "ЛЕКАРСТВА";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e) //сформировать отчет
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            visitPanel.Visible = true;
            mainPanel.Visible = false;
            listBoxPatientsVisit.SelectedIndex = -1;
        }


        private void button33_Click(object sender, EventArgs e)
        {
            formTicket.Show();
        }


        private void listBox7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxPatientsVisit.SelectedItem != null)
            {
                formPatList.Show();
                formPatList.Text = listBoxPatientsVisit.SelectedItem.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelAll.Text = "КАРТОЧКИ ПАЦИЕНТОВ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void comboBoxNamePac_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSpec.Enabled = true;
        }

        private void comboBoxSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNameDoc.Enabled = true;
        }

        private void comboBoxNameDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBoxTime.Enabled = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            patRecButton.Enabled = true;
        }

        private void listBoxPatientsCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            editItemButton.Enabled = true;
            deleteItemButton.Enabled = true;
        }
           
        private void createCardButton_Click(object sender, EventArgs e)
        {
            formCreate.Show();
        }

        private void editCardButton_Click(object sender, EventArgs e)
        {
            formEdit.Show();
        }
    }
}
