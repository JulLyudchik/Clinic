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
        List<Ticket> tickets;
        List<Visit> visits;
        List<Ticket> dayPlan;
        
        Cabinet cabForTicket = new Cabinet();

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
            visits = unitOfWork.Visits.GetAll();
            patCards = unitOfWork.PatientCards.GetAll();
            cabPlans = unitOfWork.CabinetPlans.GetAll();
            tickets = unitOfWork.Tickets.GetAll();
            
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
            dateTimePicker1.Enabled = false;
            comboBoxTime.Enabled = false;
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
            int n = 0;
            for (int i = 0; i < listBoxPatientsVisit.Items.Count; i++)          
            {
                if (((Ticket)listBoxPatientsVisit.Items[i]).check == true)
                {
                    n++;
                }
            }
            MessageBox.Show("Явился(ось) " + n + " пациет(ов). " + (listBoxPatientsVisit.Items.Count-n)+" пациент(ов) не пришёл(ло).");
        }

        private void button6_Click(object sender, EventArgs e)//принять пациентов
        {
            visitPanel.Visible = true;
            mainPanel.Visible = false;
            patCards = unitOfWork.PatientCards.GetAll();
            
           // listBoxPatientsVisit.ValueMember = "Id";
           // listBoxPatientsVisit.DisplayMember = "Name";
            listBoxPatientsVisit.SelectedIndex = -1;
            tickets = unitOfWork.Tickets.GetAll();
            List<Ticket> todayPlan = new List<Ticket>();
            foreach(Ticket ticket in tickets)
            {
                int day = ticket.date.DayOfYear;
                int daytoday = DateTime.Today.DayOfYear;
                if(("Вы вошли как: "+ticket.doctor.name==labelDoctor.Text) && (day == DateTime.Today.DayOfYear))
                {
                    todayPlan.Add(ticket);
                }
            }
            listBoxPatientsVisit.DataSource = todayPlan;
            dayPlan = todayPlan;
            listBoxPatientsVisit.DisplayMember = "time";
        }


        private void button33_Click(object sender, EventArgs e) // запись на прием
        {
            formTicket = new frmTicket();
            formTicket.Owner = this;
            formTicket.Show();
            PatientCard patCard = (PatientCard)comboBoxNamePac.SelectedItem;
            formTicket.labelPac.Text = patCard.name;
            Specialization spec = (Specialization)comboBoxSpec.SelectedItem;
            formTicket.labelDocSpec.Text = spec.name;
            Doctor doc = (Doctor)comboBoxNameDoc.SelectedItem;
            formTicket.labelDocName.Text = doc.name;
            String date = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            formTicket.labelDate.Text = date;
            formTicket.labelTime.Text = comboBoxTime.SelectedItem.ToString();
            formTicket.labelCab.Text = cabForTicket.number;

            Ticket ticket = new Ticket();
            ticket.date = dateTimePicker1.Value;
            ticket.time = comboBoxTime.SelectedItem.ToString();
            ticket.doctor = doc;
            ticket.specialization = spec;
            ticket.cabinet = cabForTicket;
            ticket.patCard = patCard;
            formTicket.ticket = ticket;
            Controller.Service.Add.add(ticket);
          
            tickets = unitOfWork.Tickets.GetAll();

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
            dateTimePicker1.Enabled = false;
            comboBoxTime.Enabled = false;
            patRecButton.Enabled = false;
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(1,0,0,0);
            dt.Subtract(ts);
            dateTimePicker1.Value=dt;

        }


        private void listBox7_MouseDoubleClick(object sender, MouseEventArgs e) //прием пациента
        {
            if (listBoxPatientsVisit.SelectedItem != null && ((Ticket)(listBoxPatientsVisit.SelectedItem)).check==false)
            {
                
                formPatList = new frmPat();
                formPatList.Owner = this;
                
                Visit visit = new Visit();
                visits = unitOfWork.Visits.GetAll();
                patCards = unitOfWork.PatientCards.GetAll();
                tickets = unitOfWork.Tickets.GetAll();     
                Ticket ticket = (Ticket)listBoxPatientsVisit.SelectedItem;
                for (int i = 0; i < dayPlan.Count; i++)
                {
                    if (dayPlan[i] == ticket)
                    {
                        dayPlan[i].check = true;
                    }
                }
                formPatList.dayPlan = dayPlan;
                PatientCard patCard = patCards.Find(pC => pC == ticket.patCard);
                formPatList.Text = patCard.name;
                formPatList.labelFIO.Text = patCard.name;
                formPatList.labelDate.Text = patCard.birthDate.ToShortDateString();
                diagnoses = unitOfWork.Diagnoses.GetAll();
                formPatList.comboBox1.DataSource = diagnoses;
                drugs = unitOfWork.Drugs.GetAll();   
                formPatList.comboBox2.DataSource = drugs;
                
                for (int i = 0; i < visits.Count; i++)
                {
                    if (ticket.patCard.visits==null)
                    {
                        patCard.visits = new List<Visit>();
                    }
                    else if(ticket.patCard.visits.Contains(visits[i]))
                    {
                        for (int k = 0; k < patCard.visits.Count; k++)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            formPatList.dataGridView1.Rows.Add(row);
                            string date_t = visits[i].date.ToString("dd.MM.yyyy"); ;
                            formPatList.dataGridView1.Rows[k].Cells[0].Value = date_t;
                            string specialization_t = visits[i].speciazation.name;
                            formPatList.dataGridView1.Rows[k].Cells[1].Value = specialization_t;
                            string doctor_t = visits[i].doctor.name;
                            formPatList.dataGridView1.Rows[k].Cells[2].Value = doctor_t;
                            string diagnoses_t = "";
                            for (int j = 0; j < visits[i].diagnoses.Count; j++)
                            {
                                diagnoses_t += visits[i].diagnoses[j].name + ", ";
                            }
                            formPatList.dataGridView1.Rows[k].Cells[3].Value = diagnoses_t;
                            string drugs_t = "";
                            for (int j = 0; j < visits[i].drugs.Count; j++)
                            {
                                drugs_t += visits[i].drugs[j].name + ", ";
                            }
                            formPatList.dataGridView1.Rows[k].Cells[4].Value = drugs_t;
                        }
                    }
                }
 
                DialogResult patResult = formPatList.ShowDialog(this);
                if (patResult == DialogResult.Cancel)
                    return;
                visit.date = ticket.date;
                visit.speciazation = ticket.specialization;
                visit.doctor = ticket.doctor;
                for (int i = 0; i < formPatList.listBoxDiag.Items.Count; i++)
                {
                    if (visit.diagnoses == null)
                    {
                        visit.diagnoses = new List<Diagnosis>();
                    }
                    visit.diagnoses.Add((Diagnosis)formPatList.listBoxDiag.Items[i]);
                }
                for (int i = 0; i < formPatList.listBoxDrug.Items.Count; i++)
                {
                    if (visit.drugs == null)
                    {
                        visit.drugs=new List<Drug>();
                    }
                    visit.drugs.Add((Drug)formPatList.listBoxDrug.Items[i]);
                }
                MessageBox.Show(Controller.Service.Add.add(visit));
                patCard.visits.Add(visit);
                Controller.Service.Update.update(patCard);
                   
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
            dateTimePicker1.Enabled = true;
            comboBoxTime.Enabled = true;
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
                    cabForm.Owner = this;
                    cabForm.Text = "Создать кабинет";
                    cabForm.ControlBox = true;
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
                            
                        }

                       

                        DialogResult cabResult = cabForm.ShowDialog(this);
                        if (cabResult == DialogResult.Cancel)
                            return;
                        cabPlans.Remove(cabinet.cabinetPlan);
                        specialization.cabinets.Remove(cabinet);
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

      
        private void visitPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
            DateTime firstShift_start = new DateTime(1,1,1,8,0,0) ;
            DateTime secondShift_start = new DateTime(1, 1, 1, 14, 0, 0);
            DateTime secondShift_end = new DateTime(1, 1, 1, 20, 0, 0);

            //из комбобокса достаем текущего врача
            Doctor doctor = (Doctor)comboBoxNameDoc.SelectedItem;
            //из деттайм достаем день недели
            String day = dateTimePicker1.Value.DayOfWeek.ToString();
            int dayCheck = DateTime.Today.DayOfYear;
            int daySelected = dateTimePicker1.Value.DayOfYear;
            //из специализации достаем интервал
            Specialization spec = (Specialization)comboBoxSpec.SelectedItem;
            int time = Convert.ToInt32(spec.time);
            // подгружаем кабинеты для нужной специализации
            Cabinet cab1 = new Cabinet();
            cabinets = spec.cabinets;
            foreach (Cabinet cab in cabinets)
            {
                cab1 = cabinets.Find(c => cab.doctors.Contains(doctor));
            }
            // из подгруженных по списку каблист находим тот, у которого или фирст или секонд с определенным днем недели наш
            if (daySelected >= dayCheck)
            {
                if (cab1 != null)
                {
                    switch (day)
                    {
                        case ("Monday"):

                            Cabinet cabinetFirst_mon = cabinets.Find(cab => cab.cabinetPlan.firstShift_mon.name == doctor.name);
                            if (cabinetFirst_mon != null)
                            {   
                                //Если уже существует тикет с тикет.тайм == start и в этом же тикете текущий врач - не добавлять время
                                
                                DateTime start = firstShift_start;
                                List<string> timeInterval = createListIntervals(firstShift_start, secondShift_start, start, doctor, time);
                                comboBoxTime.DataSource = timeInterval;

                                cabForTicket = cabinetFirst_mon;
                            }
                            else
                            {
                                Cabinet cabinetSecond_mon = cabinets.Find(cab => cab.cabinetPlan.secondShift_mon.name == doctor.name);
                                DateTime start = secondShift_start;
                                List<string> timeIntervall = createListIntervals(secondShift_start, secondShift_end, start, doctor, time);
                                comboBoxTime.DataSource = timeIntervall;
                                cabForTicket = cabinetSecond_mon;
                            }
                            break;
                        case ("Tuesday"):
                            Cabinet cabinetFirst_tues = cabinets.Find(cab => cab.cabinetPlan.firstShift_tues.name == doctor.name);
                            if (cabinetFirst_tues != null)
                            {
                                DateTime start = firstShift_start;
                                List<string> timeInterval = createListIntervals(firstShift_start, secondShift_start, start, doctor, time);
                                comboBoxTime.DataSource = timeInterval;
                                cabForTicket = cabinetFirst_tues;
                            }
                            else
                            {
                                Cabinet cabinetSecond_tues = cabinets.Find(cab => cab.cabinetPlan.secondShift_tues.name == doctor.name);
                                DateTime start = secondShift_start;
                                List<string> timeIntervall = createListIntervals(secondShift_start, secondShift_end, start, doctor, time);
                                comboBoxTime.DataSource = timeIntervall;
                                cabForTicket = cabinetSecond_tues;
                            }
                            break;
                        case ("Wednesday"):
                            Cabinet cabinetFirst_wednes = cabinets.Find(cab => cab.cabinetPlan.firstShift_wednes.name == doctor.name);
                            if (cabinetFirst_wednes != null)
                            {
                                DateTime start = firstShift_start;
                                List<string> timeInterval = createListIntervals(firstShift_start, secondShift_start, start, doctor, time);
                                comboBoxTime.DataSource = timeInterval;
                                cabForTicket = cabinetFirst_wednes;
                            }
                            else
                            {
                                Cabinet cabinetSecond_wednes = cabinets.Find(cab => cab.cabinetPlan.secondShift_wednes.name == doctor.name);
                                DateTime start = secondShift_start;
                                List<string> timeIntervall = createListIntervals(secondShift_start, secondShift_end, start, doctor, time);
                                comboBoxTime.DataSource = timeIntervall;
                                cabForTicket = cabinetSecond_wednes;
                            }

                            break;
                        case ("Thursday"):
                            Cabinet cabinetFirst_thurs = cabinets.Find(cab => cab.cabinetPlan.firstShift_thurs.name == doctor.name);
                            if (cabinetFirst_thurs != null)
                            {
                                DateTime start = firstShift_start;
                                List<string> timeInterval = createListIntervals(firstShift_start, secondShift_start, start, doctor, time);
                                comboBoxTime.DataSource = timeInterval;
                                cabForTicket = cabinetFirst_thurs;
                            }
                            else
                            {
                                Cabinet cabinetSecond_thurs = cabinets.Find(cab => cab.cabinetPlan.secondShift_thurs.name == doctor.name);
                                DateTime start = secondShift_start;
                                List<string> timeIntervall = createListIntervals(secondShift_start, secondShift_end, start, doctor, time);
                                comboBoxTime.DataSource = timeIntervall;
                                cabForTicket = cabinetSecond_thurs;
                            }

                            break;
                        case ("Friday"):
                            Cabinet cabinetFirst_fri = cabinets.Find(cab => cab.cabinetPlan.firstShift_fri.name == doctor.name);
                            if (cabinetFirst_fri != null)
                            {
                                DateTime start = firstShift_start;
                                List<string> timeInterval = createListIntervals(firstShift_start, secondShift_start, start, doctor, time);
                                comboBoxTime.DataSource = timeInterval;
                                cabForTicket = cabinetFirst_fri;
                            }
                            else
                            {
                                Cabinet cabinetSecond_fri = cabinets.Find(cab => cab.cabinetPlan.secondShift_fri.name == doctor.name);
                                DateTime start = secondShift_start;
                                List<string> timeIntervall = createListIntervals(secondShift_start, secondShift_end, start, doctor, time);
                                comboBoxTime.DataSource = timeIntervall;
                                cabForTicket = cabinetSecond_fri;
                            }

                            break;
                        case ("Saturday"):
                            MessageBox.Show("Поликлиника не работает");

                            break;
                        case ("Sunday"):
                            MessageBox.Show("Поликлиника не работает");

                            break;
                    }
                }
                else
                    MessageBox.Show("У этого врача нет кабинета!");
            }
            else
                MessageBox.Show("Эта дата уже прошла!");
            
            
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            patCards = unitOfWork.PatientCards.GetAll();
            PatientCard patCard = (PatientCard)comboBoxNamePac.SelectedItem;
            tickets = unitOfWork.Tickets.GetAll();
            string time = comboBoxTime.SelectedItem.ToString();
            int day = dateTimePicker1.Value.DayOfYear;
            
            Ticket ticket = new Ticket();
            if (tickets.Count > 0)
            {
                for (int i = 0; i < tickets.Count; i++)
                {
                    if (tickets[i].patCard == patCard)
                    {
                        ticket = tickets[i];
                        int day1 = ticket.date.DayOfYear;
                        if ((ticket.time == time) && (day == day1))
                        {
                            MessageBox.Show("Пациент уже записан на это время!");
                        }
                        else
                        {
                            patRecButton.Enabled = true;
                        }
                    }
                }
                patRecButton.Enabled = true;
            }
            else
            {
                patRecButton.Enabled = true;
            }


        }

        private List<string> createListIntervals(DateTime shift_start, DateTime shift_end, DateTime start, Doctor doctor, int time)
        {
            List<String> timeIntervall = new List<String>();
            while (start.CompareTo(shift_end) < 0)
            {

                Ticket ticketDoctor1 = new Ticket();

                ticketDoctor1 = tickets.Find(tic => tic.doctor == doctor);
                if (ticketDoctor1 != null)
                {
                    if (ticketDoctor1.time != start.ToShortTimeString())
                        timeIntervall.Add(start.ToShortTimeString());
                    start = start.AddMinutes(time);
                }
                else
                {
                    timeIntervall.Add(start.ToShortTimeString());
                    start = start.AddMinutes(time);
                }
            }


            for (int i = 0; i < tickets.Count; i++)

            {
                start = shift_start;
                while (start.CompareTo(shift_end) < 0)
                {
                    Ticket ticketDoctor = new Ticket();
                    if (tickets[i].doctor == doctor)
                    {
                        ticketDoctor = tickets[i];
                        string timer = ticketDoctor.time;
                        if (ticketDoctor.time == start.ToShortTimeString())
                            timeIntervall.Remove(start.ToShortTimeString());
                    }
                    start = start.AddMinutes(time);
                }

            }
            return timeIntervall;
        }
    }
}
