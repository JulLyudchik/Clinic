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
        List<Diagnosis> diagnoses = new List<Diagnosis>();
        List<Drug> drugs = new List<Drug>();
        List<Doctor> doctors = new List<Doctor>();
        List<Specialization> specializations = new List<Specialization>();
        List<RegStation> regStations = new List<RegStation>();
        List<Cabinet> cabinets = new List<Cabinet>();

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
            regStations = unitOfWork.RegStations.GetAll();
            doctors = unitOfWork.Doctors.GetAll();
            cabinets = unitOfWork.Cabinets.GetAll();            
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
                    frmCabinet cabForm = new frmCabinet();
                    cabForm.Text = "Создать кабинет";
                    DialogResult cabResult = cabForm.ShowDialog(this);
                    if (cabResult == DialogResult.Cancel)
                        return;

                    int id = 0;
                    Cabinet cabinet = new Cabinet();
                    id = Convert.ToInt32(cabForm.comboBox1.SelectedValue.ToString());
                    specializations = unitOfWork.Specializations.GetAll();
                    Specialization specialization_t = specializations.Find(spec => spec.Id == id);
                    cabinet.number = cabForm.textBox1.Text;
                    cabinet.specialization = specialization_t.name;

                    MessageBox.Show(Controller.Service.Add.add(cabinet));
                    cabinets = unitOfWork.Cabinets.GetAll();
                    listBoxAll.DataSource = cabinets;
                    break;

                /*case "ВРАЧИ":
                   frmDoctor docForm = new frmDoctor();
                   docForm.Text = "Создать врача";
                   DialogResult docResult = docForm.ShowDialog(this);
                    if (docResult == DialogResult.Cancel)
                        return;
                    int id2 = 0;
                    int id3 = 0;
                    int id4 = 0;
                    bool converted2 = Int32.TryParse(docForm.comboBox1.SelectedValue.ToString(), out id2);
                    if (converted2 == false) 
                        return;
                    bool converted3 = Int32.TryParse(docForm.comboBox2.SelectedValue.ToString(), out id3);
                    if (converted3 == false) 
                        return;
                    bool converted4 = Int32.TryParse(docForm.comboBox3.SelectedValue.ToString(), out id4);
                    if (converted4 == false) 
                        return;
                    Doctor doctor = new Doctor();
                    Specialization specialization_t2 = db.specializations.Find(id2);
                    Cabinet cabinet_t = db.cabinets.Find(id3);
                    RegStation regStation2 = db.regStations.Find(id4);
                    doctor.name = docForm.textBox1.Text;
                    doctor.specialization = specialization_t2.name;
                    doctor.cabinet = cabinet_t.number;
                    //doctor.regStation = regStation2.name;
                    db.doctors.Add(doctor);
                    db.SaveChanges();
                    db.doctors.Load();
                    listBoxAll.DataSource = db.doctors.Local.ToList();
                    MessageBox.Show("Новый объект добавлен");
                    break;*/
                case "СПЕЦИАЛИЗАЦИИ":
                    /*frmCabinet cabForm = new frmCabinet();
                    cabForm.Text = "Создать кабинет";
                    DialogResult cabResult = cabForm.ShowDialog(this);
                    if (cabResult == DialogResult.Cancel)
                        return;

                    int id = 0;
                    Cabinet cabinet = new Cabinet();
                    id = Convert.ToInt32(cabForm.comboBox1.SelectedValue.ToString());
                    specializations = unitOfWork.Specializations.GetAll();
                    Specialization specialization_t = specializations.Find(spec => spec.Id == id);
                    cabinet.number = cabForm.textBox1.Text;
                    cabinet.specialization = specialization_t.name;

                    MessageBox.Show(Controller.Service.Add.add(cabinet));
                    cabinets = unitOfWork.Cabinets.GetAll();
                    listBoxAll.DataSource = cabinets;
                    break;*/
                    frmSpecialization specForm = new frmSpecialization();
                    specForm.Text = "Создать специализацию";
                    DialogResult specResult = specForm.ShowDialog(this);
                    if (specResult == DialogResult.Cancel)
                        return;

                    Specialization specialization = new Specialization();
                    specialization.name = specForm.textBox1.Text;
                    specialization.time = specForm.textBox2.Text;
                    MessageBox.Show(Controller.Service.Add.add(specialization));

                    specializations = unitOfWork.Specializations.GetAll();
                    listBoxAll.DataSource = specializations;
                    break;
                /*case "УЧАСТКИ":
                    
                    frmRegStation regStForm = new frmRegStation();
                    regStForm.Text = "Создать участок";
                    DialogResult regStResult = regStForm.ShowDialog(this);
                    if (regStResult == DialogResult.Cancel)
                        return;

                    RegStation regStation = new RegStation();
                    regStation.name = regStForm.textBox1.Text;
                    db.regStations.Add(regStation);
                    db.SaveChanges();
                    List<Street> streets = new List<Street>();
                    for (int i = 0; i < regStForm.listBox1.Items.Count; i++ )
                    {
                        Street street = new Street{name=(string)regStForm.listBox1.Items[i],regStation=regStation};
                        streets.Add(street);                        
                    }
                    db.streets.AddRange(streets);
                    db.SaveChanges();          
                          
                    db.regStations.Load();
                    listBoxAll.DataSource = db.regStations.Local.ToList();                  
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case "ЛЕКАРСТВА":                  
                    frmDrug drugForm = new frmDrug();
                    drugForm.Text = "Создать лекарство";
                    DialogResult drugResult = drugForm.ShowDialog(this);
                    if (drugResult == DialogResult.Cancel)
                        return;
                    Drug drug = new Drug();
                    drug.name = drugForm.textBox1.Text;
                    db.drugs.Add(drug);
                    db.SaveChanges();               
                    db.drugs.Load();
                    listBoxAll.DataSource = db.drugs.Local.ToList();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case "ДИАГНОЗЫ":
                    //formCreateDiag = new frmCreateDiag();
                    //                    
                    frmDiagnosis diagForm = new frmDiagnosis();
                    diagForm.Text = "Создать диагноз";
                    DialogResult diagResult = diagForm.ShowDialog(this);
                    if (diagResult == DialogResult.Cancel)
                        return;
                    Diagnosis diagnosis = new Diagnosis();
                    diagnosis.name = diagForm.textBox1.Text;
                    db.diagnoses.Add(diagnosis);
                    db.SaveChanges();                   
                    db.diagnoses.Load();
                    listBoxAll.DataSource = db.diagnoses.Local.ToList();
                    MessageBox.Show("Новый объект добавлен");
                    //                  
                    //formCreateDiag.Show();
                    break;
                case "КАРТОЧКИ ПАЦИЕНТОВ": 
                    formCreateCard = new frmPatientCard();
                    formCreateCard.Show();
                    break;*/
            }

        }

        /*private void clearStreets()
        {
            db.streets.Load();
            List<Street> delStreets = db.streets.ToList();
            foreach (Street st in delStreets)
            {
                if (st.RegStationId == null)
                {
                    db.streets.Remove(st);
                }
            }
            db.SaveChanges();
        }*/
        private void editCardButton_Click(object sender, EventArgs e)
        {
            switch (labelAll.Text)
            {
                case "КАБИНЕТЫ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        frmCabinet cabForm = new frmCabinet();
                        cabForm.Text = "Редактировать кабинет";
                        int id = 0;
                        id = Convert.ToInt32(listBoxAll.SelectedValue.ToString());
                        cabinets = unitOfWork.Cabinets.GetAll();
                        Cabinet cabinet = cabinets.Find(cab => cab.Id == id);
                        cabForm.textBox1.Text = cabinet.number;
                        cabForm.comboBox1.SelectedItem = cabinet.specialization;

                        DialogResult cabResult = cabForm.ShowDialog(this);
                        if (cabResult == DialogResult.Cancel)
                            return;
                        cabinet.number = cabForm.textBox1.Text;
                        cabinet.specialization = cabForm.comboBox1.SelectedText;
                        MessageBox.Show(Controller.Service.Update.update(cabinet));

                        cabinets = unitOfWork.Cabinets.GetAll();
                        listBoxAll.DataSource = cabinets;
                    }
                    break;
                /*case "ВРАЧИ":
                    
                    break;
                case "СПЕЦИАЛИЗАЦИИ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;
                        Specialization specialization = db.specializations.Find(id);
                        frmSpecialization specForm = new frmSpecialization();
                        specForm.Text = "Редактировать специализацию";
                        specForm.textBox1.Text = specialization.name;
                        specForm.textBox2.Text = specialization.time;
                        DialogResult specResult = specForm.ShowDialog(this);
                        if (specResult == DialogResult.Cancel)
                            return;
                        specialization.name = specForm.textBox1.Text;
                        specialization.time = specForm.textBox2.Text;
                        db.SaveChanges();
                        db.specializations.Load();
                        listBoxAll.DataSource = db.specializations.Local.ToList();
                        MessageBox.Show("Объект обновлен");
                    }
                    break;
                case "УЧАСТКИ":
                    if (listBoxAll.SelectedIndex != -1)
                    {                                               
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;
                        db.streets.Load();                       
                        RegStation regStation = db.regStations.Find(id);

                        frmRegStation regStForm = new frmRegStation();
                        regStForm.Text = "Редактировать участок";

                        regStForm.textBox1.Text = regStation.name;
                        foreach (Street st in regStation.streets)
                        {                         
                            regStForm.listBox1.Items.Add(st.name);
                        }
                     
                        DialogResult regStResult = regStForm.ShowDialog(this);
                        if (regStResult == DialogResult.Cancel)
                            return;

                        regStation.name = regStForm.textBox1.Text;              
                        List<Street> streets = new List<Street>();
                        for (int i = 0; i < regStForm.listBox1.Items.Count; i++)
                        {
                            Street street = new Street { name = (string)regStForm.listBox1.Items[i], regStation = regStation };
                            streets.Add(street);
                        }
                        regStation.streets = streets;
                        db.Entry(regStation).State = EntityState.Modified;                       
                        db.SaveChanges();
                        clearStreets();

                        db.regStations.Load();
                        listBoxAll.DataSource = db.regStations.Local.ToList();
                        MessageBox.Show("Объект обновлен");
                    }
                    break;
                case "ДИАГНОЗЫ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                         if(converted == false)
                            return;
                        Diagnosis diagnosis = db.diagnoses.Find(id);                    
                        frmDiagnosis diagForm = new frmDiagnosis();
                        diagForm.Text = "Редактировать диагноз";
                        
                        diagForm.textBox1.Text = diagnosis.name;
                        DialogResult diagResult = diagForm.ShowDialog(this);
                        if (diagResult == DialogResult.Cancel)
                            return;
                                                
                        diagnosis.name = diagForm.textBox1.Text;
                        
                        db.SaveChanges();                       
                        db.diagnoses.Load();
                        listBoxAll.DataSource = db.diagnoses.Local.ToList();
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

                        Drug drug = db.drugs.Find(id);
                        frmDrug drugForm = new frmDrug();
                        drugForm.Text = "Редактировать лекарство";
                        drugForm.textBox1.Text = drug.name;
                        DialogResult drugResult = drugForm.ShowDialog(this);
                        if (drugResult == DialogResult.Cancel)
                            return;
                        drug.name = drugForm.textBox1.Text;
                        db.SaveChanges();
                        db.drugs.Load();
                        listBoxAll.DataSource = db.drugs.Local.ToList();
                        MessageBox.Show("Объект обновлен");
                    }
                    //formEditDrug.Show();
                    break;
                case "КАРТОЧКИ ПАЦИЕНТОВ":
                    
                    break;*/
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
            /*switch (labelAll.Text)
            {
                case "КАБИНЕТЫ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;

                        Cabinet cabinet = db.cabinets.Find(id);
                        db.cabinets.Remove(cabinet);
                        db.SaveChanges();
                        db.cabinets.Load();
                        listBoxAll.DataSource = db.cabinets.Local.ToList();
                        MessageBox.Show("Объект удален");
                    }
                    break;
                case "ВРАЧИ":
                    
                    break;
                case "СПЕЦИАЛИЗАЦИИ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;

                        Specialization specialization = db.specializations.Find(id);
                        db.specializations.Remove(specialization);
                        db.SaveChanges();
                        db.specializations.Load();
                        listBoxAll.DataSource = db.specializations.Local.ToList();
                        MessageBox.Show("Объект удален");
                    }
                    break;
                case "УЧАСТКИ":
                    if (listBoxAll.SelectedIndex != -1)
                    {                       
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;
                        db.streets.Load();
                        RegStation regStation = db.regStations.Find(id);
                        db.regStations.Remove(regStation);
                        db.SaveChanges();
                        clearStreets();
                                      
                        db.regStations.Load();
                        listBoxAll.DataSource = db.regStations.Local.ToList();
                        MessageBox.Show("Объект удален");
                    }
                    break;
                case "ДИАГНОЗЫ":
                    if (listBoxAll.SelectedIndex != -1)
                    {
                        int id = 0;
                        bool converted = Int32.TryParse(listBoxAll.SelectedValue.ToString(), out id);
                        if (converted == false)
                            return;

                        Diagnosis diagnosis = db.diagnoses.Find(id);
                        db.diagnoses.Remove(diagnosis);
                        db.SaveChanges();
                        db.diagnoses.Load();
                        listBoxAll.DataSource = db.diagnoses.Local.ToList();
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

                        Drug drug = db.drugs.Find(id);
                        db.drugs.Remove(drug);
                        db.SaveChanges();
                        db.drugs.Load();
                        listBoxAll.DataSource = db.drugs.Local.ToList();
                        MessageBox.Show("Объект удален");
                    }
                    break;
                case "КАРТОЧКИ ПАЦИЕНТОВ":
                    
                    break;
            }*/
        }
        private void listBoxPatientsVisit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
