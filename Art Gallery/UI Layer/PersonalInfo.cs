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
    public partial class PersonalInfo : Form
    {
        UsersService usersService;
        
        LogIn log;
        UserHome userHome;
        AdminProfile admin;
        public PersonalInfo(UserHome userHome)
        {
            InitializeComponent();
          
            usersService = new UsersService();
            log = new LogIn();
            this.userHome =userHome ;
            

        }
        public PersonalInfo(AdminProfile admin)
        {
            InitializeComponent();
           
            usersService = new UsersService();
            log = new LogIn();
            this.admin = admin;


        }


        private void PersonalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = LogIn.namevalue;
            string old_pass = textBox1.Text.ToString();
            string new_pass = textBox2.Text.ToString();

            int id = usersService.GetId(name);
            string currentPass = usersService.GetPass(id);
            if (string.Equals(old_pass,currentPass))
            {
                int result = usersService.UpdatePassword(new_pass, id);
                if (result > 0)
                {
                    MessageBox.Show("Profile updated");
                    textBox1.Text = textBox2.Text = string.Empty;
                    
                    this.Hide();
                    log.Show();




                }
                else
                {
                    MessageBox.Show("Error occured..");
                    textBox1.Text = textBox2.Text = string.Empty;

                }
            }
            else
            {
                MessageBox.Show("Incorrect Password");
                textBox1.Text = textBox2.Text = string.Empty;
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            string name = LogIn.namevalue;
            int id = usersService.GetId(name);
            int type = usersService.Gettype(id);
            if(type==1)
            {
                userHome.Show();
            }
            else
            {
                admin.Show();
            }
        }
    }
}
