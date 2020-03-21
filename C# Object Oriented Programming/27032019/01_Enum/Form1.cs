using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Kisilere sabit secenek sunmak için kullanılar bir deger tipidir. Secenekleri kontrol altında tutup uygulamanızı kendi kontrolunuz cercevesinde yönebilirsiniz. 
       * Bu sayede uygulamada herhangi bir surprizle karşılaşma riskini yok etmiş olursunuz.
       * Enumlar geliştiriciye yönelik nesnelerdir.
       * Bir Enumun yazılı degerini almak için kullanılan metot Enum.GetNames()dir
       * Enum arkaplanda sayısal degerler tutar Bu degerler varsayılan olarak int gelir bu tipi degistirebilirsiniz.(byte sbyte short gibi)
       * Enumda benzersizlik yoktur.
       * 
       */
        enum Sehirler
        {
            İstanbul, İzmir, Antalya, Eskişehir, Adana, Urfa, Düzce, Konya, Kırşehir
        }

        enum Sehirler2
        {
            İstanbul = 34, İzmir = 35, Antalya = 7, Eskişehir = 26, Adana = 01, Urfa = 63, Düzce = 81
        }
        enum Sehirler3 : byte
        {
            İstanbul = 34, İzmir = 35, Antalya = 7, Eskişehir = 26, Adana = 01, Urfa = 63, Düzce = 81
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Enum.GetNames(typeof(Sehirler)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte seciliIndex = (byte)Enum.Parse(typeof(Sehirler3), listBox1.Text);
            MessageBox.Show("Seçili sehrin indexi =>" + seciliIndex);
        }
    }
}
