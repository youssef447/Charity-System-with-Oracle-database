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
    public partial class manageFamilyForm : Form
    {
        string ordb = "Data source=orcl;user id=scott;Password=tiger;";
        OracleDataAdapter adapter ;
        OracleCommandBuilder builder;
        DataSet d;
        OracleConnection conn;

        public manageFamilyForm()
        {
            InitializeComponent();
        }

        private void manageFamilyForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT id FROM poorfamily";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                comboBox1.Items.Add(dr[0].ToString());


            }
           
            dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmndstring = "SELECT * FROM poorfamily WHERE id =:idd";
            d = new DataSet();
            adapter = new OracleDataAdapter(cmndstring, ordb);
            adapter.SelectCommand.Parameters.Add("idd", comboBox1.Text);
           
            adapter.Fill(d);
            dataGridView1.DataSource = d.Tables[0];
        }


        private void save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(d.Tables[0]);
            MessageBox.Show("Operations Done successfully");
        }
    }
}
