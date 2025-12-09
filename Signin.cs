using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSDA
{
    public partial class Signin : Form
    {
        DBAccess DBAccess = new DBAccess();
        DataTable DBtable = new DataTable();

        public Signin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Boxmail.Text;
            string password = BoxPassword.Text;

            if (name == "")
            {
                MessageBox.Show("Empty text detected");
            }

            else if (password == "")
            {
                MessageBox.Show("Empty text detected");
            }

            else
            {
                string query = "select * from Users where Email = '" + name + "' and Password = '"+password+"'";

                DBAccess.readDatathroughAdapter(query, DBtable);

                if (DBtable.Rows.Count == 1)
                {
                    MessageBox.Show("Login has been succesful");
                    DBAccess.closeConn();
                    this.Hide();

                    Form2 homepage = new Form2();
                    homepage.Show();
                }

                else
                {
                    MessageBox.Show("Account not found");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 signup = new Form1();
            signup.Show();
        }
    }
}
