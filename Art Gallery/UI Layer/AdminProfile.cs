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
    public partial class AdminProfile : Form
    {
        public string nam;
        PersonalInfo personal;
        UsersService usersService;
       
        LogIn log;
        PersonalInfo personalInfo;
        RecieveArtService recieve;
        public AdminProfile(LogIn logIn)
        {
            InitializeComponent();
            personal = new PersonalInfo(this);
           
            usersService = new UsersService();
            this.log = logIn;
            personalInfo = new PersonalInfo(this);
            recieve = new RecieveArtService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            personal.Show();

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

        private void edit_Click(object sender, EventArgs e)
        {
            string select = comboBox1.Text.ToString();

            string username = LogIn.namevalue;
            string email = "Email";
            string address = "Address";
            string phone = "Phone Number";
            if (select == phone)
            {

                string new_phone = textBox4.Text;

                int id = usersService.GetId(username);
                int result = usersService.UpdatePhoneNumber(new_phone, id);
                if (result > 0)
                {
                    MessageBox.Show("Profile updated");
                    lab2.Text = textBox4.Text;
                    textBox4.Text = string.Empty;




                }
                else
                {
                    MessageBox.Show("Error occured..");
                    textBox4.Text = string.Empty;

                }


            }
            else if (select == email)
            {

                string new_email = textBox4.Text;

                int id = usersService.GetId(username);
                if (!isValidEmail(new_email))
                {
                    MessageBox.Show("Invalid Email");
                }
                else
                {
                    int result = usersService.UpdateEmail(new_email, id);
                    if (result > 0)
                    {
                        MessageBox.Show("Profile updated");
                        lab3.Text = textBox4.Text;
                        textBox4.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("Error occured..");
                        textBox4.Text = string.Empty;

                    }


                }

            }
            else if (select == address)
            {
                string new_add = textBox4.Text;

                int id = usersService.GetId(username);
                int result = usersService.UpdateAddress(new_add, id);
                if (result > 0)
                {
                    MessageBox.Show("Profile updated");
                    lab4.Text = textBox4.Text;
                    textBox4.Text = string.Empty;





                }
                else
                {
                    MessageBox.Show("Error occured..");
                    textBox4.Text = string.Empty;

                }
            }
        }

        private void AdminProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            string name = LogIn.namevalue;
            int id = usersService.GetId(name);
            lab1.Text = LogIn.namevalue;
            lab3.Text = usersService.GetEmail(id);
            lab2.Text = usersService.GetPhone(id);
            lab4.Text = usersService.GetAddress(id);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = usersService.GetAllInfo();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[6 ].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = recieve.GetAll(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            log.Show();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            personalInfo.Show();
        }
    }
}
