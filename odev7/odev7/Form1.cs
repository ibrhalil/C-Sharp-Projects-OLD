using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace odev7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            basamakHesaplama(sayi);
            String okunus = Harflendirme(sayi);
            label3.Text = okunus.ToString();
        }
        static int[] Dsayi = new int[4];
        public static int basamakHesaplama(int sayi)
        {
            int say = 0;
            while (sayi >= 1)
            {
                Dsayi[say] = sayi % 10;
                sayi /= 10;
                say++;
            }
            return say;
        }
        public static void seslendirme(string sesyol)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = sesyol;
            player.controls.play();
            System.Threading.Thread.Sleep(1000);
        }
        public static String Harflendirme(int sayi)
        {
            String okunus = "";
            String[] birler = {
                "",
                "bir",
                "iki",
                "üç",
                "dört",
                "beş",
                "altı",
                "yedi",
                "sekiz",
                "dokuz",
                };
            String[] sesbirler = {
                "",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_1.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_2.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_3.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_4.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_5.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_6.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_7.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_8.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_9.mp3",
                };
            String[] onlar = {
                "",
                "on ",
                "yirmi ",
                "otuz ",
                "kırk ",
                "elli ",
                "altmış ",
                "yetmiş ",
                "seksen ",
                "doksan ",
        };
            String[] sesonlar = {
                "",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_10.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_20.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_30.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_40.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_50.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_60.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_70.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_80.mp3",
                "C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_90.mp3",
                };
            if (Dsayi[2] == 0)
            {

                if (Dsayi[3] == 0)
                {
                    okunus = onlar[Dsayi[1]] + birler[Dsayi[0]];
                    seslendirme(sesonlar[Dsayi[1]]);
                    seslendirme(sesbirler[Dsayi[0]]);
                }
                else
                {
                    okunus = birler[Dsayi[3]] + " bin " + onlar[Dsayi[1]] + birler[Dsayi[0]];
                    seslendirme("C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_1000.mp3");
                    seslendirme(sesonlar[Dsayi[1]]);
                    seslendirme(sesbirler[Dsayi[0]]);
                }
            }
            else
            {
                if (Dsayi[3] == 0)
                {
                    okunus = birler[Dsayi[3]] + birler[Dsayi[2]] + " yüz " + onlar[Dsayi[1]] + birler[Dsayi[0]];
                    seslendirme("C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_100.mp3");
                    seslendirme(sesonlar[Dsayi[1]]);
                    seslendirme(sesbirler[Dsayi[0]]);
                }
                else
                {
                    okunus = birler[Dsayi[3]] + " bin " + birler[Dsayi[2]] + " yüz " + onlar[Dsayi[1]] + birler[Dsayi[0]];
                    seslendirme("C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_1000.mp3");
                    seslendirme("C:\\Users\\My-PC\\source\\repos\\odev7\\odev7\\bin\\Debug\\sayiSes\\translate_100.mp3");
                    seslendirme(sesonlar[Dsayi[1]]);
                    seslendirme(sesbirler[Dsayi[0]]);
                }

            }
            return okunus;
            
        }

    }
}
