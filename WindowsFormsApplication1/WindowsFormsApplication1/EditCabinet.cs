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
    public partial class frmEditCab : Form
    {
        public frmEditCab()
        {
            InitializeComponent();
        }

        /*private void frmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }*/

        private void frmEditCab_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Specializations". При необходимости она может быть перемещена или удалена.
            this.specializationsTableAdapter.Fill(this.clinicDataSet.Specializations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
