using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] urunAd = new string[100];
        double[] urunFiyat = new double[100];
        byte urunSay = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double toplamFiyat = 0,indirimliToplam=0;
            listBox1.Items.Clear();
            urunAd[urunSay] = textBox1.Text;
            urunFiyat[urunSay] = int.Parse(textBox2.Text);
            for (int i = 0; i <= urunSay; i++)
            {
                listBox1.Items.Add(urunAd[i] +"  "+ urunFiyat[i]);
                toplamFiyat += urunFiyat[i];
            }
            listBox1.Items.Add("toplam fiyat =" + toplamFiyat);
            if (toplamFiyat < 200)
            {
                indirimliToplam = toplamFiyat - (toplamFiyat * 15 / 100);
                listBox1.Items.Add("%15 indirim kazandınız...");



            }
            else if (toplamFiyat >= 200 && toplamFiyat < 300)
            {
                indirimliToplam = toplamFiyat - (toplamFiyat * 20 / 100);
                listBox1.Items.Add("%20 indirim kazandınız...");
            }

            else if (toplamFiyat >= 300)
            {
                indirimliToplam = toplamFiyat - (toplamFiyat * 25 / 100);
                listBox1.Items.Add("%25 indirim kazandınız...");

            }
                listBox1.Items.Add("indirimli toplam =" + indirimliToplam);

            for (int i = 0; i <= urunSay; i++)
            {
                double ilkYuzde = urunFiyat[i] / toplamFiyat * 100;
                double indirimliUrunFiyat = indirimliToplam * ilkYuzde / 100;
                double fark = urunFiyat[i] - indirimliUrunFiyat;
                listBox1.Items.Add(urunAd[i] + " " + indirimliUrunFiyat + " %" + (fark / urunFiyat[i]) * 100);
            }
            urunSay++;
        }
    }
}
