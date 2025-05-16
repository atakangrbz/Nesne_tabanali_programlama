using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modül2_Ünite1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gunListe = Enum.GetNames
(typeof(Gunler));
            foreach (string gun in gunListe)
            {

                comboBox1.Items.Add(gun);
            }

        }
        enum Gunler
        {
            Pazartesi, Salı, Çarşamba, Perşembe,
            Cuma, Cumartesi, Pazar
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
