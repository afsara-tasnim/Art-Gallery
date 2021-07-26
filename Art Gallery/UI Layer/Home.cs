using Art_Gallery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art_Gallery.UI_Layer
{
    public partial class Home : Form
    {
        public static int creatorId;
        int id;
        LogIn login;
        ArtworkService artworkService;
        UsersService usersService;
        RequestService requestService;
        UserHome userHome;
       
        public Home(LogIn logIn)
        {
            InitializeComponent();
            this.login = logIn;
            this.artworkService = new ArtworkService();
            this.usersService = new UsersService();
            this.requestService = new RequestService();
            userHome = new UserHome(this);
           
        }

        private void profile_Click(object sender, EventArgs e)
        {
            string name = LogIn.namevalue;
           
            creatorId = usersService.GetId(name);

                
                UserHome homePage = new UserHome(this);
                userHome.UpdateGrideView();
                this.Hide();
                homePage.Show();
          
            

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
           
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string name = LogIn.namevalue;
            
           

           

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;
            
            dataGridView1.DataSource = artworkService.GetAllArt();
            dataGridView1.Columns[0].Visible = false;
            /* dataGridView1.Columns[4].Visible = false;*/


            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = usersService.GetAllInfoAdmin();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[6].Visible = false;



        }
        public void UpdateGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = artworkService.GetAllArt();
        }

        private void buy_Click(object sender, EventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string name = LogIn.namevalue;
            int artid = Convert.ToInt32(textBox1.Text);
            creatorId = Convert.ToInt32(textBox2.Text);
            string phone = usersService.GetPhone(creatorId);
            int id = usersService.GetId(name);
            string status = usersService.GetStatus(creatorId);
            string active = "Active";
            string deactive = "Deactive";
            if (status == active)
            {
                int result = requestService.AddRequest(artid, id, creatorId, phone);
                if (result > 0)
                {

                    MessageBox.Show("Successfully Notify the Artist");
                    userHome.UpdateGridView2();
                    textBox1.Text = textBox2.Text = string.Empty;




                }
                else
                {
                    MessageBox.Show("Error occured..");
                    textBox1.Text = textBox2.Text = string.Empty;

                }
            }
            else if(status==deactive)
            {
                MessageBox.Show("Sorry, Request Can't be Sent due to Users Inactivity");
                textBox1.Text = textBox2.Text = string.Empty;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

       
    }
}
