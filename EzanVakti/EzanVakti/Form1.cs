using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace EzanVakti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Click += NotifyIcon1_Click;
            CheckForIllegalCrossThreadCalls = false;
        }


        bool gun = false;
        string imsak;
        string gunes;
        string ogle;
        string ikindi;
        string aksam;
        string yatsi;




        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var scrape = new HtmlWeb();
                var page = scrape.Load(Ayar.Ayarlar.Default.Sehir);


                var scrape2 = new HtmlWeb();
                var page2 = scrape2.Load("https://www.diyanet.gov.tr/tr-TR/");

                var node = page.DocumentNode.SelectNodes("/html/body/div[4]/div[2]/div[2]/div/div[1]/div/div[2]");
                var node2 = page.DocumentNode.SelectNodes("/html/body/div[4]/div[2]/div[2]/div/div[2]/div/div[2]");
                var node3 = page.DocumentNode.SelectNodes("/html/body/div[4]/div[2]/div[2]/div/div[3]/div/div[2]");
                var node4 = page.DocumentNode.SelectNodes("/html/body/div[4]/div[2]/div[2]/div/div[4]/div/div[2]");
                var node5 = page.DocumentNode.SelectNodes("/html/body/div[4]/div[2]/div[2]/div/div[5]/div/div[2]");
                var node6 = page.DocumentNode.SelectNodes("/html/body/div[4]/div[2]/div[2]/div/div[6]/div/div[2]");
                
                var node8 = page.DocumentNode.SelectNodes("/html/body/div[4]/div[2]/div[1]/div[1]/div[1]/div/div[1]/div[3]");


                var node9 = page2.DocumentNode.SelectNodes("/html/body/div[2]/div/div[10]/div[1]/div[1]/a/p"); //AYET
                var dokuz1 = page2.DocumentNode.SelectNodes("/html/body/div[2]/div/div[10]/div[1]/div[2]/p");




                foreach (var item in node9)
                {
                    label10.Text = item.InnerText.Trim();
                }
                foreach (var item in dokuz1)
                {
                    label10.Text += "\n" +item.InnerText.Trim();
                }






                foreach (var item in node)
                {
                    label1.Text += item.InnerText.Trim();
                    imsak = item.InnerText.Trim();
                }
                foreach (var item in node2)
                {
                    label2.Text += item.InnerText;
                    gunes = item.InnerText.Trim();
                }
                foreach (var item in node3)
                {
                    label3.Text += item.InnerText;
                    ogle = item.InnerText.Trim();
                }
                foreach (var item in node4)
                {
                    label4.Text += item.InnerText;
                    ikindi = item.InnerText.Trim();
                }
                foreach (var item in node5)
                {
                    label5.Text += item.InnerText;
                    aksam = item.InnerText.Trim();
                }
                foreach (var item in node6)
                {
                    label6.Text += item.InnerText;
                    yatsi = item.InnerText.Trim();
                    
                }



                //TARİH
                foreach (var item in node8)
                {
                    label9.Text += item.InnerText;
                }

                pictureBox1.Load("http://namazvakti.diyanet.gov.tr/images/d2.gif");




                Kontrol(imsak,gunes,ogle,ikindi,aksam,yatsi);

            });



           // axWindowsMediaPlayer1.URL = "bildirim-sesi-2.mp3";
           // axWindowsMediaPlayer1.Ctlcontrols.play();


            //axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        string guncelVakit = "";
        public async Task<Task> Kontrol(string imsak, string gunes, string ogle, string ikindi, string aksam, string yatsi)
        {

            

            return Task.Run(() =>
            {
                axWindowsMediaPlayer1.URL = Ayar.Ayarlar.Default.bildirimSesi;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                while (true)
                    {

                        string zaman = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                       
                    
                        if (imsak == zaman)
                        {
                        if (guncelVakit != zaman)
                        {
                            MessageBox.Show("İmsak Vakti Geldi!");
                            if (Ayar.Ayarlar.Default.Bildirim == true)
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            guncelVakit = zaman;
                        }
                        }

                        if (gunes == zaman)
                        {
                        if (guncelVakit != zaman)
                        {
                            MessageBox.Show("İmsak Vakti Geldi!");
                            if (Ayar.Ayarlar.Default.Bildirim == true)
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            guncelVakit = zaman;
                        }
                        }

                        if (ogle == zaman)
                        {
                        if (guncelVakit != zaman)
                        {
                            MessageBox.Show("İmsak Vakti Geldi!");
                            if (Ayar.Ayarlar.Default.Bildirim == true)
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            guncelVakit = zaman;
                        }
                        }

                        if (ikindi == zaman)
                        {
                        if (guncelVakit != zaman)
                        {
                            MessageBox.Show("İmsak Vakti Geldi!");
                            if (Ayar.Ayarlar.Default.Bildirim == true)
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            guncelVakit = zaman;
                        }
                        }
 
                        if (aksam == zaman)
                        {
                        if (guncelVakit != zaman)
                        {
                            MessageBox.Show("İmsak Vakti Geldi!");
                            if (Ayar.Ayarlar.Default.Bildirim == true)
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            guncelVakit = zaman;
                        }
                        }

                        if (yatsi == zaman)
                        {
                        if (guncelVakit != zaman)
                        {
                            MessageBox.Show("İmsak Vakti Geldi!");
                            if (Ayar.Ayarlar.Default.Bildirim == true)
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            guncelVakit = zaman;
                        }
                        }



                        //await Task.Delay(6000);


                    }
                    

                
            }


                );



        }



        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGoAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frmAyarlar = new frmAyarlar();
            frmAyarlar.ShowDialog();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }



        private void label9_Click(object sender, EventArgs e)
        {

        }


        frmAyarlar ayarlar = new frmAyarlar();
        private void button1_Click(object sender, EventArgs e)
        {
            ayarlar.ShowDialog();
        }

    }
}
