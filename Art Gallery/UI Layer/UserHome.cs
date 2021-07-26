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
    public partial class UserHome : Form
    {
       
        public string nam;
        int id;
        
        LogIn log;
        ArtworkService artworkService;
        UsersService usersService;
        RequestService requestService;
        PersonalInfo personalInfo;
        RecieveArtService recieveArtService;
        AcceptedService accepted;
        Home home;
       
    
        public UserHome(Home home)
        {
            InitializeComponent();
            log = new LogIn();
            accepted = new AcceptedService();
            artworkService = new ArtworkService();
            usersService = new UsersService();
            requestService = new RequestService();
            recieveArtService = new RecieveArtService();
            this.home = home;
            personalInfo = new PersonalInfo(this);
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            log.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nam = LogIn.namevalue;
            UploadWork upload = new UploadWork(this);
            this.Hide();
            upload.Show();

        }

        private void UserHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            nam = LogIn.namevalue;
            int sellerid = Home.creatorId;
            int id = usersService.GetId(nam);
            dataGridView1.DataSource = artworkService.GetAllArtById(id);
            dataGridView1.Columns[7].Visible = false;
           
            
            dataGridView2.DataSource = requestService.GetAllReq(sellerid);
            lab1.Text= LogIn.namevalue;
            lab3.Text = usersService.GetEmail(id);
            lab2.Text = usersService.GetPhone(id);
            lab4.Text = usersService.GetAddress(id);
            label14.Text = usersService.GetStatus(id);
        }
        public void UpdateGrideView()
        {
            nam = LogIn.namevalue;
            
            int id = usersService.GetId(nam);
            dataGridView1.DataSource = artworkService.GetAllArtById(id);
            dataGridView1.Columns[7].Visible = false;


            lab1.Text = LogIn.namevalue;
        }
        public void UpdateGridView2()
        {
            int id = Home.creatorId;
            dataGridView2.DataSource = requestService.GetAllReq(id);
        }

        private void deleteProfile_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res==DialogResult.Yes)
            {
                int id = usersService.GetId(nam);
                int artid=artworkService.GetArtId(id);
                int result = artworkService.RemoveArt(artid);
                if(result>0)
                {
                    usersService.Remove(id);
                    this.Hide();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
               
            }
            else
            {
                MessageBox.Show("Thank you for staying");
            }
           
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBox1.Text);
                string state = recieveArtService.GetStatus(id);
                string stat = "Pending";
                string stat2 = "Delivered";
                if(string.Equals(stat,state))
                {
                    MessageBox.Show("Can not be Deleted due to Delivey proccess");
                    textBox1.Text = string.Empty;
                }
                else if(string.Equals(stat2,state))
                {
                    MessageBox.Show("Can not be Deleted due to Delivey proccess");
                    textBox1.Text = string.Empty;
                }
                else
                {

                    artworkService.RemoveArt(id);
                    UpdateGrideView();
                    textBox1.Text = string.Empty;
                }
                

            }
            else
            {
                MessageBox.Show("Error Occured");
                textBox1.Text = string.Empty;
            }


        }


        private void back_Click(object sender, EventArgs e)
        {
            home.UpdateGridView();
            this.Hide();
            home.Show();

        }

        private void accept_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);
           
        }

        private void about_Click(object sender, EventArgs e)
        {
            this.Hide();
            personalInfo.Show();

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

        private void edit_Click_1(object sender, EventArgs e)
        {
            string select = comboBox1.Text.ToString();
            string username = LogIn.namevalue;
            
            string email = "Email";
            string address = "Address";
            string phone = "Phone Number";
            if (select == phone)
            {

                string new_name = textBox4.Text;

                int id = usersService.GetId(username);
                int result = usersService.UpdatePhoneNumber(new_name, id);
                if (result > 0)
                {
                    MessageBox.Show("Profile updated");
                    lab2.Text = textBox4.Text;
                    textBox4.Text = string.Empty;




                }
                else
                {
                    MessageBox.Show("Error occured..");

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

                    }


                }

            }
            else if (select == address)
            {
                string new_name = textBox4.Text;

                int id = usersService.GetId(username);
                int result = usersService.UpdateAddress(new_name, id);
                if (result > 0)
                {
                    MessageBox.Show("Profile updated");
                    lab4.Text = textBox4.Text;
                    textBox4.Text = string.Empty;





                }
                else
                {
                    MessageBox.Show("Error occured..");

                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void okay_Click(object sender, EventArgs e)
        {
            int artId =Convert.ToInt32( textBox3.Text);
            int buyer = Convert.ToInt32(textBox5.Text);
            int seller = Convert.ToInt32(textBox6.Text);
            int result = accepted.Add(artId, buyer, seller);
            if(result>0)
            {
                MessageBox.Show("Offar Accpeted");
                requestService.RemoveArt(artId);
                UpdateGridView2();
                textBox3.Text = textBox5.Text = textBox6.Text = string.Empty;


            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void changePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            personalInfo.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = LogIn.namevalue;
            int id = usersService.GetId(name);
            string type = "";
            if (radioButton1.Checked == true)
            {
                type = "Active";
            }
            else if (radioButton2.Checked == true)
            {
                type = "Deactive";
            }
            string active = "Active";
            string deactive = "Deactive";
            if(type==active)
            {
               
                int result = usersService.Updatestate(type,id);
                if (result > 0)
                {
                    MessageBox.Show("Account Activated");
                    label14.Text = type;
                }
                else { MessageBox.Show("Error"); }
            }
            else if(type==deactive)
            {
               
                int result = usersService.Updatestate(type,id);
                if (result > 0)
                {
                    MessageBox.Show("Account Deactivated");
                    label14.Text = type;
                }
                else { MessageBox.Show("Error"); }
            }
            
        }
    }
}