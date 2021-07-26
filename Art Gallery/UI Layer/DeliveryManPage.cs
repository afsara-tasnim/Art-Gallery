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
    public partial class DeliveryManPage : Form
    {
       
        public static string nameofdm;
        public static int artid;
        public static string deliverartid;
        public static string sellerid;
        public static string buyeridforaccept;
        public static string buyeridfrorecive;

        LogIn login;
        ReciveArt reciveArt;
        DeliverArt deliverArt;
        RecieveArtService recieveArtService;
        UsersService usersService;
        AcceptedService accepted;
        public DeliveryManPage(LogIn logIn)
        {
            InitializeComponent();
            this.login = logIn;
            this.reciveArt = new ReciveArt(this);
            this.deliverArt = new DeliverArt(this);
            this.recieveArtService = new RecieveArtService();
            usersService = new UsersService();
            accepted = new AcceptedService();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clear();
            login.Show();
        }

        private void recive_Click(object sender, EventArgs e)
        {
            sellerid = textBox3.Text;
            buyeridforaccept = textBox6.Text;
            artid = Convert.ToInt32(textBox2.Text);
            Clear();
            this.Hide();
            reciveArt.Show();
            
        }

        private void deliver_Click(object sender, EventArgs e)
        {
            deliverartid = textBox4.Text;
            buyeridfrorecive = textBox5.Text;
            Clear();
            this.Hide();
            deliverArt.Show();
            
        }

        private void DeliveryManPage_Load(object sender, EventArgs e)
        {
            textBox1.Text = LogIn.namevalue;
            dataGridView1.DataSource = recieveArtService.GetAll();
            dataGridView1.Columns[0].Visible = false;
            


           


            dataGridView2.DataSource = accepted.GetAllReq();
            dataGridView2.Columns[0].Visible = false;

           
            

        }
        public void Clear()
        {
            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text= string.Empty;
        }
        public void UpdateGrid()
        {

            dataGridView1.DataSource = recieveArtService.GetAll();
            dataGridView1.Columns[0].Visible = false;
        }
        public void UpdateGrid2()
        {
            dataGridView2.DataSource = accepted.GetAllReq();
            dataGridView2.Columns[0].Visible = false;
          
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();


            int sellerid = Convert.ToInt32(textBox3.Text);
            username.Text = usersService.GetName(sellerid);
            userphone.Text = usersService.GetPhone(sellerid);
            useraddess.Text = usersService.GetAddress(sellerid);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
    }
}
