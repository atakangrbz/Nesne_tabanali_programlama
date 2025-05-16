using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modül_Ünite4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    throw new ArgumentNullException("Boş değer girilemez!");

                int sayi;

              
                if (!int.TryParse(textBox1.Text, out sayi))
                    throw new FormatException("Lütfen sadece sayı giriniz!");

               
                if (sayi < 0)
                    throw new Exception("Pozitif sayı girilmelidir!");

                int sonuc;

                
                checked
                {
                    
                    sonuc = sayi * sayi;
                }

                label3.Text = "Sonuç: " + sonuc.ToString();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Sayı çok büyük veya çok küçük! " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
