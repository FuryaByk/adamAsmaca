using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> kelimeler = new List<string>() {"taha","yasemin","enes","furkan","eren","kemal","hasan","gönen","bandırma","ısparta" };
        string uretilenKelime = "";
        List<char> sonhal = new List<char>();
        int yanlisTahmin = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            KontrolEt(uretilenKelime, Convert.ToChar(tbHarf.Text));
        }
        public void KelimeUret()
        {
            Random rnd = new Random();
            int index = rnd.Next(kelimeler.Count);
            uretilenKelime = kelimeler[index];
            foreach (char item in uretilenKelime)
            {
                label1.Text += "*";
                sonhal.Add('*');              
                
            }
            
        }
        public void PasifYap() 
        {
            foreach (Control c  in this.Controls)
            {
                if (c is PictureBox)
                {
                    c.Visible = false;
                }
            }
        }
       
        public void KontrolEt(string k,char h)
        {
            
            if (uretilenKelime.Contains(tbHarf.Text))
            {
                //harf varsa yapılacaklar
                for (int i = 0; i < k.Length; i++)
                {
                    if (k[i]==h)
                    {
                        sonhal[i] = h;
                        
                    }
                    else
                    {
                        sonhal[i] = sonhal[i];
                       
                    }
                }
            }
            else
            {
                //harf yoksa yapılacaklar
                yanlisTahmin++;
               
                
            }
            label1.Text = string.Empty;
            foreach (char s in sonhal)
            {
                label1.Text += s;
            }
        }
       




        private void Form1_Load(object sender, EventArgs e)
        {
            KelimeUret();
            PasifYap();
            
        }
    }
}
