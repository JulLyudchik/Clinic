using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntitiesComponent;
using DataProviderComponent;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    public partial class frmRegStation : Form
    {
        Context db;
        public frmRegStation()
        {
            InitializeComponent();
            db = new Context();
            db.regStations.Load();
            //comboBox1.DataSource = regStDB.regStations.ToList();
        }
        List<string> checkList =new List<string>();

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //сделать проверку на наличие улицы в другом участке
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
            //listBox1.DataSource = regStDB.regstations.Local.ToList();
            //checkList = regStDB.regstations.Local.ToList();
            //listBox1.DataSource = checkList;
            //listBox1.ValueMember = "Id";
            //listBox1.DisplayMember = "Name";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
    }
}
