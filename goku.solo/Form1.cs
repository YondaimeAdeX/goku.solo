using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goku.solo
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Ogrenci og = new Ogrenci(); 
            og.adiSoyadi = textBox1.Text;
            og.tcNO = textBox2.Text;
            og.cinsiyeti = textBox3.Text;
            og.dogumTarihi = textBox4.Text;
            og.sinif = textBox5.Text;
            og.numarasi = textBox6.Text;
            
            listBox1.Items.Add(og.adiSoyadi + " " + og.tcNO + " " + og.cinsiyeti + " " + og.dogumTarihi + " " + og.sinif + " " + og.numarasi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogretmen ogr = new Ogretmen();
            ogr.adiSoyadi = textBox7.Text;
            ogr.tcNO = textBox8.Text;
            ogr.cinsiyeti = textBox9.Text;
            ogr.dogumTarihi = textBox10.Text;
            ogr.bransi = textBox11.Text;
            ogr.maasi = float.Parse( textBox12.Text);
            listBox2.Items.Add(ogr.adiSoyadi + " " + ogr.tcNO + " " + ogr.cinsiyeti + " " + ogr.dogumTarihi + ogr.bransi + " " + ogr.maasi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            İdareci idare = new İdareci();
            idare.adiSoyadi = textBox13.Text;
            idare.tcNO = textBox14.Text;
            idare.cinsiyeti = textBox15.Text;
            idare.dogumTarihi = textBox16.Text;
            idare.bransi = textBox17.Text;
            idare.maasi = float.Parse(textBox18.Text);
            idare.gorevi = textBox19.Text;
            listBox3.Items.Add(idare.adiSoyadi + " " + idare.tcNO + " " + idare.cinsiyeti + " " + idare.dogumTarihi + idare.bransi + " " + idare.maasi +" "+ idare.gorevi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hizmetli hizm = new Hizmetli();
            hizm.adiSoyadi = textBox20.Text;
            hizm.tcNO = textBox21.Text;
            hizm.cinsiyeti = textBox22.Text;
            hizm.dogumTarihi = textBox23.Text;
            hizm.maasi = float.Parse(textBox24.Text);
            hizm.gorevyeri = textBox25.Text;
            listBox4.Items.Add(hizm.adiSoyadi + " " + hizm.tcNO + " " + hizm.cinsiyeti + " " + hizm.dogumTarihi + " " + hizm.maasi + " " +hizm.gorevyeri);
        }
    }
}
