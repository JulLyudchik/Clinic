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
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {

        }

        private void frmCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
