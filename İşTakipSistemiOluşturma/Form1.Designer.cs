namespace İşTakipSistemiOluşturma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbhatirlat = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnsecilenisil = new System.Windows.Forms.Button();
            this.btnhepsinisil = new System.Windows.Forms.Button();
            this.btndosyayakaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndurdur = new System.Windows.Forms.Button();
            this.pictureBoxsaat = new System.Windows.Forms.PictureBox();
            this.pictureBoxzil = new System.Windows.Forms.PictureBox();
            this.labzaman = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labkayitsayisi = new System.Windows.Forms.Label();
            this.txtisadi = new System.Windows.Forms.TextBox();
            this.IsNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxzil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İş Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama:";
            // 
            // cbhatirlat
            // 
            this.cbhatirlat.AutoSize = true;
            this.cbhatirlat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbhatirlat.Location = new System.Drawing.Point(147, 116);
            this.cbhatirlat.Name = "cbhatirlat";
            this.cbhatirlat.Size = new System.Drawing.Size(83, 23);
            this.cbhatirlat.TabIndex = 4;
            this.cbhatirlat.Text = "Hatırlat";
            this.cbhatirlat.UseVisualStyleBackColor = true;
            this.cbhatirlat.CheckedChanged += new System.EventHandler(this.cbhatirlat_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenikayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenikayit.ImageIndex = 2;
            this.btnyenikayit.ImageList = this.ımageList1;
            this.btnyenikayit.Location = new System.Drawing.Point(147, 159);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(140, 44);
            this.btnyenikayit.TabIndex = 6;
            this.btnyenikayit.Text = "       &Yeni Kayıt";
            this.btnyenikayit.UseVisualStyleBackColor = true;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "çöpkutusuyeni.png");
            this.ımageList1.Images.SetKeyName(1, "dosyayakayet1_ikon.png");
            this.ımageList1.Images.SetKeyName(2, "eklemeikon.png");
            this.ımageList1.Images.SetKeyName(3, "hepsinisil.png");
            this.ımageList1.Images.SetKeyName(4, "kaydetikon.png");
            this.ımageList1.Images.SetKeyName(5, "pencil (1)ikon.png");
            this.ımageList1.Images.SetKeyName(6, "seçilenisilikon.png");
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.ImageIndex = 4;
            this.btnkaydet.ImageList = this.ımageList1;
            this.btnkaydet.Location = new System.Drawing.Point(318, 159);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(136, 44);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "     &Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnduzelt.ImageIndex = 5;
            this.btnduzelt.ImageList = this.ımageList1;
            this.btnduzelt.Location = new System.Drawing.Point(479, 159);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(127, 44);
            this.btnduzelt.TabIndex = 8;
            this.btnduzelt.Text = "       &Düzelt";
            this.btnduzelt.UseVisualStyleBackColor = true;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnsecilenisil
            // 
            this.btnsecilenisil.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsecilenisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsecilenisil.ImageIndex = 6;
            this.btnsecilenisil.ImageList = this.ımageList1;
            this.btnsecilenisil.Location = new System.Drawing.Point(130, 638);
            this.btnsecilenisil.Name = "btnsecilenisil";
            this.btnsecilenisil.Size = new System.Drawing.Size(157, 43);
            this.btnsecilenisil.TabIndex = 9;
            this.btnsecilenisil.Text = "       &Seçileni Sil";
            this.btnsecilenisil.UseVisualStyleBackColor = true;
            this.btnsecilenisil.Click += new System.EventHandler(this.btnsecilenisil_Click);
            // 
            // btnhepsinisil
            // 
            this.btnhepsinisil.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhepsinisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhepsinisil.ImageIndex = 0;
            this.btnhepsinisil.ImageList = this.ımageList1;
            this.btnhepsinisil.Location = new System.Drawing.Point(318, 639);
            this.btnhepsinisil.Name = "btnhepsinisil";
            this.btnhepsinisil.Size = new System.Drawing.Size(141, 42);
            this.btnhepsinisil.TabIndex = 10;
            this.btnhepsinisil.Text = "      &Hepsini Sil";
            this.btnhepsinisil.UseVisualStyleBackColor = true;
            this.btnhepsinisil.Click += new System.EventHandler(this.btnhepsinisil_Click);
            // 
            // btndosyayakaydet
            // 
            this.btndosyayakaydet.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndosyayakaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndosyayakaydet.ImageIndex = 1;
            this.btndosyayakaydet.ImageList = this.ımageList1;
            this.btndosyayakaydet.Location = new System.Drawing.Point(479, 638);
            this.btndosyayakaydet.Name = "btndosyayakaydet";
            this.btndosyayakaydet.Size = new System.Drawing.Size(174, 44);
            this.btndosyayakaydet.TabIndex = 11;
            this.btndosyayakaydet.Text = "      &Dosyaya Kaydet";
            this.btndosyayakaydet.UseVisualStyleBackColor = true;
            this.btndosyayakaydet.Click += new System.EventHandler(this.btndosyayakaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btndurdur);
            this.panel1.Controls.Add(this.pictureBoxsaat);
            this.panel1.Controls.Add(this.pictureBoxzil);
            this.panel1.Controls.Add(this.labzaman);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(76, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 62);
            this.panel1.TabIndex = 12;
            // 
            // btndurdur
            // 
            this.btndurdur.Location = new System.Drawing.Point(476, 12);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(91, 38);
            this.btndurdur.TabIndex = 21;
            this.btndurdur.Text = "Durdur";
            this.btndurdur.UseVisualStyleBackColor = true;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // pictureBoxsaat
            // 
            this.pictureBoxsaat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxsaat.Image")));
            this.pictureBoxsaat.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxsaat.Name = "pictureBoxsaat";
            this.pictureBoxsaat.Size = new System.Drawing.Size(100, 56);
            this.pictureBoxsaat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxsaat.TabIndex = 20;
            this.pictureBoxsaat.TabStop = false;
            // 
            // pictureBoxzil
            // 
            this.pictureBoxzil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxzil.Image")));
            this.pictureBoxzil.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxzil.Name = "pictureBoxzil";
            this.pictureBoxzil.Size = new System.Drawing.Size(100, 56);
            this.pictureBoxzil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxzil.TabIndex = 19;
            this.pictureBoxzil.TabStop = false;
            // 
            // labzaman
            // 
            this.labzaman.AutoSize = true;
            this.labzaman.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labzaman.Location = new System.Drawing.Point(125, 22);
            this.labzaman.Name = "labzaman";
            this.labzaman.Size = new System.Drawing.Size(0, 19);
            this.labzaman.TabIndex = 16;
            this.labzaman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(124, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 18;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightBlue;
            this.listBox1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(76, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(574, 328);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtaciklama
            // 
            this.txtaciklama.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaciklama.Location = new System.Drawing.Point(108, 77);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(535, 33);
            this.txtaciklama.TabIndex = 14;
            this.txtaciklama.MouseEnter += new System.EventHandler(this.txtaciklama_MouseEnter);
            this.txtaciklama.MouseLeave += new System.EventHandler(this.txtaciklama_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(524, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kayıt Sayısı:";
            // 
            // labkayitsayisi
            // 
            this.labkayitsayisi.AutoSize = true;
            this.labkayitsayisi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labkayitsayisi.Location = new System.Drawing.Point(622, 616);
            this.labkayitsayisi.Name = "labkayitsayisi";
            this.labkayitsayisi.Size = new System.Drawing.Size(17, 19);
            this.labkayitsayisi.TabIndex = 18;
            this.labkayitsayisi.Text = "-";
            // 
            // txtisadi
            // 
            this.txtisadi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtisadi.Location = new System.Drawing.Point(108, 29);
            this.txtisadi.Multiline = true;
            this.txtisadi.Name = "txtisadi";
            this.txtisadi.Size = new System.Drawing.Size(535, 33);
            this.txtisadi.TabIndex = 20;
            this.txtisadi.MouseEnter += new System.EventHandler(this.txtisadi_MouseEnter);
            this.txtisadi.MouseLeave += new System.EventHandler(this.txtisadi_MouseLeave);
            // 
            // IsNotify
            // 
            this.IsNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.IsNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("IsNotify.Icon")));
            this.IsNotify.Text = "İş Takibi 1.0.0.1";
            this.IsNotify.Visible = true;
            this.IsNotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IsNotify_MouseDoubleClick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(470, 498);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(169, 97);
            this.axWindowsMediaPlayer1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 714);
            this.Controls.Add(this.txtisadi);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labkayitsayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndosyayakaydet);
            this.Controls.Add(this.btnhepsinisil);
            this.Controls.Add(this.btnsecilenisil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyenikayit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbhatirlat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Takibi 1.0.0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxzil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbhatirlat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnsecilenisil;
        private System.Windows.Forms.Button btnhepsinisil;
        private System.Windows.Forms.Button btndosyayakaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labzaman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labkayitsayisi;
        private System.Windows.Forms.PictureBox pictureBoxsaat;
        private System.Windows.Forms.PictureBox pictureBoxzil;
        private System.Windows.Forms.Button btndurdur;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox txtisadi;
        private System.Windows.Forms.NotifyIcon IsNotify;
    }
}

