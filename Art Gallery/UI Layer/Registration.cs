using Art_Gallery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art_Gallery.UI_Layer
{
    public partial class Registration : Form
    {
        SignUpService signup;
        LogIn loginform;
        public Registration(LogIn logIn)
        {
            InitializeComponent();
            signup = new SignUpService();
            loginform = logIn;
        }
        private bool isValidEmail(String email)
        {
            bool flag = true;
            int atIndex = email.IndexOf("@");
            int dotIndex = email.IndexOf(".");
            if (dotIndex < atIndex)
            {
                flag = false;
            }
            return flag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (name.Text == "" || address.Text == "" || phoneNumber.Text == "" || password.Text == "" ||email.Text==""|| textBox1.Text=="")
            {
                MessageBox.Show("Field Required");
            }
            else
            {
                if (Artist.Checked == true)
                {
                    type = 1;
                }
                else { type = 2; }
                if (!isValidEmail(email.Text))
                {
                    MessageBox.Show("Invalid Email");
                }
                else
                {
                    string pass = password.Text;
                    string conpass = textBox1.Text;
                    if(pass==conpass)
                    {
                        int result = signup.UserRegistration(name.Text, password.Text, type, phoneNumber.Text, email.Text, address.Text);
                        if (result > 0)
                        {

                            MessageBox.Show("User registration successfull.");
                            this.Hide();
                            loginform.Show();

                        }
                        else
                        {
                            MessageBox.Show("Error");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Inccorrect Password");
                    }
                   
                }
               
            }

            
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform.Show();
        }
    }
} 