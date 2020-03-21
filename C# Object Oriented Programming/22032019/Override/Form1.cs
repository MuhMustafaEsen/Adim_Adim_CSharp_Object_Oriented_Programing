using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Override
{
    public partial class Form1 : Form
    {
        List<Student> ogrenciler;
        public Form1()
        {
            InitializeComponent();
            ogrenciler = new List<Student>();
        }
        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student ogr = OgrenciOlustur();
            Hesapla(ogr);
            ogrenciler.Add(ogr);
            
            Listele();
            Temizle();
        }
        private Student OgrenciOlustur()
        {
            Student ogr = new Student(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
            return ogr;
        }
        private void Hesapla(Student ogr)
        {
            int ortalama = (int)Math.Ceiling((ogr.VizeNotu * 0.4) + (ogr.FinalNotu * 0.6));
            if (ortalama > 60)
            {
                ogr.Basari = true;
            }
        }
        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (Student item in ogrenciler)
            {
                listBox1.Items.Add(item);
                if (item.Basari)
                {
                    listBox1.BackColor = Color.Bisque;
                }
                else
                {
                    listBox1.BackColor = Color.Red;
                }
            }
        }
    }
}
