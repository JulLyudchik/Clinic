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
using EntitiesComponent;
using DataProviderComponent;

namespace WindowsFormsApplication1
{
    public partial class frmStart : Form
    {
        DiagnosisContext diagDB;
        DrugContext drugDB;
        RegStationContext regStDB;
        SpecContext specDB;
        DoctorContext docDB;
        CabinetContext cabDB;
        public frmStart()
        {
            InitializeComponent();
            formEditCab = new frmEditCab();
            formEditDoc = new frmEditDoc();
            formEditSpec = new frmEditSpec();
            formEditAddr = new frmEditAddress();
            formEditDiag = new frmEditDiag();
            formEditDrug = new frmEditDrug();
            formEditCard = new frmEditCard();

            diagDB = new DiagnosisContext();
            drugDB = new DrugContext();
            regStDB = new RegStationContext();
            specDB = new SpecContext();
            docDB = new DoctorContext();
            cabDB = new CabinetContext();

            diagDB.diagnoses.Load();
            drugDB.drugs.Load();
            regStDB.regStations.Load();
            specDB.specializations.Load();
            docDB.doctors.Load();
            cabDB.cabinets.Load();
        }
        frmTicket formTicket;
        frmPat formPatList;

        frmCreateCab formCreateCab;
        frmEditCab formEditCab;
        frmCreateDoc formCreateDoc;
        frmEditDoc formEditDoc;
        frmCreateSpec formCreateSpec;
        frmEditSpec formEditSpec;
        frmCreateAddr formCreateAddr;
        frmEditAddress formEditAddr;
        frmCreateDrug formCreateDrug;
        frmEditDrug formEditDrug;
        frmCreateDiag formCreateDiag;
        frmEditDiag formEditDiag;
        frmCreateCard formCreateCard;
        frmEditCard formEditCard;

        frmDoctorReg formDoctorReg;
        DateTime date;

        private void Start_Load(object sender, EventArgs e)
        {
            bottomPanel.Visible = false;
            labelDoctor.Location = new Point (540,505);
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.listBoxPatientsVisit, "Щелкните дважды на имени пациента для продолжения работы");
            ToolTip1.AutoPopDelay = 5000;
            ToolTip1.InitialDelay = 100;
            ToolTip1.ReshowDelay = 500;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxStripe.BackgroundImage = Properties.Resources.палка_администратор;
            bottomPanel.Visible = true;
            pictureBoxStripe.Visible = true;
            adminPanel.Visible = true;
            docPanel.Visible = false;
            regPanel.Visible = false;
            doctorButton.Enabled = true;
            labelDoctor.Text = "";
            enterButton.Visible = false;
            if (formDoctorReg!=null)
                formDoctorReg.Close();
            
            doctorButton.Enabled = true;
            labelDoctor.Text = "";
            enterButton.Visible = false;

            mainPanel.Visible = false;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
            date = DateTime.Now;

