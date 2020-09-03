using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar) == 32)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar) == 32)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                label3.Text = "1";
                label4.Text = "1";
                long xy = 0;
                for (int i = 1; i <= int.Parse(textBox2.Text); i++)
                {
                    label3.Text += " +";
                    label4.Text += " + ";
                    for (int j = 0; j < i; j++)
                    {
                        label3.Text += " x";
                        if (j > 0)
                        {
                            label4.Text += "." + textBox1.Text;

                        }
                        else
                        {
                            label4.Text += textBox1.Text;
                        }
                    }
                    xy += Convert.ToInt64(Math.Pow(long.Parse(textBox1.Text), i));
                }
                label4.Text += " = " + (1 + xy);
            }
            else
            {
                MessageBox.Show("Değer Giriniz...");
            }

            
        }
    }
}
