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
    public partial class LogIn : Form
    {
        public static string namevalue;
        LoginService login;
        public LogIn()
        {
            InitializeComponent();
            login = new LoginService();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username or Password can not be empty");
            }
            else
            {


                int result = login.LoginValidation(textBox1.Text, textBox2.Text);
                if (result > 0)
                {
                    if (result == 1)
                    {
                        namevalue = textBox1.Text;
                        Home home = new Home(this);
                        this.Hide();
                        home.Show();
                        ClearText();
                    }
                    else if(result== 3)
                    {
                        namevalue = textBox1.Text;
                        AdminProfile admin = new AdminProfile(this);
                        this.Hide();
                        admin.Show();
                        ClearText();
                    }
                    else
                    {
                        namevalue = textBox1.Text;
                        DeliveryManPage deliveryman = new DeliveryManPage(this);
                        this.Hide();
                        deliveryman.Show();
                        ClearText();
                    }


                }
                else
                {
                    MessageBox.Show("Login Failed");
                    ClearText();

                }
            }
        }

        public void ClearText()
        {
            textBox1.Text = textBox2.Text = string.Empty;
        }
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration register = new Registration(this);
            this.Hide();
            register.Show();
        }
    }
}
