﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci("22222222222", "Mustafa", "Esen", DateTime.Now, "Teknoloji");
            string tamAd = ogr.TamAdiGetir();
            MessageBox.Show(tamAd);
        }
    }
}
