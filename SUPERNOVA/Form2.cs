using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPERNOVA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string isim = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Kolay");
            comboBox1.Items.Add("Orta");
            comboBox1.Items.Add("Zor");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen isim ve zorluk derecelerini doldurunuz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
            else
            {
                
                isim = textBox1.Text; 
                Form1 fr1 = new Form1();
                fr1.ShowDialog();
                fr1.Close();
            }
            
            
        }
    }
}
