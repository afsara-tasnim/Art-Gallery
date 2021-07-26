using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Art_Gallery.Services;

namespace Art_Gallery.UI_Layer
{
    public partial class UploadWork : Form
    {
        public static string name;
       
        ArtworkService artservice;
        UsersService useService;
        UserHome userHome;
       
        public UploadWork(UserHome userHome)
        {
            InitializeComponent();
            artservice = new ArtworkService();
            useService = new UsersService();
            this.userHome = userHome;
            
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                imagepath.Text = picPath;
                pictureBox1.ImageLocation = picPath;

            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            

            string type = null;
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Field Required");
            }
            else
            {
                if (fineArt.Checked == true)
                {
                    type = "Fine Art";
                }
                else if (visual.Checked == true)
                {
                    type = "Visual Art";
                }
                else if (decorative.Checked == true)
                {
                    type = "Decorative Art";
                }
                else if(appliedart.Checked==true)
                {
                    type = "Applied Art";
                }
                string nameofuser = LogIn.namevalue;
                int idofuser = useService.GetId(nameofuser.ToString());
                byte[] imageByte = null;
                FileStream fstream = new FileStream(this.imagepath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageByte = br.ReadBytes((int)fstream.Length);
                string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                int price= Convert.ToInt32(textBox3.Text);
                string nameOfArt = textBox1.Text.ToString();
                int result = artservice.AddArtwork(nameOfArt, theDate,price, type, imageByte, idofuser);
                if (result > 0)
                {

                    MessageBox.Show("Uploading is successful");
                    userHome.UpdateGrideView();
                    
                   
                    this.Hide();
                    userHome.Show();
                   

                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
        }

        private void UploadWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            userHome.Show();
        }
    }
}