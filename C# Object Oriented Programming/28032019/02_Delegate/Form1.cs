using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int AritmatikHandler(int sayiBir, int sayiIki);

        public int ModAlma(int sayiBir, int sayiIki)
        {
            listBox1.Items.Add("Mod alma işlemini sonucu => " + (sayiBir % sayiIki));
            return sayiBir % sayiIki;
        }
        public int ToplamaIslemi(int sayiBir, int sayiIki)
        {
            listBox1.Items.Add("Toplama işleminin sonucu =>" + (sayiBir + sayiIki));
            return sayiBir + sayiIki;
        }

        public int CikarmaIslemi(int sayiBir, int sayiIki)
        {
            listBox1.Items.Add("Çıkarma işleminin sonucu =>" + (sayiBir - sayiIki));
            return sayiBir - sayiIki;
        }

        public int BolmeIslemi(int sayiBir, int sayiIki)
        {
            listBox1.Items.Add("Bolme işleminin sonucu =>" + (sayiBir / sayiIki));
            return sayiBir / sayiIki;
        }

        public int CarpmaIslemi(int sayiBir, int sayiIki)
        {
            listBox1.Items.Add("Carpma işleminin sonucu =>" + (sayiBir * sayiIki));
            return sayiBir * sayiIki;
        }

        public int KarekokAlma(int sayiBir, int sayiIki)
        {
            listBox1.Items.Add("Karekök alma işleminin sonucu =>" + (int)Math.Sqrt(sayiBir) + "-" + (int)Math.Sqrt(sayiIki));
            return (int)Math.Sqrt(sayiBir);
        }



       
        AritmatikHandler aHandler;
        private void Form1_Load(object sender, EventArgs e)
        {
            aHandler = new AritmatikHandler(ModAlma);
            aHandler += ToplamaIslemi;
            aHandler += CikarmaIslemi;
            aHandler += CarpmaIslemi;
            aHandler += BolmeIslemi;
            aHandler += KarekokAlma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);

            aHandler.Invoke(sayi1, sayi2);
            /*
            int result = aHandler.Invoke(sayi1, sayi2); //en son hangi methodu bağlaysan o yapının return'üne erişirsin
            MessageBox.Show(result.ToString());
            */
        }
    }
}
