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
    public partial class Adminlogin : Form
    {
        string ordb = "Data source=orcl;user id=scott;Password=tiger;";
        OracleConnection conn;
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void Adminlogin_Load(object sender, EventArgs e)
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
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT USERNAME,PASSWORD FROM ADMIN WHERE USERNAME=:username AND PASSWORD=:password";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("username", D_username.Text);
                cmd.Parameters.Add("password", password.Text);

                //int r= cmd.ExecuteNonQuery();
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Logged in");

                    conn.Close();
                    this.Hide();
                   
                    dr.Close();


                    managingemp em = new managingemp();
                    em.ShowDialog();




                }
                else
                {
                    MessageBox.Show("invalid username or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
        }
    }
}
