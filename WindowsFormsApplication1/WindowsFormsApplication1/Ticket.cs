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
using Word = Microsoft.Office.Interop.Word;

namespace Presentation
{
    public partial class frmTicket : Form
    {
        public Ticket ticket;
        public frmTicket()
        {
            InitializeComponent();         
        }

        private void frmTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
           /* frmStart main = this.Owner as frmStart;
            if (main != null)
            {
                labelPac.Text = main.comboBoxNamePac.SelectedItem.ToString();
                labelDocName.Text = main.comboBoxNameDoc.SelectedItem.ToString();
                labelDocSpec.Text = main.comboBoxSpec.SelectedItem.ToString();

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add();
            doc.Select();
            app.Selection.TypeParagraph();
            app.Selection.TypeText(" ТАЛОН ");
            app.Selection.TypeParagraph();
            app.Selection.TypeText("на прием к врачу : ");
            app.Selection.TypeParagraph();
            app.Selection.TypeText("Имя пациента : " + ticket.patCard.name);
            app.Selection.TypeParagraph();
            app.Selection.TypeText("Специализация : " + ticket.specialization.name);
            app.Selection.TypeParagraph();
            app.Selection.TypeText("ФИО врача : " + ticket.doctor.name);
            app.Selection.TypeParagraph();
            app.Selection.TypeText("Дата : " + ticket.date.ToString("dd.MM.yyyy"));
            app.Selection.TypeParagraph();
            app.Selection.TypeText("Кабинет : " + ticket.cabinet.number);
            app.Selection.TypeParagraph();
            app.Selection.TypeText("Время : " + ticket.time);
            app.Visible = true; 
        }
    }
}
