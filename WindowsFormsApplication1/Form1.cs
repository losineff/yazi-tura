using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            Random random = new Random();
            int sayi = random.Next(2);
            if (sayi == 1)
            {
                label1.Text = ("Yazı");
                pictureBox1.Image = Image.FromFile("resim1.jpeg");
            }
            else
            {
                label1.Text = ("Tura");
                pictureBox1.Image = Image.FromFile("tura.jpeg");
            }
            
        }
    }
}
