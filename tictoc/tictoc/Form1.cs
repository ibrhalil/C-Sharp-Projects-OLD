using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void pcOyun()
        {
            Random r = new Random();
            int sayi = 0;
            Boolean b = false;
            if(tiklamasay<=4)
            {
                do
                {
                    sayi = r.Next(1, 9);
                    foreach (Control c in this.Controls)
                    {
                        if (c.Name == "button" + sayi)
                        {
                            if (c.Text != "X" && c.Text != "O")
                            {
                                c.Text = "O";
                                b = true;
                            }
                        }
                    }
                    if (b == true)
                    {
                        break;
                    }
                }
                while (true);
            }
            else
            {
                MessageBox.Show("Oyun Bitti");
            }
        }
        int tiklamasay = 0;
        public void tikladi(Button btn)
        {
            if (btn.Text!="X" && btn.Text!="O")
            {
                btn.Text = "X";
                tiklamasay++;
                pcOyun();
            }
            button10.Focus();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tikladi(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tikladi(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tikladi(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tikladi(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tikladi(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tikladi(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tikladi(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tikladi(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tikladi(button9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button10.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
