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
    public partial class DeliverArt : Form
    {
        DeliveryManPage delivery;
        RecieveArtService recieveArt;
        ArtworkService artwork;
        UsersService usersService;
        AcceptedService accepted;
        public DeliverArt(DeliveryManPage Delivary)
        {
            InitializeComponent();
            this.delivery = Delivary;
            recieveArt = new RecieveArtService();
            artwork = new ArtworkService();
            usersService = new UsersService();
            accepted = new AcceptedService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buyername.Text == "" || password.Text == "" || artname.Text == "")
            {
                MessageBox.Show("Field Required");
            }
            else
            {
                int buyerid = Convert.ToInt32(buyername.Text);
                int artid = Convert.ToInt32(artname.Text);
                string artState = "Yes";
                string deliveryState = "Delivered";
                string pass = usersService.GetPass(buyerid);
                string pas = password.Text;
                if (string.Equals(pas, pass))
                {
                    int result = artwork.UploadArtwork(artid, artState);
                    if (result > 0)
                    {
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    int res = recieveArt.Upload(artid, deliveryState);
                    if (res > 0)
                    {
                        MessageBox.Show("Deliverd");
                       
                        this.Hide();
                        delivery.UpdateGrid();
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
                    password.Text = string.Empty;
                    
                }
            }
        }

        private void DeliverArt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        

        private void back_Click(object sender, EventArgs e)
        {
            
            this.Hide();   
            delivery.Show();
            buyername.Text = artname.Text = password.Text = string.Empty;

        }

        private void DeliverArt_Load(object sender, EventArgs e)
        {
            artname.Text = DeliveryManPage.deliverartid;
            buyername.Text = DeliveryManPage.buyeridfrorecive;
        }
    }
}
