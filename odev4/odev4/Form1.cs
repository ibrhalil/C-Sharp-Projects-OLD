using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] asalSayilar = new int[95];
        int say2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            yol2();
            yol1();
            listBox1.Items.Add("toplam :"+listBox1.Items.Count);
            listBox2.Items.Add("toplam :"+listBox2.Items.Count);
            listBox1.Sorted = true;
        }
        public void yol1()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (asalimsimi(i))
                {
                    listBox1.Items.Add( i );
                   
                }
            }
        }
        
        public void yol2()
        {
            //Yol2---------------------------------------------------

            for (int i = 2; i < 500; i++)
            {
                if (asalMi(i))
                {

                    asalSayilar[say2] = i;
                    say2++;
                }

            }
            for (int i = 0; i < asalSayilar.Length; i++)
            {
                for (int j = i; j < asalSayilar.Length; j++)
                {
                    if (asalSayilar[i] * asalSayilar[j] <= 1000)
                    {
                        listBox2.Items.Add(asalSayilar[i] * asalSayilar[j] + " = " + asalSayilar[i] + " * " + asalSayilar[j]);
                        //listBox2.Items.Add(asalSayilar[i]*asalSayilar[j]);
                    }

                }
            }
            listBox2.Sorted = true;
            //Yol2-----------------------------------------------------
        }
        public Boolean asalMi(int sayi)
        {
            for (int j = 2; j < sayi; j++)
            {
                if (sayi % j == 0)
                {
                    return false;
                }
            }
            
            return true;
        }
        public Boolean asalimsimi(int sayi)
        {
            int bolenSay=0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0 )
                {
                    bolenSay++;
                    if(!asalMi(i))
                    {
                        return false;
                    }
                   //listBox1.Items.Add(sayi + " tam bölen" + i);
                }
            }
            if (bolenSay<1||bolenSay>2)
            {
                return false;
            }
            return true;

        }

       
        


    }
}
