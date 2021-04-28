using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzanVakti
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();


        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            textBox1.Text = Ayar.Ayarlar.Default.Sehir;
        }

        string dosyaYolu;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Sesi Seçin";
            openFile.Filter = "All Supported Audio | *.mp3";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog()== DialogResult.OK)
            {
                dosyaYolu = openFile.FileName;
                Ayar.Ayarlar.Default.bildirimSesi = dosyaYolu;
                Ayar.Ayarlar.Default.Save();
            }
            textBox1.Text = Ayar.Ayarlar.Default.bildirimSesi;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Ayar.Ayarlar.Default.Bildirim = true;
            Ayar.Ayarlar.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Ayar.Ayarlar.Default.Bildirim = false;
            Ayar.Ayarlar.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Ayar.Ayarlar.Default.Sehir = textBox1.Text;
                Ayar.Ayarlar.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://namazvakitleri.diyanet.gov.tr/tr-TR/");
        }
    }
}
