using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void lblYap(int sayi)
        {
            int x = 25;
            int y = 150;
            
            for (int i = 0; i <= sayi; i++)
            {
                y += 25;
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(x, y);
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lbl.Name = "label" + i;
                lbl.Text = "(x + y) ^ " + i + " == " + paskal(i);
                lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                lbl.Size = new System.Drawing.Size(1200, 20);
                this.Controls.Add(lbl);
            }
            label4.Text = sondeger;
            formul(sayi);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        string sondeger = "";
        public String paskal(int sayi)
        {
            sondeger = "";
            string deger="";
            int dx = sayi, dy = 0;
            int c = 1;   
            for (int x = 0; x <= sayi; x++)
            {
               // if(c!=1||sayi<=1)
                {
                    deger += " + " + c;
                }
                
                if (dx>0)
                {
                    deger += " x";
                    //deger += " "+textBox1.Text;
                    if (dx!=1)
                    {
                        deger += "^" + dx;
                    }
                }
                if (dy>0)
                {
                    deger += " y";
                    //deger += " " + textBox2.Text;
                    if (dy!=1)
                    {
                        deger +="^" + dy;
                    }
                }
                c = c * (sayi - x) / (x + 1);
                dx--;
                dy++;
                
            }
            sondeger = deger;
            return deger ;
        }

        public int fatoriyel(int sayi)
        {
            int top = 1;
            for (int i = 1; i <= sayi; i++)
            {
                top *= i;
            }
            return top;
        }
        public void formul(int sayi)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int n = int.Parse(textBox3.Text);
            double islem = 0;
            for (int i = 0; i <= sayi; i++)
            {
                islem+= (fatoriyel(n) / (fatoriyel(i) * fatoriyel(n - i))) * Math.Pow(x, i) * Math.Pow(y, (n - i));
                label1.Text = islem.ToString();
                //MessageBox.Show(label1.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) > 11 || int.Parse(textBox2.Text) > 11 || int.Parse(textBox3.Text) > 11)
                {
                    MessageBox.Show("Değerleriniz çok yüksek....");
                }
                else
                {
                    lblYap(int.Parse(textBox3.Text));
                    //MessageBox.Show("Sağlaması : "+Math.Pow((int.Parse(textBox1.Text)+int.Parse(textBox2.Text)),int.Parse(textBox3.Text)).ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hata var "+e.ToString());
                
            }
            
            
        }
    }
}
