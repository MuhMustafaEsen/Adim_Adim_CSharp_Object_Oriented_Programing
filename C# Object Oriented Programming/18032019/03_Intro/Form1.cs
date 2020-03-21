using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Insan i = new Insan(); //instance alma (yansıma alma)
            i.Ad = txtAd.Text;
            i.Soyad = txtSoyad.Text;
            i.TcKimlikNo = txtNo.Text;
            i.Cinsiyet = txtCinsiyet.Text;
            i.Yas = Convert.ToInt32(txtYas.Text);

            MessageBox.Show($"Ad : {i.Ad}\nSoyad : {i.Soyad}\nKimlikNo :{i.TcKimlikNo} \nCinsiyet :{i.Cinsiyet} \nYas :{i.Yas} ");

        }
    }
}