            labelDoct.Visible = false;

            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(tickTimer);
            timer1.Start();
        }
        private void tickTimer(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch=new DateTime();
            stopWatch=stopWatch.AddTicks(tick);
            TimeLb1.Text = String.Format("{0:HH:mm:ss}", stopWatch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxStripe.BackgroundImage = Properties.Resources.палка_регистратор;
            bottomPanel.Visible = true;
            pictureBoxStripe.Visible = true;
            regPanel.Visible = true;
            docPanel.Visible = false;
            adminPanel.Visible = false;
            doctorButton.Enabled = true;
            labelDoctor.Text = "";
            enterButton.Visible = false;
            if (formDoctorReg!=null)
               formDoctorReg.Close();
            
            mainPanel.Visible = false;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;

            labelDoct.Visible = false;

            date = DateTime.Now;
            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(tickTimer);
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBoxStripe.BackgroundImage = Properties.Resources.палка_врач;
            bottomPanel.Visible = true;
            pictureBoxStripe.Visible = true;
            regPanel.Visible = false;
            adminPanel.Visible = false;
            //docPanel.Visible = true;
            doctorButton.Enabled = false;
            formDoctorReg = new frmDoctorReg();
            formDoctorReg.Show();
            formDoctorReg.Owner = this;

            mainPanel.Visible = false;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
            date = DateTime.Now;

            labelDoct.Visible = true;
            

            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(tickTimer);
            timer1.Start();
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
            //
            diagDB.diagnoses.Load();
            listBoxAll.DataSource = diagDB.diagnoses.Local.ToList();
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            labelAll.Text = "ДИАГНОЗЫ";
            mainPanel.Visible = true;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
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
            cabDB.cabinets.Load();
            listBoxAll.DataSource = cabDB.cabinets.Local.ToList();
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Number";
            //
            labelAll.Text = "КАБИНЕТЫ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            docDB.doctors.Load();
            listBoxAll.DataSource = docDB.doctors.Local.ToList();
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            labelAll.Text = "ВРАЧИ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            specDB.specializations.Load();
            listBoxAll.DataSource = specDB.specializations.Local.ToList();
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            labelAll.Text = "СПЕЦИАЛИЗАЦИИ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //
            regStDB.regStations.Load();
            listBoxAll.DataSource = regStDB.regStations.Local.ToList();
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            labelAll.Text = "АДРЕСА";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //
            diagDB.diagnoses.Load();
            listBoxAll.DataSource = diagDB.diagnoses.Local.ToList();
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            labelAll.Text = "ДИАГНОЗЫ";
            mainPanel.Visible = true;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;      
            listBoxAll.SelectedIndex = -1;
           
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //
            drugDB.drugs.Load();
            listBoxAll.DataSource = drugDB.drugs.Local.ToList();
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            labelAll.Text = "ЛЕКАРСТВА";
            mainPanel.Visible = true;
            visitPanel.Visible = false;
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
            dataGridView1.Enabled = false;
            comboBoxNameDoc.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            drugDB.drugs.Load();
            listBoxAll.DataSource = drugDB.drugs.Local.ToList();
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            labelAll.Text = "ЛЕКАРСТВА";
            mainPanel.Visible = true;
            patientRecPanel.Visible = false;
            visitPanel.Visible = false;
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
            formTicket = new frmTicket();
            formTicket.Owner = this;
            formTicket.Show();
        }


        private void listBox7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxPatientsVisit.SelectedItem != null)
            {
                formPatList = new frmPat();
                formPatList.Owner = this;
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
            dataGridView1.Enabled = true;
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
            switch (labelAll.Text)
            {
                case "КАБИНЕТЫ":
                    frmCreateCab cabForm = new frmCreateCab();
                    DialogResult cabResult = cabForm.ShowDialog(this);
                    if (cabResult == DialogResult.Cancel)
                        return;
                    int id = 0;
                    bool converted = Int32.TryParse(cabForm.comboBox1.SelectedValue.ToString(), out id);
                    if (converted == false) //zahodit
                        return;
                    Cabinet cabinet = new Cabinet();
                    Specialization specialization_t = specDB.specializations.Find(id);                  
                    cabinet.number = cabForm.textBox1.Text;
                    cabinet.specialization = specialization_t.name;
                    cabDB.cabinets.Add(cabinet);
                    cabDB.SaveChanges();
                    cabDB.cabinets.Load();
                    listBoxAll.DataSource = cabDB.cabinets.Local.ToList();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case "ВРАЧИ":
                    formCreateDoc = new frmCreateDoc();
                    formCreateDoc.Show();
                    break;
                case "СПЕЦИАЛИЗАЦИИ":
                    frmCreateSpec specForm = new frmCreateSpec();
                    DialogResult specResult = specForm.ShowDialog(this);
                    if (specResult == DialogResult.Cancel)
                        return;
                    Specialization specialization = new Specialization();
                    specialization.name = specForm.textBox1.Text;
                    specialization.time = specForm.textBox2.Text;
                    specDB.specializations.Add(specialization);
                    specDB.SaveChanges();
                    specDB.specializations.Load();
                    listBoxAll.DataSource = specDB.specializations.Local.ToList();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case "АДРЕСА":
                    frmCreateAddr regStForm = new frmCreateAddr();
                    DialogResult regStResult = regStForm.ShowDialog(this);
                    if (regStResult == DialogResult.Cancel)
                        return;
                    RegStation regStation = new RegStation();
                    regStation.name = regStForm.textBox1.Text;
                    regStDB.regStations.Add(regStation);
                    regStDB.SaveChanges();
                    regStDB.regStations.Load();
                    listBoxAll.DataSource = regStDB.regStations.Local.ToList();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case "ЛЕКАРСТВА":
                    //formCreateDrug = new frmCreateDrug();
                    frmCreateDrug drugForm = new frmCreateDrug();
                    DialogResult drugResult = drugForm.ShowDialog(this);
                    if (drugResult == DialogResult.Cancel)
                        return;
                    Drug drug = new Drug();
                    drug.name = drugForm.textBox1.Text;
                    drugDB.drugs.Add(drug);
                    drugDB.SaveChanges();               
                    drugDB.drugs.Load();
                    listBoxAll.DataSource = drugDB.drugs.Local.ToList();
                    MessageBox.Show("Новый объект добавлен");
                    //formCreateDrug.Show();
                    break;
                case "ДИАГНОЗЫ":
                    //formCreateDiag = new frmCreateDiag();
                    //                    
                    frmCreateDiag diagForm = new frmCreateDiag();
                    DialogResult diagResult = diagForm.ShowDialog(this);
                    if (diagResult == DialogResult.Cancel)
                        return;
                    Diagnosis diagnosis = new Diagnosis();
                    diagnosis.name = diagForm.textBox1.Text;
                    diagDB.diagnoses.Add(diagnosis);
                    diagDB.SaveChanges();                   
                    diagDB.diagnoses.Load();
                    listBoxAll.DataSource = diagDB.diagnoses.Local.ToList();
                    MessageBox.Show("Новый объект добавлен");
                    //                  
                    //formCreateDiag.Show();
                    break;
                case "КАРТОЧКИ ПАЦИЕНТОВ":
                    formCreateCard = new frmCreateCard();
                    formCreateCard.Show();
                    break;
            }
            
        }

