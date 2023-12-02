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

    public partial class LoginForm : Form

    {
        static public string D_id = "";

        string ordb = "Data source=orcl;user id=scott;Password=tiger;";
        OracleConnection conn;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }

        private void login_Click(object sender, EventArgs e)
        {

            if (D_username.Text == "" || password.Text == "")
            {

                MessageBox.Show("Please Enter all fields", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OracleDataReader dr;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "LOGIN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", D_username.Text);
                cmd.Parameters.Add("password", password.Text);
                cmd.Parameters.Add("phone", OracleDbType.Int32, ParameterDirection.Output);

                try
                {
                    int r = cmd.ExecuteNonQuery();
                    D_id = D_username.Text;
                    this.Hide();
                    this.Close();
                    this.Hide();
                    this.Close();
                    DonatorForm d = new DonatorForm(D_id);
                    d.ShowDialog();
                }

                catch
                {
                    MessageBox.Show("invalid username or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
             
               

            }
        }

    }
}

