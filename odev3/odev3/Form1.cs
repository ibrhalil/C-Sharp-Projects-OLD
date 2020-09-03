using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int youWin = 0;
        int PcWin = 0;

        public void oyun()
        {
            rast = r.Next(3);
            pictureBox1.Image = ımageList1.Images[rast];
            pictureBox1.Visible = false;
            senRes.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        int rast = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            oyun();
        }

        private void button1_Click(object sender, EventArgs e)//tas
        {
            senRes.Image = ımageList1.Images[0];
            if (rast == 0)
            {
                kazanan(0);
            }
            else if(rast == 1)
            {
                kazanan(false);
            }
            else if (rast == 2)
            {
                kazanan(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)//kagit
        {
            senRes.Image = ımageList1.Images[1];
            if (rast == 0)
            {
                kazanan(true);
            }
            else if (rast == 1)
            {
                kazanan(0);
            }
            else if (rast == 2)
            {
                kazanan(false);
            }
        }

        private void button3_Click(object sender, EventArgs e)//makas
        {
            senRes.Image = ımageList1.Images[2];
            if (rast == 0)
            {
                kazanan(false);
            }
            else if (rast == 1)
            {
                kazanan(true);
            }
            else if (rast == 2)
            {
                kazanan(0);
            }
        }

        public void kazanan(int deger)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            pictureBox1.Visible = true;
            senRes.Visible = true;
            MessageBox.Show("Berabere");
        }
        public void kazanan(Boolean deger)
        {
            pictureBox1.Visible = true;
            senRes.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            if (deger)
            {
                youWin += 1;
                textBox1.Text = youWin.ToString();
                MessageBox.Show("Kazandın");
            }
            else
            {
                PcWin += 1;
                textBox2.Text = PcWin.ToString();
                MessageBox.Show("Kaybettin");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            oyun();
        }
    }

    
}