        private void editCardButton_Click(object sender, EventArgs e)
        {
            switch (labelAll.Text)
            {
                case "КАБИНЕТЫ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;
                        Cabinet cabinet = cabDB.cabinets.Find(id);
                        frmEditCab cabForm = new frmEditCab();
                        cabForm.textBox1.Text = cabinet.number;
                        cabForm.comboBox1.SelectedText = cabinet.specialization;
                        DialogResult cabResult = cabForm.ShowDialog(this);
                        if (cabResult == DialogResult.Cancel)
                            return;
                        cabinet.number = cabForm.textBox1.Text;
                        cabinet.specialization = cabForm.comboBox1.SelectedText;
                        cabDB.SaveChanges();
                        cabDB.cabinets.Load();
                        listBoxAll.DataSource = cabDB.cabinets.Local.ToList();
                        MessageBox.Show("Объект обновлен");
                    }
                    break;
                case "ВРАЧИ":
                    formEditDoc.Show();
                    break;
                case "СПЕЦИАЛИЗАЦИИ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;
                        Specialization specialization = specDB.specializations.Find(id);
                        frmEditSpec specForm = new frmEditSpec();
                        specForm.textBox1.Text = specialization.name;
                        specForm.textBox2.Text = specialization.time;
                        DialogResult specResult = specForm.ShowDialog(this);
                        if (specResult == DialogResult.Cancel)
                            return;
                        specialization.name = specForm.textBox1.Text;
                        specialization.time = specForm.textBox2.Text;
                        specDB.SaveChanges();
                        specDB.specializations.Load();
                        listBoxAll.DataSource = specDB.specializations.Local.ToList();
                        MessageBox.Show("Объект обновлен");
                    }
                    break;
                case "АДРЕСА":
                    formEditAddr.Show();
                    break;
                case "ДИАГНОЗЫ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                         if(converted == false)
                            return;
                        Diagnosis diagnosis = diagDB.diagnoses.Find(id);

