using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace Charity_System
{
    public partial class itemsrep : Form
    {
        CrystalReport1 cr;
        public itemsrep()
        {
            InitializeComponent();
        }

        private void itemsrep_Load(object sender, EventArgs e)
        {

            crystalReportViewer1.ReportSource = cr;
        

        }
    }
}
