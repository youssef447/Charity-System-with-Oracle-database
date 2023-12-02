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
    public partial class emp : Form
    {
        string ordb = "Data source=orcl;user id=scott;Password=tiger;";
        OracleConnection conn;

        public emp()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emp_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT SSN FROM STAFF";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {

                ssn.Items.Add(dr[0].ToString());


            }
             ssn.Text = "select emp SSN";
            dr.Close();

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (ssn.Text == "" || empname.Text == "" || empsal.Text == "" || empage.Text == "")
            {

                MessageBox.Show("Please Enter all fields", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into STAFF values(:NAME,:SALARY,:SSN,:AGE)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("NAME", empname.Text);
                cmd.Parameters.Add("SALARY", empsal.Text);
                cmd.Parameters.Add("SSN", ssn.Text);
                cmd.Parameters.Add("AGE", empage.Text);
                try
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res != -1)
                    {
                        MessageBox.Show("emp inserted Successfully");
                        this.Hide();
                        Form1 reg = new Form1();
                        reg.ShowDialog();
                        conn.Dispose();

                    }
                }
                catch {

                    MessageBox.Show("ssn must be unique");
                }

              
               
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (ssn.Text == "" || empname.Text == "" || empsal.Text == "" || empage.Text == "")
            {

                MessageBox.Show("Please Enter all fields", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM  STAFF WHERE ENAME=:ename and SALARY=:salary and  AGE=:age and SSN=:ssn";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("ename", empname.Text);
                cmd.Parameters.Add("salary", empsal.Text);
                cmd.Parameters.Add("age", empage.Text);
                cmd.Parameters.Add("ssn", ssn.Text);
                int r = cmd.ExecuteNonQuery();
                if (r == 0) {
                    MessageBox.Show("Emp not found");
                }
              
                else
                {
                    MessageBox.Show("EMP is Deleted ");

                }

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (ssn.Text == "" || empname.Text == "" || empsal.Text == "" || empage.Text == "")
            {

                MessageBox.Show("Please Enter all fields", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE STAFF set ENAME=:ename , SALARY=:salary,  AGE=:age  WHERE SSN=:ssn";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("ename", empname.Text);
                cmd.Parameters.Add("salary", empsal.Text);
                cmd.Parameters.Add("age", empage.Text);
                cmd.Parameters.Add("ssn", ssn.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("EMP is updated successfully");
                }
                else {
                    MessageBox.Show("Database error");
                }


            }

        }

        private void ssn_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ENAME,SALARY,AGE FROM STAFF WHERE SSN=:ssn";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", ssn.Text);
          

            //int r= cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                empname.Text = dr[0].ToString();
                empsal.Text = dr[1].ToString();
                empage.Text = dr[2].ToString();
                dr.Close();
            }



        }
    }

}
