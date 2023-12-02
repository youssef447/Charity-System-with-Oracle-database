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
    public partial class famrepForm : Form
    {
        familyrep rep;
        public famrepForm()
        {
            InitializeComponent();
        }

        private void famrepForm_Load(object sender, EventArgs e)
        {
            rep=new familyrep();
            foreach (ParameterDiscreteValue p in rep.ParameterFields[0].DefaultValues) {

                famid.Items.Add(p.Value);

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            rep.SetParameterValue(0, famid.Text);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
