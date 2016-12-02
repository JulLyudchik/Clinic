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
            //admin panels
            cabinetPanel.Visible = false;
            doclistPanel.Visible = false;
            specPanel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            //reg panels
            patientRecPanel.Visible = false;
            mainPanel.Visible = false;
            //doc panels
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
            //admin panels
            cabinetPanel.Visible = false;
            doclistPanel.Visible = false;
            specPanel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            //reg panels
            patientRecPanel.Visible = false;
            mainPanel.Visible = false;
            //doc panels
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
            //admin panels
            cabinetPanel.Visible = false;
            doclistPanel.Visible = false;
            specPanel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            //reg panels
            patientRecPanel.Visible = false;
            mainPanel.Visible = false;
            //doc panels
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            patientRecPanel.Visible = false;
            drugPanel.Visible = false;
            diagPanel.Visible = true;
            adressPanel.Visible = false;
            specPanel.Visible = false;
            doclistPanel.Visible = false;
            cabinetPanel.Visible = false;
            visitPanel.Visible = false;
            listBoxDiag.SelectedIndex = -1;
            editDiagButton.Enabled = false;
            deleteDiagButton.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bottomPanel.Visible = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void cabinetPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            cabinetPanel.Visible = true;
            doclistPanel.Visible = false;
            specPanel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
            listBoxCabinet.SelectedIndex = -1;
            editCabinetButton.Enabled = false;
            deleteCabinetButton.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            doclistPanel.Visible = true;
            cabinetPanel.Visible = false;
            specPanel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
            listBoxDoctors.SelectedIndex = -1;
            editDoctorButton.Enabled = false;
            deleteDoctorButton.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            specPanel.Visible = true;
            doclistPanel.Visible = false;
            cabinetPanel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
            listBoxSpec.SelectedIndex = -1;
            editSpecButton.Enabled = false;
            deleteSpecButton.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            adressPanel.Visible = true;
            specPanel.Visible = false;
            doclistPanel.Visible = false;
            cabinetPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
            listBoxAddress.SelectedIndex = -1;
            editAddressButton.Enabled = false;
            deleteAddressButton.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            diagPanel.Visible = true;
            adressPanel.Visible = false;
            specPanel.Visible = false;
            doclistPanel.Visible = false;
            cabinetPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
            listBoxDiag.SelectedIndex = -1;
            editDiagButton.Enabled = false;
            deleteDiagButton.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            drugPanel.Visible = true;
            diagPanel.Visible = false;
            adressPanel.Visible = false;
            specPanel.Visible = false;
            doclistPanel.Visible = false;
            cabinetPanel.Visible = false;
            patientRecPanel.Visible = false;
            listBoxDrugs.SelectedIndex = -1;
            editDrugButton.Enabled = false;
            deleteDrugButton.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            patientRecPanel.Visible = true;
            drugPanel.Visible = false;
            diagPanel.Visible = false;
            adressPanel.Visible = false;
            specPanel.Visible = false;
            doclistPanel.Visible = false;
            cabinetPanel.Visible = false;
            mainPanel.Visible = false;
            listBoxPatientsVisit.SelectedIndex = -1;
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
            patientRecPanel.Visible = false;
            drugPanel.Visible = true;
            diagPanel.Visible = false;
            adressPanel.Visible = false;
            specPanel.Visible = false;
            doclistPanel.Visible = false;
            cabinetPanel.Visible = false;
            visitPanel.Visible = false;
            listBoxDrugs.SelectedIndex = -1;
            editDrugButton.Enabled = false;
            deleteDrugButton.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            visitPanel.Visible = true;
            drugPanel.Visible = false;
            diagPanel.Visible = false;
            listBoxPatientsVisit.SelectedIndex = -1;
        }

        private void adminPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            formTicket.Show();
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            mainPanel.Visible = true;
            patientRecPanel.Visible = false;
            listBoxPatientsCards.SelectedIndex = -1;
            editCardButton.Enabled = false;
            deleteCardButton.Enabled = false;
        }

       

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void regPanel_Paint(object sender, PaintEventArgs e)
        {

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
            editCardButton.Enabled = true;
            deleteCardButton.Enabled = true;
        }

        private void listBoxDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            editDrugButton.Enabled = true;
            deleteDrugButton.Enabled = true;
        }

        private void listBoxDiag_SelectedIndexChanged(object sender, EventArgs e)
        {
            editDiagButton.Enabled = true;
            deleteDiagButton.Enabled = true;
        }

        private void listBoxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            editAddressButton.Enabled = true;
            deleteAddressButton.Enabled = true;
        }

        private void listBoxSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            editSpecButton.Enabled = true;
            deleteSpecButton.Enabled = true;
        }

        private void listBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            editDoctorButton.Enabled = true;
            deleteDoctorButton.Enabled = true;
        }

        private void listBoxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            editCabinetButton.Enabled = true;
            deleteCabinetButton.Enabled = true;
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
