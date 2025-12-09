using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSDA
{
    public partial class Form1 : Form
    {
        DBAccess ObjdBAccess = new DBAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ButSign_Click(object sender, EventArgs e)
        {

        }

        private void TextMail_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TextName.Text;
            string useremail = textBox1.Text;
            string userpassword = TextPassword.Text;

            if (username == "")
            {
                MessageBox.Show("Please enter an answer");
            }
            else if (useremail == "")
            {
                MessageBox.Show("Please enter an answer");
            }
            else if (userpassword == "")
            {
                MessageBox.Show("Please enter an answer");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(Name , Email , Password) values (@username , @useremail , @userpassword)");

                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@useremail", useremail);
                insertCommand.Parameters.AddWithValue("@userpassword", userpassword);

                int row = ObjdBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account created successfully");

                    this.Hide();

                    Form2 homepage = new Form2();
                    homepage.Show();
                }

                else
                {
                    MessageBox.Show("An error has been detected");
                }
            }
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signin sign = new Signin();
            this.Hide();
            sign.Show();
        }
    }
}
