using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
          * DELEGATE
          * Bir olay gerçekleştiğinde birden fazla fonksiyonu çağırmak istediğinizi düşünelim.
          * Örneğin kullanıcı bir düğmeye tıkladığında birden fazla method'un otomatik olarak çağrılmasını 
          * istiyorsunuz. Bunun için delagate kullanabilirsiniz. Burada amaç bir olay olduğunda birden fazla yere bu olayı bildirebilmek.
          * Bu olay ile ilgilenler delegate ile olaydan haberdar olurlar.
          * 
          * yada
          * 
          * Temsilci olarak adlandirilabilecek bu yapi, projeyi asil ayakta tutan nesneleri yormak yerine, 
          * onlarin islerini uzerine alarak gerceklestirmekten sorumlu olan tiptir. 
          * Bu sayede uygulamamizin her bir kolu, uzerine dusen gorevi eksiksiz yerine getirerek daha uzun sureli ve
          * performansli uygulamalar ortaya koyma sansina sahip olabiliriz.
          * 
          * Unutulmamasi gereken nokta ise, delegeler de aslinda birer class'tır.
          * Delege tanimlamak icin;
          * 1) Oncelikle delege tanımlamasi gerceklestirilir (geri donus tipi unutulmamalidir!)
          * 2) Delege'nin calismasi konusunda sorumlu olabilecegi metotlar yazilir...
          * 3) Delege'de instance alindigi asamada ilgili metot delegeye baglanir ve metot yerine delege'nin Invoke() metodu cagrilir...
          */

            //1.Madde
        public delegate void Logger(string message); //Delege tanımlamasıdır


        //2. madde methodlar
        public void SmsLogger(string message)
        {
            label6.Text = message;
            button1.Enabled = false;

        }

        public void MailLogger(string message)
        {
            label7.Text = message;
            button1.Text = "sisteme ulaşılamıyor";
        }

        public void XmlLogger(string message)
        {
            label8.Text = message;
        }

        public void DbLogger(string message)
        {
            label9.Text = message;
        }
        public void CrashLogger(string message)
        {
            label10.Text = message;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //3. madde
            Logger logger = new Logger(SmsLogger);  // varolan metotların delegate'e bağlanma işlemi
            logger += MailLogger;
            logger += DbLogger;
            logger += XmlLogger;
            logger += CrashLogger;

            //3.madde
            logger.Invoke("sistem Kapatıldı"); //delegate'i çağırma işlemi
        }
    }
}
