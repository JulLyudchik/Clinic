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
    public partial class frmStart : Form
    {
        List<Diagnosis> diagnoses;
        List<Drug> drugs;
        List<Doctor> doctors;
        List<Specialization> specializations;
        List<RegStation> regStations;
        List<Cabinet> cabinets;
        List<Street> streets;
        List<PatientCard> patCards;
        List<CabinetPlan> cabPlans;

        UnitOfWork unitOfWork = new UnitOfWork();

        frmSpecialization formCreateSpec;
        frmRegStation formCreateAddr;
        frmDrug formCreateDrug;
        frmDiagnosis formCreateDiag;
        frmPatientCard formCreateCard;
        frmDoctorReg formDoctorReg;
        frmPat formPatList;
        frmTicket formTicket;
        DateTime date;
        public frmStart()
        {
            InitializeComponent();
            drugs = unitOfWork.Drugs.GetAll();
            specializations = unitOfWork.Specializations.GetAll();
            diagnoses = unitOfWork.Diagnoses.GetAll();
            streets = unitOfWork.Streets.GetAll(); 
            regStations = unitOfWork.RegStations.GetAll();
            doctors = unitOfWork.Doctors.GetAll();
            cabinets = unitOfWork.Cabinets.GetAll();
            patCards = unitOfWork.PatientCards.GetAll();
            cabPlans = unitOfWork.CabinetPlans.GetAll();
            
        }
        private void Start_Load(object sender, EventArgs e)
        {
            bottomPanel.Visible = false;
            labelDoctor.Location = new Point(540, 505);
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.listBoxPatientsVisit, "Щелкните дважды на имени пациента для продолжения работы");
            ToolTip1.AutoPopDelay = 5000;
            ToolTip1.InitialDelay = 100;
            ToolTip1.ReshowDelay = 500;

        }
        private void tickTimer(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            TimeLb1.Text = String.Format("{0:HH:mm:ss}", stopWatch);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLb1.Text = string.Format("Текущее время: {0}", DateTime.Now.ToString("HH:mm:ss"));
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
            if (formDoctorReg != null)
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
            if (formDoctorReg != null)
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bottomPanel.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {           
            diagnoses = unitOfWork.Diagnoses.GetAll();
            listBoxAll.DataSource = diagnoses;
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
       
        private void button9_Click(object sender, EventArgs e)
        {           
            cabinets = unitOfWork.Cabinets.GetAll();
            listBoxAll.DataSource = cabinets;
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
            doctors = unitOfWork.Doctors.GetAll();
            listBoxAll.DataSource = doctors;
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
            specializations = unitOfWork.Specializations.GetAll();
            listBoxAll.DataSource = specializations;
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
            regStations = unitOfWork.RegStations.GetAll();
            listBoxAll.DataSource = regStations;
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            labelAll.Text = "УЧАСТКИ";
            mainPanel.Visible = true;
            listBoxAll.SelectedIndex = -1;
            editItemButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }
        private void button13_Click(object sender, EventArgs e)
        {           
            diagnoses = unitOfWork.Diagnoses.GetAll();
            listBoxAll.DataSource = diagnoses;
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
            drugs = unitOfWork.Drugs.GetAll();
            listBoxAll.DataSource = drugs;
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
            // comboBoxNamePac.SelectedIndex = -1;
            comboBoxNamePac.Text = "Имя пациента";
            patCards = unitOfWork.PatientCards.GetAll();
            comboBoxNamePac.DataSource = patCards;
            comboBoxNamePac.DisplayMember = "Name";
            comboBoxSpec.Enabled = false;
            //comboBoxSpec.SelectedIndex = -1;
            comboBoxSpec.Text = "Специализация";
            specializations = unitOfWork.Specializations.GetAll();
            comboBoxSpec.DataSource = specializations;
            comboBoxNameDoc.Enabled = false;
            //comboBoxNameDoc.SelectedIndex = -1;
            comboBoxNameDoc.Text = "Имя врача";

            // dataGridView1.Enabled = false;
            comboBoxNameDoc.Enabled = false;
            patRecButton.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            drugs = unitOfWork.Drugs.GetAll();
            listBoxAll.DataSource = drugs;
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
            patCards = unitOfWork.PatientCards.GetAll();
            listBoxPatientsVisit.DataSource = patCards;
            listBoxPatientsVisit.ValueMember = "Id";
            listBoxPatientsVisit.DisplayMember = "Name";
            listBoxPatientsVisit.SelectedIndex = -1;
            

        }


        private void button33_Click(object sender, EventArgs e)
        {
            formTicket = new frmTicket();
            formTicket.Owner = this;
            formTicket.Show();
            Specialization spec = (Specialization)comboBoxSpec.SelectedItem;
            formTicket.labelDocSpec.Text = spec.name;
            Doctor doc = (Doctor)comboBoxNameDoc.SelectedItem;
            formTicket.labelDocName.Text = doc.name;
        }


        private void listBox7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxPatientsVisit.SelectedItem != null)
            {
                formPatList = new frmPat();
                
                DialogResult patResult = formPatList.ShowDialog(this);
                if (patResult == DialogResult.Cancel)
                    return;
                PatientCard patCard = (PatientCard)listBoxPatientsVisit.SelectedItem;
                formPatList.Text = patCard.name;
                formPatList.labelFIO.Text = patCard.name;
                formPatList.labelDate.Text= patCard.birthDate.ToString();
                diagnoses = unitOfWork.Diagnoses.GetAll();
                formPatList.comboBox1.DataSource = diagnoses;
                drugs = unitOfWork.Drugs.GetAll();
                formPatList.comboBox2.DataSource = drugs;
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            patCards = unitOfWork.PatientCards.GetAll();
            listBoxAll.DataSource = patCards;
            listBoxAll.ValueMember = "Id";
            listBoxAll.DisplayMember = "Name";
            //
            
            labelAll.Text = "КАРТОЧКИ ПАЦИЕНТОВ";
            mainPanel.Visible = true;
            patientRecPanel.Visible = false;
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
            Specialization spec = (Specialization)comboBoxSpec.SelectedItem;
            comboBoxNameDoc.DataSource = spec.doctors;
        }
        private void comboBoxNameDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  dataGridView1.Enabled = true;
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
                    frmCabinet cabForm = new frmCabinet();
                    cabForm.Text = "Создать кабинет";
                    Cabinet cabinet = new Cabinet();                    
                    
                    specializations = unitOfWork.Specializations.GetAll();
                    cabForm.comboBox1.DataSource = specializations;
                    
                
                    DialogResult cabResult = cabForm.ShowDialog(this);
                    if (cabResult == DialogResult.Cancel)
                        return;
                    cabinet.number = cabForm.textBox1.Text;            
                    cabinet.cabinetPlan = cabForm.cabinetPlan;
                    cabinet.doctors = cabForm.doctors;
                    Specialization specialization_t1 = (Specialization)cabForm.comboBox1.SelectedItem;
                            
                    if (specialization_t1.cabinets == null)
                        specialization_t1.cabinets = new List<Cabinet>();
                    specialization_t1.cabinets.Add(cabinet);
                 
                    MessageBox.Show(Controller.Service.Add.add(cabinet));
                    cabinets = unitOfWork.Cabinets.GetAll();
                    listBoxAll.DataSource = cabinets;
                    break;
                
                case "ВРАЧИ":
                   
                    frmDoctor docForm = new frmDoctor();
                    docForm.Text = "Создать врача";
                    Doctor doctor = new Doctor();
                    specializations = unitOfWork.Specializations.GetAll(); 
                    regStations = unitOfWork.RegStations.GetAll();
                    doctors = unitOfWork.Doctors.GetAll();

                    docForm.comboBox1.DataSource = specializations;

                    List<Doctor> therapists = new List<Doctor>();
                    
                    for (int i = 0; i < specializations.Count; i++)
                    {
                        if (specializations.ElementAt(i).name == "Терапевт")
                        {
                            therapists = specializations.ElementAt(i).doctors;
                            docForm.therapists = therapists;
                        }
                    }                  
                    List<RegStation> regStations_t = new List<RegStation>();
                    for (int i = 0; i < regStations.Count; i++ )
                    {
                        Doctor doctor_t=therapists.Find(doc => doc.regStation.name == regStations.ElementAt(i).name);
                        if (doctor_t== null)
                        {
                            regStations_t.Add(regStations.ElementAt(i));
                        }
                    }
                    docForm.comboBox3.DataSource = regStations_t;
                  
                    DialogResult docResult = docForm.ShowDialog(this);
                    if (docResult == DialogResult.Cancel)
                        return;                                     
                    
                    Specialization specialization_t2 = (Specialization)docForm.comboBox1.SelectedItem;
                    
                    RegStation regStation2 = (RegStation)docForm.comboBox3.SelectedItem;
                    doctor.name = docForm.textBox1.Text;
                    if (specialization_t2.doctors == null)
                        specialization_t2.doctors = new List<Doctor>();
                    specialization_t2.doctors.Add(doctor);

                    doctor.regStation = regStation2;

                    MessageBox.Show(Controller.Service.Add.add(doctor));
                    doctors = unitOfWork.Doctors.GetAll();
                    listBoxAll.DataSource = doctors;
                    break;
                case "СПЕЦИАЛИЗАЦИИ":
                    
                    frmSpecialization specForm = new frmSpecialization();
                    specForm.Text = "Создать специализацию";
                    DialogResult specResult = specForm.ShowDialog(this);
                    if (specResult == DialogResult.Cancel)
                        return;

                    Specialization specialization = new Specialization();
                    specialization.name = specForm.textBox1.Text;
                    specialization.time = specForm.textBox2.Text;
                    specialization.cabinets = new List<Cabinet>();
                    specialization.doctors = new List<Doctor>();
                    
                    MessageBox.Show(Controller.Service.Add.add(specialization));

                    specializations = unitOfWork.Specializations.GetAll();
                    listBoxAll.DataSource = specializations;
                    break;

                case "УЧАСТКИ":
                    frmRegStation regStForm = new frmRegStation();
                    regStForm.Text = "Создать участок";
                    DialogResult regStResult = regStForm.ShowDialog(this);
                    if (regStResult == DialogResult.Cancel)
                        return;

                     RegStation regStation = new RegStation();
                     regStation.name = regStForm.textBox1.Text;
                     regStation.streets = (List<Street>)regStForm.listBox1.DataSource;
                     MessageBox.Show(Controller.Service.Add.add(regStation));

                     regStations = unitOfWork.RegStations.GetAll();
                     listBoxAll.DataSource = regStations;
        
                     break;

                case "ЛЕКАРСТВА":                  
                     frmDrug drugForm = new frmDrug();
                     drugForm.Text = "Создать лекарство";
                     DialogResult drugResult = drugForm.ShowDialog(this);
                     if (drugResult == DialogResult.Cancel)
                        return;

                     Drug drug = new Drug();
                     drug.name = drugForm.textBox1.Text;
                     MessageBox.Show(Controller.Service.Add.add(drug));

                     drugs = unitOfWork.Drugs.GetAll();
                     listBoxAll.DataSource = drugs;
                     break;

                case "ДИАГНОЗЫ":                                           
                     frmDiagnosis diagForm = new frmDiagnosis();
                     diagForm.Text = "Создать диагноз";
                     DialogResult diagResult = diagForm.ShowDialog(this);
                     if (diagResult == DialogResult.Cancel)
                        return;
                     Diagnosis diagnosis = new Diagnosis();

                     diagnosis.name = diagForm.textBox1.Text;
                     MessageBox.Show(Controller.Service.Add.add(diagnosis));

                     diagnoses = unitOfWork.Diagnoses.GetAll();
                     listBoxAll.DataSource = diagnoses;
                     break;
                              
                case "КАРТОЧКИ ПАЦИЕНТОВ": 
                    frmPatientCard pCardForm = new frmPatientCard();
                    PatientCard patCard = new PatientCard();
                    pCardForm.Text = "Создать карточку";
                    streets = unitOfWork.Streets.GetAll();
                    regStations = unitOfWork.RegStations.GetAll();
                    pCardForm.comboBox2.DataSource = streets;
                     
                    DialogResult pCardResult = pCardForm.ShowDialog(this);
                    if (pCardResult == DialogResult.Cancel)
                        return;
                    
                    patCard.name = pCardForm.textBox1.Text;
                    patCard.creationDate = DateTime.Now;
                    patCard.birthDate = pCardForm.dateTimePicker1.Value;
                   
                    patCard.sex = (string)pCardForm.comboBox1.SelectedItem;
                    patCard.street = (Street)pCardForm.comboBox2.SelectedItem;
                    patCard.houseApartment = pCardForm.textBox4.Text;
                    for (int i = 0; i < regStations.Count; i++)
                    {
                        List<Street> streets_t = regStations[i].streets;
                        for (int j = 0; j < streets_t.Count; j++)
                        {
                            if (streets_t[j]==pCardForm.comboBox2.SelectedItem)
                            {
                                patCard.registrationStation = regStations[i];
                            }
                        }
                    }
                    MessageBox.Show(Controller.Service.Add.add(patCard));
                    patCards = unitOfWork.PatientCards.GetAll();
                    listBoxAll.DataSource = patCards;   

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
                        frmCabinet cabForm = new frmCabinet();
                        cabForm.Text = "Редактировать кабинет";
                        cabPlans = unitOfWork.CabinetPlans.GetAll();
                        cabinets = unitOfWork.Cabinets.GetAll();
                        specializations=unitOfWork.Specializations.GetAll();
                       
                        cabForm.comboBox1.DataSource = specializations;
                        

                        //listBoxAll.DataSource = cabinets;
                        
                        Cabinet cabinet = (Cabinet)listBoxAll.SelectedItem;
                        List<Specialization> spec_temp = new List<Specialization>();  
                        for (int i=0;i<specializations.Count;i++)
                        {
                            Specialization specialization1 = specializations[i];
                            if ( specialization1.cabinets!=null)
                            {
                                spec_temp.Add(specialization1);
                            }
                            
                        }
                        Specialization specialization = spec_temp.Find(spec => spec.cabinets.Contains(cabinet));
                        cabForm.textBox1.Text = cabinet.number;
                        cabForm.comboBox1.SelectedItem = specialization;
                        cabForm.cabinetPlan = cabinet.cabinetPlan;
                        // cabForm.dataGridView1.DataSource = cabinet.cabinetPlans;
                        if (cabinet.cabinetPlan != null)
                        {
                            if (cabinet.cabinetPlan.firstShift_mon != null)
                                cabForm.dataGridView1.Rows[0].Cells[1].Value = cabinet.cabinetPlan.firstShift_mon.name;
                            if (cabinet.cabinetPlan.secondShift_mon != null)
                                cabForm.dataGridView1.Rows[0].Cells[2].Value = cabinet.cabinetPlan.secondShift_mon.name;
                            if (cabinet.cabinetPlan.firstShift_tues != null)
                                cabForm.dataGridView1.Rows[1].Cells[1].Value = cabinet.cabinetPlan.firstShift_tues.name;
                            if (cabinet.cabinetPlan.secondShift_tues != null)
                                cabForm.dataGridView1.Rows[1].Cells[2].Value = cabinet.cabinetPlan.secondShift_tues.name;
                            if (cabinet.cabinetPlan.firstShift_wednes != null)
                                cabForm.dataGridView1.Rows[2].Cells[1].Value = cabinet.cabinetPlan.firstShift_wednes.name;
                            if (cabinet.cabinetPlan.secondShift_wednes != null)
                                cabForm.dataGridView1.Rows[2].Cells[2].Value = cabinet.cabinetPlan.secondShift_wednes.name;
                            if (cabinet.cabinetPlan.firstShift_thurs != null)
                                cabForm.dataGridView1.Rows[3].Cells[1].Value = cabinet.cabinetPlan.firstShift_thurs.name;
                            if (cabinet.cabinetPlan.secondShift_thurs != null)
                                cabForm.dataGridView1.Rows[3].Cells[2].Value = cabinet.cabinetPlan.secondShift_thurs.name;
                            if (cabinet.cabinetPlan.firstShift_fri != null)
                                cabForm.dataGridView1.Rows[4].Cells[1].Value = cabinet.cabinetPlan.firstShift_fri.name;
                            if (cabinet.cabinetPlan.secondShift_fri != null)
                                cabForm.dataGridView1.Rows[4].Cells[2].Value = cabinet.cabinetPlan.secondShift_fri.name;
                            if (cabinet.cabinetPlan.firstShift_satur != null)
                                cabForm.dataGridView1.Rows[5].Cells[1].Value = cabinet.cabinetPlan.firstShift_satur.name;
                            if (cabinet.cabinetPlan.secondShift_satur != null)
                                cabForm.dataGridView1.Rows[5].Cells[2].Value = cabinet.cabinetPlan.secondShift_satur.name;
                            if (cabinet.cabinetPlan.firstShift_sun != null)
                                cabForm.dataGridView1.Rows[6].Cells[1].Value = cabinet.cabinetPlan.firstShift_sun.name;
                            if (cabinet.cabinetPlan.secondShift_sun != null)
                                cabForm.dataGridView1.Rows[6].Cells[2].Value = cabinet.cabinetPlan.secondShift_sun.name;
                        }

                        cabPlans.Remove(cabinet.cabinetPlan);
                        specialization.cabinets.Remove(cabinet);

                        DialogResult cabResult = cabForm.ShowDialog(this);
                        if (cabResult == DialogResult.Cancel)
                            return;
                        cabinet.number = cabForm.textBox1.Text;
                        cabinet.cabinetPlan = cabForm.cabinetPlan;
                        cabinet.doctors = cabForm.doctors;
                        Specialization specialization_t1 = (Specialization)cabForm.comboBox1.SelectedItem;

                        if (specialization_t1.cabinets == null)
                            specialization_t1.cabinets = new List<Cabinet>();
                        specialization_t1.cabinets.Add(cabinet);
                        MessageBox.Show(Controller.Service.Update.update(cabinet));

                        cabinets = unitOfWork.Cabinets.GetAll();
                        listBoxAll.DataSource = cabinets;
                    }
                    break;
                 case "ВРАЧИ":
                    if (listBoxAll.SelectedIndex != -1)
                    {                   
                        frmDoctor docForm = new frmDoctor();
                        docForm.Text = "Редактировать врача";                       
                        doctors = unitOfWork.Doctors.GetAll();
                        specializations = unitOfWork.Specializations.GetAll();
                        regStations = unitOfWork.RegStations.GetAll();
                        Doctor doctor = (Doctor)listBoxAll.SelectedItem;
                        docForm.doctor = doctor;
                        docForm.textBox1.Text = doctor.name;

                        docForm.comboBox1.DataSource = specializations;
                        List<Specialization> spec_temp = new List<Specialization>(); //специализации имеющие врачей
                        List<Doctor> therapists = new List<Doctor>(); //список терапевтов
                        for (int i = 0; i < specializations.Count; i++)
                        {
                            if (specializations[i].doctors != null)
                            {
                                spec_temp.Add(specializations[i]);
                                if (specializations[i].name == "Терапевт")
                                {
                                    therapists=specializations[i].doctors;
                                    docForm.therapists = therapists;
                                }
                            }
                        }
                        Specialization specialization = spec_temp.Find(spec => spec.doctors.Contains(doctor));
                        docForm.comboBox1.SelectedItem = specialization;
                        docForm.specialization_old = specialization;


                        DialogResult docResult = docForm.ShowDialog(this);
                        if (docResult == DialogResult.Cancel)
                            return;
                        RegStation regStation = new RegStation();
                        doctor.name = docForm.textBox1.Text;

                        specialization = (Specialization)docForm.comboBox1.SelectedItem;
                        if (specialization.doctors == null)
                            specialization.doctors = new List<Doctor>();
                        specialization.doctors.Add(doctor);
                                               
                        regStation = (RegStation)docForm.comboBox3.SelectedItem;
                        doctor.regStation = regStation;

                        MessageBox.Show(Controller.Service.Update.update(doctor));
                        doctors = unitOfWork.Doctors.GetAll();
                        listBoxAll.DataSource = doctors;
                    }
                    break;


                    case "СПЕЦИАЛИЗАЦИИ":
                            if (listBoxAll.SelectedIndex != -1)
                            {
                                frmSpecialization specForm = new frmSpecialization();
                                specForm.Text = "Редактировать специализацию";
                                specializations = unitOfWork.Specializations.GetAll();
                                int id = 0;
                                id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                                Specialization specialization = specializations.Find(spec => spec.Id == id);
                                specForm.textBox1.Text = specialization.name;
                                specForm.textBox2.Text = specialization.time;
                                DialogResult specResult = specForm.ShowDialog(this);
                                if (specResult == DialogResult.Cancel)
                                    return;
                                specialization.name = specForm.textBox1.Text;
                                specialization.time = specForm.textBox2.Text;
                                MessageBox.Show(Controller.Service.Update.update(specialization));

                                specializations = unitOfWork.Specializations.GetAll();
                                listBoxAll.DataSource = specializations;
                            }
                            break;

                      case "УЧАСТКИ":
                       
                          if (listBoxAll.SelectedIndex != -1)
                          {                                                                    
                        
                              frmRegStation regStForm = new frmRegStation();
                              regStForm.Text = "Редактировать участок";
                              regStations = unitOfWork.RegStations.GetAll();

                              int id = 0;
                              id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                              RegStation regStation = regStations.Find(regSt => regSt.Id == id);

                              regStForm.textBox1.Text = regStation.name;
                              regStForm.listBox1.DataSource = regStation.streets;                              
                              DialogResult regStResult = regStForm.ShowDialog(this);
                              if (regStResult == DialogResult.Cancel)
                                  return;

                              regStation.name = regStForm.textBox1.Text;              
                              regStation.streets = (List<Street>)regStForm.listBox1.DataSource;
                              MessageBox.Show(Controller.Service.Update.update(regStation));
                             
                              regStations = unitOfWork.RegStations.GetAll();
                              listBoxAll.DataSource = regStations;
                          }
                          break;
                          
                      case "ДИАГНОЗЫ":
                        if (listBoxAll.SelectedIndex != -1)
                        {
                          frmDiagnosis diagForm = new frmDiagnosis();
                              diagForm.Text = "Редактировать диагноз";
                              diagnoses = unitOfWork.Diagnoses.GetAll();
                              int id = 0;
                              id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                              Diagnosis diagnosis = diagnoses.Find(diag => diag.Id == id);
                              diagForm.textBox1.Text = diagnosis.name;
                              DialogResult diagResult = diagForm.ShowDialog(this);
                              if (diagResult == DialogResult.Cancel)
                                  return;
                              diagnosis.name = diagForm.textBox1.Text;
                              MessageBox.Show(Controller.Service.Update.update(diagnosis));

                              diagnoses = unitOfWork.Diagnoses.GetAll();
                              listBoxAll.DataSource = diagnoses;
                          }
                          break;
                      case "ЛЕКАРСТВА":
                        if (listBoxAll.SelectedIndex != -1)
                          {
                              frmDrug drugForm = new frmDrug();
                              drugForm.Text = "Редактировать лекарство";
                              drugs = unitOfWork.Drugs.GetAll();
                              int id = 0;
                              id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                              Drug drug = drugs.Find(drugg => drugg.Id == id);
                              drugForm.textBox1.Text = drug.name;
                              DialogResult drugResult = drugForm.ShowDialog(this);
                              if (drugResult == DialogResult.Cancel)
                                  return;
                              drug.name = drugForm.textBox1.Text;
                              MessageBox.Show(Controller.Service.Update.update(drug));

                              drugs = unitOfWork.Drugs.GetAll();
                              listBoxAll.DataSource = drugs;
                           }
                           break;
                       case "КАРТОЧКИ ПАЦИЕНТОВ":                                              
                           if (listBoxAll.SelectedIndex != -1)
                           {
                               frmPatientCard pCardForm = new frmPatientCard();
                               PatientCard patCard = (PatientCard)listBoxAll.SelectedItem;
                               pCardForm.Text = "Редактировать карточку";
                               streets = unitOfWork.Streets.GetAll();
                               regStations = unitOfWork.RegStations.GetAll();
                               pCardForm.textBox1.Text = patCard.name;
                               pCardForm.dateTimePicker1.Value = patCard.birthDate;
                               pCardForm.comboBox1.SelectedItem = patCard.sex;
                               pCardForm.comboBox2.DataSource = streets;
                               pCardForm.comboBox2.SelectedItem = patCard.street;
                               pCardForm.textBox4.Text = patCard.houseApartment;

                               DialogResult pCardResult = pCardForm.ShowDialog(this);
                               if (pCardResult == DialogResult.Cancel)
                                   return;

                               patCard.name = pCardForm.textBox1.Text;
                               patCard.creationDate = DateTime.Now;
                               patCard.birthDate = pCardForm.dateTimePicker1.Value;
                               patCard.sex = (string)pCardForm.comboBox1.SelectedItem;
                               patCard.street = (Street)pCardForm.comboBox2.SelectedItem;
                               patCard.houseApartment = pCardForm.textBox4.Text;
                               for (int i = 0; i < regStations.Count; i++)
                               {
                                   List<Street> streets_t = regStations[i].streets;
                                   for (int j = 0; j < streets_t.Count; j++)
                                   {
                                       if (streets_t[j] == pCardForm.comboBox2.SelectedItem)
                                       {
                                           patCard.registrationStation = regStations[i];
                                       }
                                   }
                               }
                               MessageBox.Show(Controller.Service.Update.update(patCard));
                               patCards = unitOfWork.PatientCards.GetAll();
                               listBoxAll.DataSource = patCards; 
                           }
                           break;
            }
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
                        id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                        cabPlans = unitOfWork.CabinetPlans.GetAll();
                        cabinets = unitOfWork.Cabinets.GetAll();
                        Cabinet cabinet = cabinets.Find(cab => cab.Id == id);
                        //cabPlans.Remove(cabinet.cabinetPlan);
                        Controller.Service.Remove.remove(cabinet.cabinetPlan);
                        MessageBox.Show(Controller.Service.Remove.remove(cabinet));
                        
                        cabinets = unitOfWork.Cabinets.GetAll();
                        listBoxAll.DataSource = cabinets;                   
                    }
                    break;
                    case "ВРАЧИ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                        doctors = unitOfWork.Doctors.GetAll();
                        Doctor doctor = doctors.Find(doc => doc.Id == id);
                        MessageBox.Show(Controller.Service.Remove.remove(doctor));

                        doctors = unitOfWork.Doctors.GetAll();
                        listBoxAll.DataSource = doctors;
                    }
                    break;
                    case "СПЕЦИАЛИЗАЦИИ":
                        if (listBoxAll.SelectedIndex != -1)
                        {
                            int id = 0;
                            id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                            specializations = unitOfWork.Specializations.GetAll();
                            Specialization specialization = specializations.Find(cab => cab.Id == id);
                            MessageBox.Show(Controller.Service.Remove.remove(specialization));

                        specializations = unitOfWork.Specializations.GetAll();
                        listBoxAll.DataSource = specializations;                   
                        }
                        break;
                    case "УЧАСТКИ":
                        
                        if (listBoxAll.SelectedIndex != -1)
                        {                       
                            int id = 0;
                            id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                            regStations = unitOfWork.RegStations.GetAll();
                            RegStation regStation = regStations.Find(regSt => regSt.Id == id);
                            int n = regStation.streets.Count-1;
                            for (; n >=0; n--)
                            {
                                Controller.Service.Remove.remove(regStation.streets.ElementAt(n));
                            }
                            MessageBox.Show(Controller.Service.Remove.remove(regStation));

                            regStations = unitOfWork.RegStations.GetAll();
                            listBoxAll.DataSource = regStations;

                        }
                        break;
                    case "ДИАГНОЗЫ":
                        if (listBoxAll.SelectedIndex != -1)
                        {
                            int id = 0;
                            id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                            diagnoses = unitOfWork.Diagnoses.GetAll();
                            Diagnosis diagnosis = diagnoses.Find(diag => diag.Id == id);
                            MessageBox.Show(Controller.Service.Remove.remove(diagnosis));

                            diagnoses = unitOfWork.Diagnoses.GetAll();
                            listBoxAll.DataSource = diagnoses;
                        }
                        break;
                case "ЛЕКАРСТВА":
                        if (listBoxAll.SelectedIndex != -1)
                        {
                            int id = 0;
                            id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                            drugs = unitOfWork.Drugs.GetAll();
                            Drug drug = drugs.Find(drugg => drugg.Id == id);
                            MessageBox.Show(Controller.Service.Remove.remove(drug));

                            drugs = unitOfWork.Drugs.GetAll();
                            listBoxAll.DataSource = drugs;
                        }
                        break;
                 case "КАРТОЧКИ ПАЦИЕНТОВ":
                        if (listBoxAll.SelectedIndex != -1)
                        {
                            int id = 0;
                            id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                            patCards = unitOfWork.PatientCards.GetAll();
                            PatientCard pCard = patCards.Find(pC => pC.Id == id);
                            MessageBox.Show(Controller.Service.Remove.remove(pCard));

                            patCards = unitOfWork.PatientCards.GetAll();
                            listBoxAll.DataSource = patCards;
                        }
                        break;
            }
        }
        private void listBoxPatientsVisit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void visitPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