                        frmEditDiag diagForm = new frmEditDiag();
                        diagForm.textBox1.Text = diagnosis.name;
                        DialogResult diagResult = diagForm.ShowDialog(this);
                        if (diagResult == DialogResult.Cancel)
                            return;
                                                
                        diagnosis.name = diagForm.textBox1.Text;
                        
                        diagDB.SaveChanges();                       
                        diagDB.diagnoses.Load();
                        listBoxAll.DataSource = diagDB.diagnoses.Local.ToList();
                        MessageBox.Show("Объект обновлен");
                    }
                    break;
                case "ЛЕКАРСТВА":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;

                        Drug drug = drugDB.drugs.Find(id);
                        frmEditDrug drugForm = new frmEditDrug();
                        drugForm.textBox1.Text = drug.name;
                        DialogResult drugResult = drugForm.ShowDialog(this);
                        if (drugResult == DialogResult.Cancel)
                            return;
                        drug.name = drugForm.textBox1.Text;
                        drugDB.SaveChanges();
                        drugDB.drugs.Load();
                        listBoxAll.DataSource = drugDB.drugs.Local.ToList();
                        MessageBox.Show("Объект обновлен");
                    }
                    //formEditDrug.Show();
                    break;
                case "КАРТОЧКИ ПАЦИЕНТОВ":
                    formEditCard.Show();
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLb1.Text = string.Format("Текущее время: {0}", DateTime.Now.ToString("HH:mm:ss"));
        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            doctorButton.Enabled = true;
            bottomPanel.Visible = false;
            labelDoctor.Text = "";
            enterButton.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            patRecButton.Enabled = true;
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            switch (labelAll.Text)
            {
                case "КАБИНЕТЫ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;

                        Cabinet cabinet = cabDB.cabinets.Find(id);
                        cabDB.cabinets.Remove(cabinet);
                        cabDB.SaveChanges();
                        cabDB.cabinets.Load();
                        listBoxAll.DataSource = cabDB.cabinets.Local.ToList();
                        MessageBox.Show("Объект удален");
                    }
                    break;
                case "ВРАЧИ":
                    formEditDoc.Show();
                    break;
                case "СПЕЦИАЛИЗАЦИИ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;

                        Specialization specialization = specDB.specializations.Find(id);
                        specDB.specializations.Remove(specialization);
                        specDB.SaveChanges();
                        specDB.specializations.Load();
                        listBoxAll.DataSource = specDB.specializations.Local.ToList();
                        MessageBox.Show("Объект удален");
                    }
                    break;
                case "АДРЕСА":
                    formEditAddr.Show();
                    break;
                case "ДИАГНОЗЫ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;

                        Diagnosis diagnosis = diagDB.diagnoses.Find(id);
                        diagDB.diagnoses.Remove(diagnosis);
                        diagDB.SaveChanges();
                        diagDB.diagnoses.Load();
                        listBoxAll.DataSource = diagDB.diagnoses.Local.ToList();
                        MessageBox.Show("Объект удален");
                    }
                    break;
                case "ЛЕКАРСТВА":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;

                        Drug drug = drugDB.drugs.Find(id);
                        drugDB.drugs.Remove(drug);
                        drugDB.SaveChanges();
                        drugDB.drugs.Load();
                        listBoxAll.DataSource = drugDB.drugs.Local.ToList();
                        MessageBox.Show("Объект удален");
                    }
                    break;
                case "КАРТОЧКИ ПАЦИЕНТОВ":
                    formEditCard.Show();
                    break;
            }
        }
    }
}
