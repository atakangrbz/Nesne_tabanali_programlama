﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modül6_Ünite1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            islem();
        }
        public void islem()
        {
            try
            {
                int sayi1 = int.Parse(textBox1.Text);
                int sayi2 = int.Parse(textBox2.Text);

                int toplam = sayi1 + sayi2;

                textBox3.Text = toplam.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
