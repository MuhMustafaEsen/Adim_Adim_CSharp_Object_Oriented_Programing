using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_DelegateEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void HizLimiti()
        {
            listBox1.Items.Add("Hiz Limitini aştınız !!!");
        }
        Araba araba;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer1.Start();
            araba = new Araba(80, "BMW");
            araba.HizAsimi += new HizAsimiEventHandler(HizLimiti);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            araba.Hiz += 10;
            listBox1.Items.Add("arabanın suanki hızı => " + araba.Hiz);

            if (araba.Hiz >= 200)
            {
                timer1.Stop();
                MessageBox.Show("Kaza Yaptın !!!");
            }
        }
    }
}
