using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Project_Design
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

        private void Login()
        {
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            int Pin = Int32.Parse(textBoxPin.Text);
            var userDataTest = userDataTableAdapter.CheckLoginData(Pin,Username,Password);
            if (userDataTest.Rows.Count > 0)
            {
                successLabel.Visible = true;
                DateTime start = DateTime.Now;
                while ((DateTime.Now - start).TotalMilliseconds < 1000)
                     Application.DoEvents();
                this.Visible = false;
                Form3 form3 = new Form3();
                form3.Visible = true;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //object username = userDataTableAdapter1.GetData()[0][0];
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMove1_Click(object sender, EventArgs e)
        {
            Login();
        }


        private void userDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
    }
}
