using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insan insan = new Insan();
            try
            {
                insan.ID = textBox1.Text;
                insan.Ad = textBox2.Text;
                insan.Soyad = textBox3.Text;
                insan.Yas = int.Parse(textBox4.Text);
                insan.Boy = int.Parse(textBox5.Text);
                insan.Kilo = int.Parse(textBox6.Text);

                MessageBox.Show("Hello " + insan.Ad + " " + insan.Soyad);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
