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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        /*private void CreateDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCreateDoc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet2.RegStations". При необходимости она может быть перемещена или удалена.
            this.regStationsTableAdapter.Fill(this.clinicDataSet2.RegStations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet1.Cabinets". При необходимости она может быть перемещена или удалена.
            this.cabinetsTableAdapter.Fill(this.clinicDataSet1.Cabinets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Specializations". При необходимости она может быть перемещена или удалена.
            this.specializationsTableAdapter.Fill(this.clinicDataSet.Specializations);

        }
    }
}
