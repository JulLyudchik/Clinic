namespace Presentation
{
    partial class frmStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.labelDoct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLb1 = new System.Windows.Forms.Label();
            this.pictureBoxStripe = new System.Windows.Forms.PictureBox();
            this.patientRecPanel = new System.Windows.Forms.Panel();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNameDoc = new System.Windows.Forms.ComboBox();
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.comboBoxNamePac = new System.Windows.Forms.ComboBox();
            this.patRecButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.regPanel = new System.Windows.Forms.Panel();
            this.regCardsButton = new System.Windows.Forms.Button();
            this.regRecordButton = new System.Windows.Forms.Button();
            this.visitPanel = new System.Windows.Forms.Panel();
            this.lable8 = new System.Windows.Forms.Label();
            this.createReportButton = new System.Windows.Forms.Button();
            this.listBoxPatientsVisit = new System.Windows.Forms.ListBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createItemButton = new System.Windows.Forms.Button();
            this.labelAll = new System.Windows.Forms.Label();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.listBoxAll = new System.Windows.Forms.ListBox();
            this.docPanel = new System.Windows.Forms.Panel();
            this.doctorVisitButton = new System.Windows.Forms.Button();
            this.doctorDrugButton = new System.Windows.Forms.Button();
            this.doctorDiagButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.adminDrugButton = new System.Windows.Forms.Button();
            this.adminDiagButton = new System.Windows.Forms.Button();
            this.adminAddressButton = new System.Windows.Forms.Button();
            this.adminSpecButton = new System.Windows.Forms.Button();
            this.adminDocButton = new System.Windows.Forms.Button();
            this.adminCabinetButton = new System.Windows.Forms.Button();
            this.registratorButton = new System.Windows.Forms.Button();
            this.doctorButton = new System.Windows.Forms.Button();
            this.administratorButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStripe)).BeginInit();
            this.patientRecPanel.SuspendLayout();
            this.regPanel.SuspendLayout();
            this.visitPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.docPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bottomPanel.Controls.Add(this.labelDoctor);
            this.bottomPanel.Controls.Add(this.enterButton);
            this.bottomPanel.Controls.Add(this.labelDoct);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.TimeLb1);
            this.bottomPanel.Controls.Add(this.pictureBoxStripe);
            this.bottomPanel.Controls.Add(this.patientRecPanel);
            this.bottomPanel.Controls.Add(this.regPanel);
            this.bottomPanel.Controls.Add(this.visitPanel);
            this.bottomPanel.Controls.Add(this.mainPanel);
            this.bottomPanel.Controls.Add(this.docPanel);
            this.bottomPanel.Controls.Add(this.adminPanel);
            this.bottomPanel.Location = new System.Drawing.Point(0, 66);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(902, 520);
            this.bottomPanel.TabIndex = 4;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomPanel_Paint);
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(689, 503);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(0, 13);
            this.labelDoctor.TabIndex = 15;
            // 
            // enterButton
            // 
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.enterButton.Location = new System.Drawing.Point(842, 500);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(58, 21);
            this.enterButton.TabIndex = 14;
            this.enterButton.Text = "ВЫХОД";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Visible = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // labelDoct
            // 
            this.labelDoct.AutoSize = true;
            this.labelDoct.Location = new System.Drawing.Point(719, 504);
            this.labelDoct.Name = "labelDoct";
            this.labelDoct.Size = new System.Drawing.Size(0, 13);
            this.labelDoct.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Время сеанса:";
            // 
            // TimeLb1
            // 
            this.TimeLb1.AutoSize = true;
            this.TimeLb1.Location = new System.Drawing.Point(91, 505);
            this.TimeLb1.Name = "TimeLb1";
            this.TimeLb1.Size = new System.Drawing.Size(49, 13);
            this.TimeLb1.TabIndex = 11;
            this.TimeLb1.Text = "00:00:00";
            // 
            // pictureBoxStripe
            // 
            this.pictureBoxStripe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStripe.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxStripe.Name = "pictureBoxStripe";
            this.pictureBoxStripe.Size = new System.Drawing.Size(904, 53);
            this.pictureBoxStripe.TabIndex = 0;
            this.pictureBoxStripe.TabStop = false;
            // 
            // patientRecPanel
            // 
            this.patientRecPanel.Controls.Add(this.comboBoxTime);
            this.patientRecPanel.Controls.Add(this.dateTimePicker1);
            this.patientRecPanel.Controls.Add(this.comboBoxNameDoc);
            this.patientRecPanel.Controls.Add(this.comboBoxSpec);
            this.patientRecPanel.Controls.Add(this.comboBoxNamePac);
            this.patientRecPanel.Controls.Add(this.patRecButton);
            this.patientRecPanel.Controls.Add(this.label7);
            this.patientRecPanel.Location = new System.Drawing.Point(228, 56);
            this.patientRecPanel.Name = "patientRecPanel";
            this.patientRecPanel.Size = new System.Drawing.Size(674, 443);
            this.patientRecPanel.TabIndex = 10;
            this.patientRecPanel.Visible = false;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(63, 257);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(250, 21);
            this.comboBoxTime.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxNameDoc
            // 
            this.comboBoxNameDoc.DisplayMember = "Name";
            this.comboBoxNameDoc.Enabled = false;
            this.comboBoxNameDoc.FormattingEnabled = true;
            this.comboBoxNameDoc.Items.AddRange(new object[] {
            "Иванов",
            "Петров",
            "Сидоров"});
            this.comboBoxNameDoc.Location = new System.Drawing.Point(63, 167);
            this.comboBoxNameDoc.Name = "comboBoxNameDoc";
            this.comboBoxNameDoc.Size = new System.Drawing.Size(250, 21);
            this.comboBoxNameDoc.TabIndex = 8;
            this.comboBoxNameDoc.Text = "Имя врача";
            this.comboBoxNameDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameDoc_SelectedIndexChanged);
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.DisplayMember = "Name";
            this.comboBoxSpec.Enabled = false;
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Items.AddRange(new object[] {
            "Хирург",
            "Офтальмолог",
            "Стоматолог"});
            this.comboBoxSpec.Location = new System.Drawing.Point(63, 126);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(250, 21);
            this.comboBoxSpec.TabIndex = 7;
            this.comboBoxSpec.Text = "Специализация";
            this.comboBoxSpec.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpec_SelectedIndexChanged);
            // 
            // comboBoxNamePac
            // 
            this.comboBoxNamePac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamePac.FormattingEnabled = true;
            this.comboBoxNamePac.Items.AddRange(new object[] {
            "Иванов",
            "Петров",
            "Сидоров"});
            this.comboBoxNamePac.Location = new System.Drawing.Point(63, 80);
            this.comboBoxNamePac.Name = "comboBoxNamePac";
            this.comboBoxNamePac.Size = new System.Drawing.Size(250, 21);
            this.comboBoxNamePac.TabIndex = 6;
            this.comboBoxNamePac.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamePac_SelectedIndexChanged);
            // 
            // patRecButton
            // 
            this.patRecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patRecButton.Enabled = false;
            this.patRecButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.patRecButton.FlatAppearance.BorderSize = 4;
            this.patRecButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.patRecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patRecButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patRecButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.patRecButton.Location = new System.Drawing.Point(247, 374);
            this.patRecButton.Name = "patRecButton";
            this.patRecButton.Size = new System.Drawing.Size(182, 44);
            this.patRecButton.TabIndex = 5;
            this.patRecButton.Text = "Записать";
            this.patRecButton.UseVisualStyleBackColor = true;
            this.patRecButton.Click += new System.EventHandler(this.button33_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(63, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "ЗАПИСЬ НА ПРИЕМ";
            // 
            // regPanel
            // 
            this.regPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.regPanel.Controls.Add(this.regCardsButton);
            this.regPanel.Controls.Add(this.regRecordButton);
            this.regPanel.Location = new System.Drawing.Point(0, 56);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(222, 447);
            this.regPanel.TabIndex = 2;
            this.regPanel.Visible = false;
            // 
            // regCardsButton
            // 
            this.regCardsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.regCardsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regCardsButton.FlatAppearance.BorderSize = 0;
            this.regCardsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.regCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regCardsButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regCardsButton.Location = new System.Drawing.Point(24, 112);
            this.regCardsButton.Name = "regCardsButton";
            this.regCardsButton.Size = new System.Drawing.Size(174, 58);
            this.regCardsButton.TabIndex = 1;
            this.regCardsButton.Text = "Управление карточками";
            this.regCardsButton.UseVisualStyleBackColor = false;
            this.regCardsButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // regRecordButton
            // 
            this.regRecordButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.regRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regRecordButton.FlatAppearance.BorderSize = 0;
            this.regRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.regRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regRecordButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regRecordButton.Location = new System.Drawing.Point(24, 45);
            this.regRecordButton.Name = "regRecordButton";
            this.regRecordButton.Size = new System.Drawing.Size(174, 44);
            this.regRecordButton.TabIndex = 0;
            this.regRecordButton.Text = "Запись на прием";
            this.regRecordButton.UseVisualStyleBackColor = false;
            this.regRecordButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // visitPanel
            // 
            this.visitPanel.Controls.Add(this.lable8);
            this.visitPanel.Controls.Add(this.createReportButton);
            this.visitPanel.Controls.Add(this.listBoxPatientsVisit);
            this.visitPanel.Location = new System.Drawing.Point(228, 56);
            this.visitPanel.Name = "visitPanel";
            this.visitPanel.Size = new System.Drawing.Size(674, 443);
            this.visitPanel.TabIndex = 10;
            this.visitPanel.Visible = false;
            this.visitPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.visitPanel_Paint);
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.BackColor = System.Drawing.Color.DodgerBlue;
            this.lable8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lable8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lable8.Location = new System.Drawing.Point(63, 22);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(191, 26);
            this.lable8.TabIndex = 4;
            this.lable8.Text = "ПРИЕМ ПАЦИЕНТОВ";
            // 
            // createReportButton
            // 
            this.createReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createReportButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.createReportButton.FlatAppearance.BorderSize = 4;
            this.createReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.createReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReportButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createReportButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createReportButton.Location = new System.Drawing.Point(247, 370);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(182, 44);
            this.createReportButton.TabIndex = 2;
            this.createReportButton.Text = "Сформировать отчет";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.button34_Click);
            // 
            // listBoxPatientsVisit
            // 
            this.listBoxPatientsVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPatientsVisit.DisplayMember = "Name";
            this.listBoxPatientsVisit.FormattingEnabled = true;
            this.listBoxPatientsVisit.Location = new System.Drawing.Point(63, 51);
            this.listBoxPatientsVisit.Name = "listBoxPatientsVisit";
            this.listBoxPatientsVisit.Size = new System.Drawing.Size(547, 301);
            this.listBoxPatientsVisit.Sorted = true;
            this.listBoxPatientsVisit.TabIndex = 0;
            this.listBoxPatientsVisit.SelectedIndexChanged += new System.EventHandler(this.listBoxPatientsVisit_SelectedIndexChanged);
            this.listBoxPatientsVisit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox7_MouseDoubleClick);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.createItemButton);
            this.mainPanel.Controls.Add(this.labelAll);
            this.mainPanel.Controls.Add(this.deleteItemButton);
            this.mainPanel.Controls.Add(this.editItemButton);
            this.mainPanel.Controls.Add(this.listBoxAll);
            this.mainPanel.Location = new System.Drawing.Point(228, 56);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(674, 443);
            this.mainPanel.TabIndex = 10;
            this.mainPanel.Visible = false;
            // 
            // createItemButton
            // 
            this.createItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createItemButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.createItemButton.FlatAppearance.BorderSize = 4;
            this.createItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.createItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createItemButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createItemButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createItemButton.Location = new System.Drawing.Point(86, 373);
            this.createItemButton.Name = "createItemButton";
            this.createItemButton.Size = new System.Drawing.Size(111, 44);
            this.createItemButton.TabIndex = 1;
            this.createItemButton.Text = "Создать";
            this.createItemButton.UseVisualStyleBackColor = true;
            this.createItemButton.Click += new System.EventHandler(this.createCardButton_Click);
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAll.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAll.Location = new System.Drawing.Point(63, 22);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(220, 26);
            this.labelAll.TabIndex = 4;
            this.labelAll.Text = "КАРТОЧКИ ПАЦИЕНТОВ";
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteItemButton.Enabled = false;
            this.deleteItemButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.deleteItemButton.FlatAppearance.BorderSize = 4;
            this.deleteItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteItemButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.deleteItemButton.Location = new System.Drawing.Point(471, 373);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(111, 44);
            this.deleteItemButton.TabIndex = 3;
            this.deleteItemButton.Text = "Удалить";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editItemButton.Enabled = false;
            this.editItemButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.editItemButton.FlatAppearance.BorderSize = 4;
            this.editItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.editItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editItemButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.editItemButton.Location = new System.Drawing.Point(263, 373);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(143, 44);
            this.editItemButton.TabIndex = 2;
            this.editItemButton.Text = "Редактировать";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.editCardButton_Click);
            // 
            // listBoxAll
            // 
            this.listBoxAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAll.DisplayMember = "Id";
            this.listBoxAll.FormattingEnabled = true;
            this.listBoxAll.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listBoxAll.Location = new System.Drawing.Point(63, 51);
            this.listBoxAll.Name = "listBoxAll";
            this.listBoxAll.Size = new System.Drawing.Size(547, 301);
            this.listBoxAll.TabIndex = 0;
            this.listBoxAll.ValueMember = "Id";
            this.listBoxAll.SelectedIndexChanged += new System.EventHandler(this.listBoxPatientsCards_SelectedIndexChanged);
            // 
            // docPanel
            // 
            this.docPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.docPanel.Controls.Add(this.doctorVisitButton);
            this.docPanel.Controls.Add(this.doctorDrugButton);
            this.docPanel.Controls.Add(this.doctorDiagButton);
            this.docPanel.Location = new System.Drawing.Point(0, 56);
            this.docPanel.Name = "docPanel";
            this.docPanel.Size = new System.Drawing.Size(222, 444);
            this.docPanel.TabIndex = 1;
            this.docPanel.Visible = false;
            // 
            // doctorVisitButton
            // 
            this.doctorVisitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.doctorVisitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorVisitButton.FlatAppearance.BorderSize = 0;
            this.doctorVisitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.doctorVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorVisitButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorVisitButton.Location = new System.Drawing.Point(24, 177);
            this.doctorVisitButton.Name = "doctorVisitButton";
            this.doctorVisitButton.Size = new System.Drawing.Size(174, 44);
            this.doctorVisitButton.TabIndex = 2;
            this.doctorVisitButton.Text = "Прием пациентов";
            this.doctorVisitButton.UseVisualStyleBackColor = false;
            this.doctorVisitButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // doctorDrugButton
            // 
            this.doctorDrugButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.doctorDrugButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorDrugButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.doctorDrugButton.FlatAppearance.BorderSize = 0;
            this.doctorDrugButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.doctorDrugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorDrugButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorDrugButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doctorDrugButton.Location = new System.Drawing.Point(24, 45);
            this.doctorDrugButton.Name = "doctorDrugButton";
            this.doctorDrugButton.Size = new System.Drawing.Size(174, 44);
            this.doctorDrugButton.TabIndex = 0;
            this.doctorDrugButton.Text = "Лекарства";
            this.doctorDrugButton.UseVisualStyleBackColor = false;
            this.doctorDrugButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // doctorDiagButton
            // 
            this.doctorDiagButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.doctorDiagButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorDiagButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.doctorDiagButton.FlatAppearance.BorderSize = 0;
            this.doctorDiagButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.doctorDiagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorDiagButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorDiagButton.Location = new System.Drawing.Point(24, 112);
            this.doctorDiagButton.Name = "doctorDiagButton";
            this.doctorDiagButton.Size = new System.Drawing.Size(174, 44);
            this.doctorDiagButton.TabIndex = 1;
            this.doctorDiagButton.Text = "Диагнозы";
            this.doctorDiagButton.UseVisualStyleBackColor = false;
            this.doctorDiagButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.adminPanel.Controls.Add(this.adminDrugButton);
            this.adminPanel.Controls.Add(this.adminDiagButton);
            this.adminPanel.Controls.Add(this.adminAddressButton);
            this.adminPanel.Controls.Add(this.adminSpecButton);
            this.adminPanel.Controls.Add(this.adminDocButton);
            this.adminPanel.Controls.Add(this.adminCabinetButton);
            this.adminPanel.Location = new System.Drawing.Point(0, 56);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(222, 443);
            this.adminPanel.TabIndex = 3;
            this.adminPanel.Visible = false;
            // 
            // adminDrugButton
            // 
            this.adminDrugButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.adminDrugButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminDrugButton.FlatAppearance.BorderSize = 0;
            this.adminDrugButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.adminDrugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminDrugButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminDrugButton.Location = new System.Drawing.Point(24, 373);
            this.adminDrugButton.Name = "adminDrugButton";
            this.adminDrugButton.Size = new System.Drawing.Size(174, 44);
            this.adminDrugButton.TabIndex = 5;
            this.adminDrugButton.Text = "Лекарства";
            this.adminDrugButton.UseVisualStyleBackColor = false;
            this.adminDrugButton.Click += new System.EventHandler(this.button14_Click);
            // 
            // adminDiagButton
            // 
            this.adminDiagButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.adminDiagButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminDiagButton.FlatAppearance.BorderSize = 0;
            this.adminDiagButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.adminDiagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminDiagButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminDiagButton.Location = new System.Drawing.Point(24, 308);
            this.adminDiagButton.Name = "adminDiagButton";
            this.adminDiagButton.Size = new System.Drawing.Size(174, 44);
            this.adminDiagButton.TabIndex = 4;
            this.adminDiagButton.Text = "Диагнозы";
            this.adminDiagButton.UseVisualStyleBackColor = false;
            this.adminDiagButton.Click += new System.EventHandler(this.button13_Click);
            // 
            // adminAddressButton
            // 
            this.adminAddressButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.adminAddressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminAddressButton.FlatAppearance.BorderSize = 0;
            this.adminAddressButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.adminAddressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddressButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminAddressButton.Location = new System.Drawing.Point(24, 242);
            this.adminAddressButton.Name = "adminAddressButton";
            this.adminAddressButton.Size = new System.Drawing.Size(174, 44);
            this.adminAddressButton.TabIndex = 3;
            this.adminAddressButton.Text = "Участки";
            this.adminAddressButton.UseVisualStyleBackColor = false;
            this.adminAddressButton.Click += new System.EventHandler(this.button12_Click);
            // 
            // adminSpecButton
            // 
            this.adminSpecButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.adminSpecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminSpecButton.FlatAppearance.BorderSize = 0;
            this.adminSpecButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.adminSpecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminSpecButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminSpecButton.Location = new System.Drawing.Point(24, 177);
            this.adminSpecButton.Name = "adminSpecButton";
            this.adminSpecButton.Size = new System.Drawing.Size(174, 44);
            this.adminSpecButton.TabIndex = 2;
            this.adminSpecButton.Text = "Специализации";
            this.adminSpecButton.UseVisualStyleBackColor = false;
            this.adminSpecButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // adminDocButton
            // 
            this.adminDocButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.adminDocButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminDocButton.FlatAppearance.BorderSize = 0;
            this.adminDocButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.adminDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminDocButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminDocButton.Location = new System.Drawing.Point(24, 111);
            this.adminDocButton.Name = "adminDocButton";
            this.adminDocButton.Size = new System.Drawing.Size(174, 44);
            this.adminDocButton.TabIndex = 1;
            this.adminDocButton.Text = "Врачи";
            this.adminDocButton.UseVisualStyleBackColor = false;
            this.adminDocButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // adminCabinetButton
            // 
            this.adminCabinetButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.adminCabinetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminCabinetButton.FlatAppearance.BorderSize = 0;
            this.adminCabinetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.adminCabinetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminCabinetButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminCabinetButton.Location = new System.Drawing.Point(24, 45);
            this.adminCabinetButton.Name = "adminCabinetButton";
            this.adminCabinetButton.Size = new System.Drawing.Size(174, 44);
            this.adminCabinetButton.TabIndex = 0;
            this.adminCabinetButton.Text = "Кабинеты";
            this.adminCabinetButton.UseVisualStyleBackColor = false;
            this.adminCabinetButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // registratorButton
            // 
            this.registratorButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registratorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registratorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registratorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registratorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.registratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registratorButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registratorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registratorButton.Location = new System.Drawing.Point(448, 12);
            this.registratorButton.Name = "registratorButton";
            this.registratorButton.Size = new System.Drawing.Size(150, 50);
            this.registratorButton.TabIndex = 1;
            this.registratorButton.Text = "Регистратор";
            this.registratorButton.UseVisualStyleBackColor = false;
            this.registratorButton.Click += new System.EventHandler(this.button2_Click);
            this.registratorButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.registratorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // doctorButton
            // 
            this.doctorButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.doctorButton.FlatAppearance.BorderSize = 0;
            this.doctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.doctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.doctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorButton.Location = new System.Drawing.Point(595, 12);
            this.doctorButton.Name = "doctorButton";
            this.doctorButton.Size = new System.Drawing.Size(99, 50);
            this.doctorButton.TabIndex = 2;
            this.doctorButton.Text = "Врач";
            this.doctorButton.UseVisualStyleBackColor = false;
            this.doctorButton.Click += new System.EventHandler(this.button3_Click);
            this.doctorButton.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.doctorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // administratorButton
            // 
            this.administratorButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.administratorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.administratorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.administratorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.administratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administratorButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.administratorButton.Location = new System.Drawing.Point(282, 12);
            this.administratorButton.Name = "administratorButton";
            this.administratorButton.Size = new System.Drawing.Size(151, 50);
            this.administratorButton.TabIndex = 0;
            this.administratorButton.Text = "Администратор";
            this.administratorButton.UseVisualStyleBackColor = false;
            this.administratorButton.Click += new System.EventHandler(this.button1_Click);
            this.administratorButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.administratorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.administratorButton);
            this.panel1.Controls.Add(this.registratorButton);
            this.panel1.Controls.Add(this.doctorButton);
            this.panel1.Location = new System.Drawing.Point(204, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 73);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Presentation.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.InitialImage = global::Presentation.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(17, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(172, 45);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 61);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(2500, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(938, 10);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 585);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLINICO";
            this.Load += new System.EventHandler(this.Start_Load);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStripe)).EndInit();
            this.patientRecPanel.ResumeLayout(false);
            this.patientRecPanel.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.visitPanel.ResumeLayout(false);
            this.visitPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.docPanel.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button registratorButton;
        private System.Windows.Forms.Button administratorButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxStripe;
        private System.Windows.Forms.Button doctorVisitButton;
        private System.Windows.Forms.Button doctorDiagButton;
        private System.Windows.Forms.Button doctorDrugButton;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Button regCardsButton;
        private System.Windows.Forms.Button regRecordButton;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button adminDrugButton;
        private System.Windows.Forms.Button adminDiagButton;
        private System.Windows.Forms.Button adminAddressButton;
        private System.Windows.Forms.Button adminSpecButton;
        private System.Windows.Forms.Button adminDocButton;
        private System.Windows.Forms.Button adminCabinetButton;
        private System.Windows.Forms.Panel patientRecPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel visitPanel;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Button patRecButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button createItemButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeLb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDoct;
        public System.Windows.Forms.Button enterButton;
        public System.Windows.Forms.Button doctorButton;
        public System.Windows.Forms.Label labelDoctor;
        public System.Windows.Forms.ComboBox comboBoxNamePac;
        public System.Windows.Forms.ListBox listBoxPatientsVisit;
        public System.Windows.Forms.Panel docPanel;
        protected internal System.Windows.Forms.ComboBox comboBoxNameDoc;
        protected internal System.Windows.Forms.ComboBox comboBoxSpec;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ListBox listBoxAll;
        private System.Windows.Forms.ComboBox comboBoxTime;
    }
}

