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
    public partial class RegistrationForm : Form
    {
        string ordb = "Data source=orcl;user id=scott;Password=tiger;";
        OracleConnection conn;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (D_username.Text == "" || password.Text == "" || address.Text == ""||phone.Text=="")
            {

                MessageBox.Show("Please Enter all fields", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into volunteer values(:phone,:username,:address,:password)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("phone", phone.Text);
                cmd.Parameters.Add("username", D_username.Text);
                cmd.Parameters.Add("address", address.Text);

                cmd.Parameters.Add("password", password.Text);
                int res = cmd.ExecuteNonQuery();
                if (res != -1)
                {
                    MessageBox.Show("You are Registered Successfully");
                    this.Hide();
                    Form1 reg = new Form1();
                    reg.ShowDialog();
                    conn.Dispose();

                }
                else
                {
                    MessageBox.Show("Database ERROR");
                }
            }
        }

        private void D_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}