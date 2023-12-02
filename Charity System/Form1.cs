using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charity_System
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin login = new Adminlogin();
            login.ShowDialog();
        }

       

        private void Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();

        }

        

        private void DonatorLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin login = new Adminlogin();
            login.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
