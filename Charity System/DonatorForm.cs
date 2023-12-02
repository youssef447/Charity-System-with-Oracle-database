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
    public partial class DonatorForm : Form
    {
        string D_id;


        string ordb = "Data source=orcl;user id=scott;Password=tiger;";
        OracleConnection conn;
        string [] items = { "money","food","blanket","colthes"};
        public DonatorForm(string D)
        {
          
            InitializeComponent();
            D_id = D;
        }

        private void DonatorForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            list.Text = "select DONATION TYPE";
            for (int i = 0; i < items.Length; i++) {



                list.Items.Add(items[i]);
           
            
           

            }
            
        }

        private void donate_Click(object sender, EventArgs e)
        {
            if (list.Text == "select DONATION TYPE" || amount.Text == "")
            {

                MessageBox.Show("Please Enter all fields", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into ITEM values(:name,:d_id,:amount)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("name", list.Text);
                cmd.Parameters.Add("d_id", D_id);
                cmd.Parameters.Add("amount", int.Parse(amount.Text.Trim()));



                int res = cmd.ExecuteNonQuery();
                if (res != -1)
                {
                    MessageBox.Show("Submitted");
                    
                    conn.Dispose();

                }
                else
                {
                    MessageBox.Show("Database ERROR");
                }
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            if (list.Text == "select donation type" || amount.Text == "")
            {

                MessageBox.Show("no donation yet", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                this.Hide();
                this.Close();
                donationrepForm d = new donationrepForm(D_id);
                d.ShowDialog();

            }

        }
    }
}
