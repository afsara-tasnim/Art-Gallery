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
    public partial class ReciveArt : Form
    {
        public static string name;
        RecieveArtService recieveArtService;
        UsersService usersService;
        DeliveryManPage delivery;
        AcceptedService accepted;
        public ReciveArt(DeliveryManPage Delivey)
        {
            InitializeComponent();
            this.recieveArtService = new RecieveArtService();
            this.usersService = new UsersService();
            this.delivery = Delivey;
            accepted = new AcceptedService();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            if ( address.Text == "" || password.Text == "" || sellername.Text == "")
            {
                MessageBox.Show("Field Required");
            }
            else
            {
                string pass = password.Text; 
                name = LogIn.namevalue;
                string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                int userId = usersService.GetId(name.ToString());
                int artId = DeliveryManPage.artid;
                sellername.Text = DeliveryManPage.sellerid;
                textBox1.Text = DeliveryManPage.buyeridforaccept;

                int buyerId = Convert.ToInt32(textBox1.Text);
                int id = Convert.ToInt32(sellername.Text);
                string passwod = usersService.GetPass(id);
                if(string.Equals(pass,passwod))
                {
                    int result = recieveArtService.AddArtwork(userId, artId,buyerId, theDate, address.Text);
                    if (result > 0)
                    {

                        MessageBox.Show("Art Reciving is successful");
                        this.Hide();
                        accepted.Remove(artId);
                        delivery.UpdateGrid();
                        delivery.UpdateGrid2();
                        delivery.Show();

                    }
                    else
                    {
                        MessageBox.Show("Error");

                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                    password.Text = address.Text = string.Empty;
                }
                
               
            }


        }

        private void ReciveArt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            sellername.Text = password.Text = address.Text = string.Empty;
            this.Hide();
            delivery.Show();
        }

        private void ReciveArt_Load(object sender, EventArgs e)
        {
            sellername.Text = DeliveryManPage.sellerid;
            textBox1.Text = DeliveryManPage.buyeridforaccept;
        }
    }
}
