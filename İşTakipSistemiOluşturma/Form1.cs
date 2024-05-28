using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace İşTakipSistemiOluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;//listbox'ın sağ kenarının ötesindeki öğeler için yatay kaydırma çubuğu görüntülenip görüntülenmeyeceğini gösterir
            axWindowsMediaPlayer1.Visible = false;
            this.MaximizeBox = false;//ekranı büyültme simgesini pasif bırakır
            this.KeyPreview = true;//tuş ataması yapmamız için öncelikle burayı true yapıyoruz
            dateTimePicker1.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;//formu ekran merkezinde çalıştırmamızı sağlar

            pictureBoxsaat.Visible = true;
            pictureBoxzil.Visible = false;

            btndurdur.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;

            timer1.Start();
            timer2.Start();

            // label3.Text =("Bugün:"+ dateTimePicker1.Value + DateTime.Now.ToString());

            try
            {
                // Liste.txt dosyasının yolunu belirtin
                string dosyaYolu = "Liste.txt";

                // Dosyayı oku ve listBox1'e ekle
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        listBox1.Items.Add(satir);
                        kayitsayisi();
                    }
                    sr.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata! Okunacak Dosya Bulunamadı... " + hata.Message);
            }

        }
        private void kayitsayisi()
        {
            int kayitsayisi = listBox1.Items.Count;
            labkayitsayisi.Text = Convert.ToString(kayitsayisi);
        }

        private void txtisadi_MouseEnter(object sender, EventArgs e)
        {
            txtisadi.BackColor = Color.LightYellow;
        }

        private void txtisadi_MouseLeave(object sender, EventArgs e)
        {
            txtisadi.BackColor = Color.White;
        }

        private void txtaciklama_MouseEnter(object sender, EventArgs e)
        {
            txtaciklama.BackColor = Color.LightYellow;
        }

        private void txtaciklama_MouseLeave(object sender, EventArgs e)
        {
            txtaciklama.BackColor = Color.White;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt && e.KeyCode == Keys.Y)
            {
                btnyenikayit.PerformClick();
            }
            else if (e.KeyCode == Keys.Alt && e.KeyCode == Keys.K)
            {
                btnkaydet.PerformClick();
            }
            else if (e.KeyCode == Keys.Alt && e.KeyCode == Keys.Z)
            {
                btnduzelt.PerformClick();
            }
            else if (e.KeyCode == Keys.Alt && e.KeyCode == Keys.S)
            {
                btnsecilenisil.PerformClick();
            }
            else if (e.KeyCode == Keys.Alt && e.KeyCode == Keys.H)
            {
                btnhepsinisil.PerformClick();
            }
            else if (e.KeyCode == Keys.Alt && e.KeyCode == Keys.D)
            {
                btndosyayakaydet.PerformClick();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string isadi, aciklama;
            isadi = txtisadi.Text;
            aciklama = txtaciklama.Text;

            //listBox1.Items.Add(isadi + " - " +  aciklama + " - " + dateTimePicker1.Text);

            if (string.IsNullOrWhiteSpace(txtisadi.Text) || string.IsNullOrWhiteSpace(txtaciklama.Text))
            {
                DialogResult cevap = MessageBox.Show("Lütfen iş adını ve açıklamasını boş geçmeyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (txtisadi.Text != " " && txtaciklama.Text != " " && cbhatirlat.Checked == true)
                {
                    listBox1.Items.Add(isadi + " - " + aciklama + " - " + dateTimePicker1.Text);
                }
                else if (txtisadi.Text != " " && txtaciklama.Text != " " && cbhatirlat.Checked == false)
                {
                    listBox1.Items.Add(isadi + " - " + aciklama);
                }
            }
            kayitsayisi();
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            txtisadi.Text = " ";
            txtaciklama.Text = " ";
            cbhatirlat.Checked = false;
            dateTimePicker1.Visible = false;
        }

        private void btnduzelt_Click(object sender, EventArgs e)
        {
            string guncelisadi, guncelaciklama;
            guncelisadi = txtisadi.Text;
            guncelaciklama = txtaciklama.Text;

            // Yeni içerik oluşturma
            string newItem = txtisadi.Text.Trim() + " - " + txtaciklama.Text.Trim();

            if (listBox1.SelectedItems.Count != 0)
            {
                DialogResult cevap = MessageBox.Show("Seçilen kayıt değiştirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if (cbhatirlat.Checked && dateTimePicker1.Enabled)
                    {
                        dateTimePicker1.Enabled = true;
                        dateTimePicker1.Visible = true;
                        // Eğer hatırlatma işaretliyse ve datetimepicker aktifse, tarih-zaman bilgisini ekle
                        newItem += " - " + dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm:ss");
                    }
                    else
                    {
                        newItem += " ";
                    }

                }
            }
            // ListBox'ta seçili öğenin indeksini al
            int selectedIndex = listBox1.SelectedIndex;

            // Yeni içeriği seçili öğenin yerine koy
            listBox1.Items[selectedIndex] = newItem;
        }
        private void cbhatirlat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhatirlat.Checked)
            {
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Seçili öğeyi al ve '-' ile böl
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] itemDetails = selectedItem.Split('-');

                // En az 2 parça olup olmadığını kontrol et (txtisadi ve txtaciklama için)
                if (itemDetails.Length >= 2)
                {
                    // txtisadi ve txtaciklama alanlarını doldur
                    txtisadi.Text = itemDetails[0].Trim();
                    txtaciklama.Text = itemDetails[1].Trim();

                    // Üçüncü bir parça olup olmadığını kontrol et (tarih-zaman bilgisi)
                    if (itemDetails.Length >= 3)
                    {
                        DateTime date;
                        // Üçüncü parçayı DateTime olarak parse etmeye çalış
                        if (DateTime.TryParse(itemDetails[2].Trim(), out date))
                        {
                            dateTimePicker1.Value = date;
                            cbhatirlat.Checked = true; // Hatırlatma checkbox'ını işaretle
                            dateTimePicker1.Enabled = true; // DateTimePicker'ı aktif yap
                        }
                        else
                        {
                            // Tarih-zaman bilgisi geçerli değilse
                            dateTimePicker1.Visible = false;
                            cbhatirlat.Checked = false; // Hatırlatma checkbox'ını işaretsiz yap
                        }
                    }
                    else
                    {
                        // Tarih-zaman bilgisi yoksa DateTimePicker'ı pasif yap
                        dateTimePicker1.Visible = false;
                        cbhatirlat.Checked = false; // Hatırlatma checkbox'ını işaretsiz yap
                    }
                }
                else
                {
                    // En az 2 parça yoksa DateTimePicker'ı pasif yap ve checkbox'ı işaretsiz yap
                    dateTimePicker1.Visible = false;
                    cbhatirlat.Checked = false; // Hatırlatma checkbox'ını işaretsiz yap
                }
            }
        }


        private void btnsecilenisil_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedIndex < 0)
                {
                    DialogResult cevap = MessageBox.Show("Lütfen bir eleman seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult cevap = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        txtisadi.Text = " ";
                        txtaciklama.Text = " ";
                        cbhatirlat.Checked = false;
                        dateTimePicker1.Visible = false;

                        kayitsayisi();
                    }

                }
            }
            else
            {
                DialogResult cevap = MessageBox.Show("Listede silinecek eleman yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dosyayıkaydet();
        }

        private void btnhepsinisil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Hepsini Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                listBox1.Items.Clear();

            }
            kayitsayisi();
            dosyayıkaydet();
        }

        private void dosyayıkaydet()
        {
            StreamWriter yaz = new StreamWriter("Liste.txt");
            // StreamWriter sw = new StreamWriter("Liste.txt");//bizden içine bir dosya adı yazmamızı ister
            foreach (string bilgi in listBox1.Items)
            {
                yaz.WriteLine(bilgi);
            }
            yaz.Close();
            // MessageBox.Show("Başarıyla dosyaya kaydedildi", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndosyayakaydet_Click(object sender, EventArgs e)
        {
            dosyayıkaydet();
            MessageBox.Show("Başarıyla dosyaya kaydedildi", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool goster;
        private void timer1_Tick(object sender, EventArgs e)
        {

            //label3.Text = "Bugün: " + DateTime.Now.ToString("dd.MM.yyyy  dddd") + "  " + "Saat: " + DateTime.Now.ToString("HH:mm:ss");


            // DateTime suan = DateTime.Now;
            string satir, mesaj;
            panel();
            goster = false;
            mesaj = labzaman.Text;
            //mesaj = "Bugün: " + suan.ToLongDateString() + " Saat: " + suan.ToString("HH:mm:ss");
            resimdegisme(goster, mesaj);


           // labzaman.Text = DateTime.Now.ToString("dd.MM.yyyy  dddd") + "  " + DateTime.Now.ToString("HH:mm: ss ");
           
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                satir = listBox1.Items[i].ToString();
                string[] dizi = satir.Split('-');
                if (dizi.Length < 2)
                {
                    continue;//tarih ve saat parametresi olmayan işler varsa başa dön 
                }
                else if (dizi.Length > 2)
                {

                    if (DateTime.Now.ToString("dd.MM.yyyy dddd HH:mm").Trim() == DateTime.Parse(dizi[2]).ToString("dd.MM.yyyy dddd HH:mm"))
                    {
                        //   mesaj = label3.Text;
                        //  panel1.ForeColor = Color.Navy;

                        label5.Text = dizi[0] + " " + dizi[1] + " " + dizi[2];

                        goster = true;
                        listBox1.SelectedIndex = i;

                        resimdegisme(goster, mesaj);
                        bildirigoster();

                        if (btndurdur.Visible == true)
                        {
                            playMp3();
                            labzaman.BackColor = Color.Navy;
                            labzaman.ForeColor = Color.White;
                            //label3.Text = listBox1.SelectedItem.ToString();
                            // labzaman.Text = txtisadi.Text + " " + txtaciklama.Text;


                        }
                        else
                        {

                            stopMp3();
                            // labzaman.Text = txtisadi.Text + " " + txtaciklama.Text;

                        }
                    }
                }

            }



            // label3.Text = dateTimePicker1.Value.ToString("dd.MM.yyyy   dddd") + " " + DateTime.Now.ToString("h:mm:ss");

        }

        private void playMp3()
        {
           
            axWindowsMediaPlayer1.settings.volume = 100;
            axWindowsMediaPlayer1.URL = "alarmm.mp3";
            btndurdur.Text = "Durdur"; // Butonun metnini değiştiriyoruz
            btndurdur.Enabled = true; // Butonu etkin hale getiriyoruz
        }

        private void stopMp3()
        {
            
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            btndurdur.Text = "Başlat"; // Butonun metnini değiştiriyoruz
            btndurdur.Enabled = true; 
        }


        private void resimdegisme(bool goster, string mesaj)
        {
            labzaman.Text = goster.ToString() + mesaj;
            if (goster == true)
            {
                label5.Visible = true;
                labzaman.Visible = false;
                pictureBoxsaat.Visible = false;
                pictureBoxzil.Visible = true;
                btndurdur.Visible = true;
                labzaman.Text = mesaj;
                panel1.BackColor = Color.Navy;
            }
            else
            {
                label5.Visible = false;
                labzaman.Visible = true;

                pictureBoxsaat.Visible = true;
                pictureBoxzil.Visible = false;
                btndurdur.Visible = false;
                labzaman.Text = mesaj;
                panel1.BackColor = Color.White;

            }

        }

        private void panel()
        {
            labzaman.BackColor = Color.White;
            labzaman.ForeColor = Color.Black;
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter yaz = new StreamWriter("Liste.txt");
            // StreamWriter sw = new StreamWriter("Liste.txt");//bizden içine bir dosya adı yazmamızı ister
            foreach (string bilgi in listBox1.Items)
            {
                yaz.WriteLine(bilgi);
            }
            yaz.Close();
        }

        private void bildirigoster()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Hide();
                IsNotify.Visible = true;
                IsNotify.Text = "İş Hatırlatma Programı";
                IsNotify.BalloonTipIcon = ToolTipIcon.Info;
                IsNotify.BalloonTipTitle = "İş Takibi 1.0 Çalışıyor...";
                IsNotify.BalloonTipText = label5.Text.ToString();//text mesaja eşit olucak
                IsNotify.ShowBalloonTip(10000);
                IsNotify.MouseDoubleClick += new MouseEventHandler(IsNotify_MouseDoubleClick);

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                IsNotify.Visible = true;
                IsNotify.Text = "İş Hatırlatma Programı";
                IsNotify.BalloonTipIcon = ToolTipIcon.Info;
                IsNotify.BalloonTipTitle = "İş Takibi 1.0 Çalışıyor...";
                IsNotify.BalloonTipText = "İş Takibi ile işlerinizi atlamayın";
                IsNotify.ShowBalloonTip(1000);
                IsNotify.MouseDoubleClick += new MouseEventHandler(IsNotify_MouseDoubleClick);

            }
        }

        private void IsNotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            //IsNotify.Visible = false;
        }

        private void btndurdur_Click(object sender, EventArgs e)
        {

            //btnDurdur.Visible = false;
           

            if (btndurdur.Text == "Durdur")
            {
                stopMp3();
                btndurdur.Text = "Başlat";
                labzaman.Text = txtisadi.Text + " " + txtaciklama.Text;

                


            }
            else if (btndurdur.Text == "Başlat")
            {
                btndurdur.Enabled = true;
                playMp3();
                btndurdur.Text = "Durdur";
                labzaman.Text = txtisadi.Text + " " + txtaciklama.Text;
              
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labzaman.Text = "Bugün: " + DateTime.Now.ToString("dd.MM.yyyy  dddd") + "  " + "Saat: " + DateTime.Now.ToString("HH:mm: ss ");
        }

      
    }
    }

