using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.emailTB.Text = "E-mail";
            this.passwordDB.Text = "Password";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            this.employeeTableAdapter1.Fill(this.wiNRG_dbDataSet1.Employee);
            string name= emailTB.Text;
            string password = passwordDB.Text;

            try
            {
                int id = (int)employeeTableAdapter1.getIdByUsername(name);
                if(this.employeeTableAdapter1.ReturnPassword(id).ToString() == password)
                {
                    this.Hide();
                    Form f = new Home();
                    f.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong password");
            }
            catch
            {
                MessageBox.Show("Log in failed, try again");
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTB_Enter(object sender, EventArgs e)
        {
            if(emailTB.Text == "E-mail")
            {
                emailTB.Text = "";
            }
        }

        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (emailTB.Text == "")
            {
                emailTB.Text = "E-mail";
            }
        }
        
        private void passwordDB_Enter(object sender, EventArgs e)
        {
            if(passwordDB.Text == "Password")
            {
                passwordDB.Text = "";
            }
        }

        private void passwordDB_Leave(object sender, EventArgs e)
        {
            if (passwordDB.Text == "")
                passwordDB.Text = "Password";
        }

    }
}
