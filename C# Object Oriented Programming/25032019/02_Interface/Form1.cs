using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MathLab mathLab = new MathLab();
            int sayiBir = Convert.ToInt32(textBox1.Text);
            int sayiIki = int.Parse(textBox2.Text);

            MessageBox.Show(string.Format("Toplama = {0},Cıkarma = {1}, Carpma = {2}, Bolme = {3}", mathLab.Topla(sayiBir, sayiIki), mathLab.Cıkar(sayiBir, sayiIki), mathLab.Carp(sayiBir, sayiIki), mathLab.Bol(sayiBir, sayiIki)));
        }
    }
}
