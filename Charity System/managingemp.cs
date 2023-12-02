using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Charity_System
{
    public partial class managingemp : Form
    {
        string ordb = "Data source=orcl;user id=scott;Password=tiger;";
        OracleConnection conn;
        OracleDataReader dr;

        public managingemp()
        {
            InitializeComponent();
        }

       

        private void manageEMP_Click(object sender, EventArgs e)
        {
            this.Hide();
            emp em = new emp();
            em.ShowDialog();

        }

       

        private void poorfamily_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            famrepForm f = new famrepForm();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            manageFamilyForm f = new manageFamilyForm();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            
            conn = new OracleConnection(ordb);
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "SHOWDONATORS";
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.Add("donators", OracleDbType.RefCursor, ParameterDirection.Output);


            dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                dcomboBox.Items.Add(dr[0].ToString());
                
               
            }
            dr.Close();
            conn.Dispose();




        }

        private void managingemp_Load(object sender, EventArgs e)
        {
            
        }
    }
}
