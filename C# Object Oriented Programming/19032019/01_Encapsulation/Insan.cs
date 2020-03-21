using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Encapsulation
{
    public class Insan
    {
        /*
            Public Access Specifier
            Public access specifier allows a class to expose its member variables and
            member functions to other functions and objects. Any public member can be
            accessed from outside the class.
         */

         /*
            Private Access Specifier
            Private access specifier allows a class to hide its member variables and
            member functions from other functions and objects. Only functions of the 
            same class can access its private members. Even an instance of a class cannot 
            access its private members.
         */
        public string Soyad { get; set; }
        public int Kilo { get; set; }
        public int Boy { get; set; }


        private string _id;
        public string ID
        {
            get { return _id; }  //Fieldtaki veriyi istenilen yere gönderir
            set //dışarıdan girilen value degeri eger koşulları sağlıyor ise fielda atamamızı sağlar
            {
                if (value.Length == 11)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("Lütfen doğru formatta id girişi yapınız");
                }
            }  //Value dışarıdan girilen veriyi temsil eden anahtar kelimedir
        }

        private string _ad; //Field

        public string Ad //Property
        {
            get { return _ad; }
            set
            {
                if (value == "Admin")
                {
                    _ad = value;
                }
                else
                {
                    MessageBox.Show("vava");
                }
            }
        }
        
        private int _yas;

        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value > 18 && value < 100)
                {
                    _yas = value;
                }
                else
                {
                    throw new Exception("Yaşınız uygun degil.");
                }
            }
        }


    }
}
