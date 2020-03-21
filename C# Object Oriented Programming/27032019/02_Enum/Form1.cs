using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.AdiSoyadi = textBox1.Text;
            p.departmanlar = (Departmanlar)Enum.Parse(typeof(Departmanlar), comboBox1.Text);

            int seciliIndex =   (int)Enum.Parse(typeof(Departmanlar), comboBox1.Text);

            Departmanlar cikacak;
            bool sonuc = Enum.TryParse(comboBox1.Text, out cikacak);
            if (sonuc)
            {
                MessageBox.Show("personel departmanı : " + cikacak);
            }
            else
            {
                MessageBox.Show("Oyle bir departman yok");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
        }
    }
}
