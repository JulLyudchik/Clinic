namespace Presentation
{
    partial class frmDoctorReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSpecDoc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxNameDoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSpecDoc
            // 
            this.comboBoxSpecDoc.DisplayMember = "Name";
            this.comboBoxSpecDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecDoc.FormattingEnabled = true;
            this.comboBoxSpecDoc.Items.AddRange(new object[] {
            "Хирург",
            "Офтальмолог",
            "Стоматолог",
            "Терапевт"});
            this.comboBoxSpecDoc.Location = new System.Drawing.Point(32, 20);
            this.comboBoxSpecDoc.Name = "comboBoxSpecDoc";
            this.comboBoxSpecDoc.Size = new System.Drawing.Size(246, 21);
            this.comboBoxSpecDoc.TabIndex = 0;
            this.comboBoxSpecDoc.ValueMember = "Id";
            this.comboBoxSpecDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecDoc_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(99, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxNameDoc
            // 
            this.comboBoxNameDoc.DisplayMember = "Name";
            this.comboBoxNameDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNameDoc.Enabled = false;
            this.comboBoxNameDoc.FormattingEnabled = true;
            this.comboBoxNameDoc.Items.AddRange(new object[] {
            "Иванов Иван Иванович",
            "Петров Петр Петрович",
            "Сидоров Сидор Сидорович"});
            this.comboBoxNameDoc.Location = new System.Drawing.Point(32, 55);
            this.comboBoxNameDoc.Name = "comboBoxNameDoc";
            this.comboBoxNameDoc.Size = new System.Drawing.Size(246, 21);
            this.comboBoxNameDoc.TabIndex = 11;
            this.comboBoxNameDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameDoc_SelectedIndexChanged);
            // 
            // frmDoctorReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(314, 136);
            this.Controls.Add(this.comboBoxNameDoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSpecDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoctorReg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Войти как врач";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoctorReg_FormClosing);
            this.Load += new System.EventHandler(this.frmDoctorReg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSpecDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxNameDoc;
    }
}