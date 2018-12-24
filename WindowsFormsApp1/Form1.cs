using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          //  WindowsFormsApp1.Form1.tex = ConfigurationManager.AppSettings["ProgramAdi"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Firma f = new Firma();
            f.Unvan = textBox1.Text;
            f.FirmaTipi = comboBox1.SelectedIndex + 1;
            f.Adres1 = textBox2.Text;
            f.Adres2 = textBox3.Text;
            f.VergiDairesi = textBox4.Text;
            f.VergiNo = textBox5.Text;

            if(f.Ekle()>0)
            {
                MessageBox.Show("Basarili");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Firma f = new Firma();
            List<Firma> firmalar = f.FirmalariVer();
            dataGridView1.DataSource = firmalar;
        }
    }
}
