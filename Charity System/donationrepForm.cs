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
    public partial class donationrepForm : Form
    {
        Drep d;
        string D_ID;
        public donationrepForm(string d_id)
        {
            D_ID = d_id;
            InitializeComponent();
        }

        private void donationrepForm_Load(object sender, EventArgs e)
        {
            d = new Drep();
            
            d.SetParameterValue(0, D_ID);
            crystalReportViewer1.ReportSource = d;

        }
    }
}
