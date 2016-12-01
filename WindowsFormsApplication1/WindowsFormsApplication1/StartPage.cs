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



            formTicket = new frmTicket();
            formPatList = new frmPat();
        }
        frmTicket formTicket;
        frmPat formPatList;
        private void Start_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.палка_администратор;
            bottomPannel.Visible = true;
            pictureBox3.Visible = true;
            adminPannel.Visible = true;
            docPanel.Visible = false;
            regPannel.Visible = false;
            //admin panels
            cabinetPannel.Visible = false;
            doclistPannel.Visible = false;
            specPannel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            //reg panels
            patientRecPanel.Visible = false;
            cardsPanel.Visible = false;
            //doc panels
            visitPanel.Visible = false;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.палка_регистратор;
            bottomPannel.Visible = true;
            pictureBox3.Visible = true;
            regPannel.Visible = true;
            docPanel.Visible = false;
            adminPannel.Visible = false;
            //admin panels
            cabinetPannel.Visible = false;
            doclistPannel.Visible = false;
            specPannel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            //reg panels
            patientRecPanel.Visible = false;
            cardsPanel.Visible = false;
            //doc panels
            visitPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.палка_врач;
            bottomPannel.Visible = true;
            pictureBox3.Visible = true;
            regPannel.Visible = false;
            adminPannel.Visible = false;
            docPanel.Visible = true;
            //admin panels
            cabinetPannel.Visible = false;
            doclistPannel.Visible = false;
            specPannel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            //reg panels
            patientRecPanel.Visible = false;
            cardsPanel.Visible = false;
            //doc panels
            visitPanel.Visible = false;
        }

       

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
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
            specPannel.Visible = false;
            doclistPannel.Visible = false;
            cabinetPannel.Visible = false;
            visitPanel.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bottomPannel.Visible = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void cabinetPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            cabinetPannel.Visible = true;
            doclistPannel.Visible = false;
            specPannel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            doclistPannel.Visible = true;
            cabinetPannel.Visible = false;
            specPannel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            specPannel.Visible = true;
            doclistPannel.Visible = false;
            cabinetPannel.Visible = false;
            adressPanel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            adressPanel.Visible = true;
            specPannel.Visible = false;
            doclistPannel.Visible = false;
            cabinetPannel.Visible = false;
            diagPanel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            diagPanel.Visible = true;
            adressPanel.Visible = false;
            specPannel.Visible = false;
            doclistPannel.Visible = false;
            cabinetPannel.Visible = false;
            drugPanel.Visible = false;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            drugPanel.Visible = true;
            diagPanel.Visible = false;
            adressPanel.Visible = false;
            specPannel.Visible = false;
            doclistPannel.Visible = false;
            cabinetPannel.Visible = false;
            patientRecPanel.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            patientRecPanel.Visible = true;
            drugPanel.Visible = false;
            diagPanel.Visible = false;
            adressPanel.Visible = false;
            specPannel.Visible = false;
            doclistPannel.Visible = false;
            cabinetPannel.Visible = false;
            cardsPanel.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientRecPanel.Visible = false;
            drugPanel.Visible = true;
            diagPanel.Visible = false;
            adressPanel.Visible = false;
            specPannel.Visible = false;
            doclistPannel.Visible = false;
            cabinetPannel.Visible = false;
            visitPanel.Visible = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            visitPanel.Visible = true;
            drugPanel.Visible = false;
            diagPanel.Visible = false;
            listBox7.SelectedIndex = -1;
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
            if (listBox7.SelectedItem != null)
            {
                formPatList.Show();
                formPatList.Text = listBox7.SelectedItem.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cardsPanel.Visible = true;
            patientRecPanel.Visible = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
