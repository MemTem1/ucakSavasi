using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPERNOVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd  = new Random();
        
        int yeniYer , yeniyer2, puan, can = 3;
        PictureBox pc1, pc2;

        private void dusmanUcak()
        {
            yeniYer = rnd.Next(0, 500);
            pc1 = new PictureBox();
            pc1.Width = 100;
            pc1.Height = 100;
            pc1.Location = new Point(yeniYer, -100);
            pc1.SizeMode = PictureBoxSizeMode.Zoom;
            pc1.Image = Properties.Resources.dusman_ucak_1;
            panelOyunSahasi.Controls.Add(pc1);
        }
        
        private void dusman2()
        {
            pc2 = new PictureBox();
            yeniyer2 = rnd.Next(0, 550);
            pc2.Width = 100;    
            pc2.Height = 100;
            pc2.Location = new Point(yeniyer2, -150);
            pc2.SizeMode = PictureBoxSizeMode.Zoom;
            pc2.Image = Properties.Resources.dusman_ucak_2;
            panelOyunSahasi.Controls.Add(pc2);
        }
        PictureBox bullet;
        private void bulletMethod()
        {
            
            bullet = new PictureBox();
            bullet.Size = new Size(50, 50);
            bullet.Location = new Point(pictureBox1.Left +20 , pictureBox1.Top);
            bullet.SizeMode = PictureBoxSizeMode.Zoom;
            bullet.Image = Properties.Resources.bullet;
            panelOyunSahasi.Controls.Add(bullet);
            

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(pictureBox1.Left >= 0)
                {
                    pictureBox1.Left -= 5;
                }
                
            }
            if(e.KeyCode == Keys.Right)
            {
                if(pictureBox1.Left <= 645)
                {
                    pictureBox1.Left += 5;
                }
                
            }
            if(e.KeyCode == Keys.Up)
            {
                if(pictureBox1.Top >= 100)
                {
                    pictureBox1.Top -= 5;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if( pictureBox1.Top <=300)
                {
                    pictureBox1.Top += 5;
                }
            }
            if(e.KeyCode == Keys.Space)
            {
                bulletMethod();
                timerBullet.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelAd.Text = Form2.isim;
            dusman2();
            dusmanUcak();
            timerDusman.Start();
        }

        private void gameOver()
        {
            
            panelOyunSahasi.Controls.Remove(pc1);
            panelOyunSahasi.Controls.Remove(pc2);
            timerDusman.Stop();
           DialogResult oyunBaslasınMİ =  MessageBox.Show("Yeniden Başlasın Mı ?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(oyunBaslasınMİ == DialogResult.Yes)
            {
                timerDusman.Start();
                
                puan = 0;
                can = 3;
            }
            else if(oyunBaslasınMİ == DialogResult.No)
            {
                Application.Exit();
            }
        }


        private void timerDusman_Tick(object sender, EventArgs e)
        {
            if(can == -1)
            {
                gameOver();
            }
            labelPuan.Text = puan.ToString();
            labelCan.Text = can.ToString();
            pc1.Top += 3;
            pc2.Top += 3;
            if(pc2.Top >= 450)
            {
                panelOyunSahasi.Controls.Remove(pc2);
                dusman2();
            }
            if (pc2.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                can -= 1;
                panelOyunSahasi.Controls.Remove(pc2);
                dusman2();
                
            }
            if (pc1.Top >= 450)
            {
                panelOyunSahasi.Controls.Remove(pc1);
                dusmanUcak();
            }
            if (pictureBox1.Bounds.IntersectsWith(pc1.Bounds))
            {
                panelOyunSahasi.Controls.Remove(pc1);
                dusmanUcak();
                can -= 1;
            }   
        }
        private void timerBullet_Tick(object sender, EventArgs e)
        {
            bullet.Top -= 20;
            if (bullet.Bounds.IntersectsWith(pc1.Bounds))
            {
                panelOyunSahasi.Controls.Remove(pc1);
                panelOyunSahasi.Controls.Remove(bullet);
                dusmanUcak();
                puan += 10;
            }
            if (bullet.Bounds.IntersectsWith(pc2.Bounds))
            {
                panelOyunSahasi.Controls.Remove(pc2);
                panelOyunSahasi.Controls.Remove(bullet);
                dusman2();
                puan += 10;
            }
            if (bullet.Top == -100)
            {
                panelOyunSahasi.Controls.Remove(bullet);
            }
        }
    }
}
