namespace MyFinancialCrm
{
    partial class FrmBankProcesses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankProcesses));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbbankaad = new System.Windows.Forms.ComboBox();
            this.cmbislemtipi = new System.Windows.Forms.ComboBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnliste = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngiderler = new System.Windows.Forms.Button();
            this.btnfaturalar = new System.Windows.Forms.Button();
            this.btnbankalar = new System.Windows.Forms.Button();
            this.btnkategoriler = new System.Windows.Forms.Button();
            this.btnbankahareket = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnayarlar = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(319, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1123, 523);
            this.panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 523);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbbankaad);
            this.panel2.Controls.Add(this.cmbislemtipi);
            this.panel2.Controls.Add(this.dttarih);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txttutar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnguncelle);
            this.panel2.Controls.Add(this.btnekle);
            this.panel2.Controls.Add(this.btnliste);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtaciklama);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(320, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 227);
            this.panel2.TabIndex = 5;
            // 
            // cmbbankaad
            // 
            this.cmbbankaad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbbankaad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbankaad.FormattingEnabled = true;
            this.cmbbankaad.Location = new System.Drawing.Point(683, 118);
            this.cmbbankaad.Name = "cmbbankaad";
            this.cmbbankaad.Size = new System.Drawing.Size(320, 27);
            this.cmbbankaad.TabIndex = 6;
            // 
            // cmbislemtipi
            // 
            this.cmbislemtipi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbislemtipi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbislemtipi.FormattingEnabled = true;
            this.cmbislemtipi.Items.AddRange(new object[] {
            "Gelen Havale",
            "Giden Havale",
            "Kredi Ödemesi",
            "Kredi Kartı Ödemesi"});
            this.cmbislemtipi.Location = new System.Drawing.Point(683, 25);
            this.cmbislemtipi.Name = "cmbislemtipi";
            this.cmbislemtipi.Size = new System.Drawing.Size(320, 27);
            this.cmbislemtipi.TabIndex = 4;
            // 
            // dttarih
            // 
            this.dttarih.CalendarMonthBackground = System.Drawing.Color.White;
            this.dttarih.CalendarTitleBackColor = System.Drawing.Color.Yellow;
            this.dttarih.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttarih.Location = new System.Drawing.Point(185, 117);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(281, 27);
            this.dttarih.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Banka Adı:";
            // 
            // txttutar
            // 
            this.txttutar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttutar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttutar.Location = new System.Drawing.Point(683, 71);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(320, 27);
            this.txttutar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(617, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "İşlem Tipi:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btnguncelle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.ForeColor = System.Drawing.Color.White;
            this.btnguncelle.Location = new System.Drawing.Point(745, 169);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(258, 49);
            this.btnguncelle.TabIndex = 10;
            this.btnguncelle.Text = "İşlemi Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btnekle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(408, 169);
            this.btnekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(269, 49);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "İşlem Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnliste
            // 
            this.btnliste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btnliste.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnliste.ForeColor = System.Drawing.Color.White;
            this.btnliste.Location = new System.Drawing.Point(115, 169);
            this.btnliste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnliste.Name = "btnliste";
            this.btnliste.Size = new System.Drawing.Size(256, 49);
            this.btnliste.TabIndex = 7;
            this.btnliste.Text = "Listele";
            this.btnliste.UseVisualStyleBackColor = false;
            this.btnliste.Click += new System.EventHandler(this.btnliste_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşlem Tarihi:";
            // 
            // txtaciklama
            // 
            this.txtaciklama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtaciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaciklama.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaciklama.Location = new System.Drawing.Point(185, 71);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(281, 27);
            this.txtaciklama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(185, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(281, 27);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hareket Id:";
            // 
            // btngiderler
            // 
            this.btngiderler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btngiderler.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiderler.ForeColor = System.Drawing.Color.White;
            this.btngiderler.Location = new System.Drawing.Point(12, 322);
            this.btngiderler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btngiderler.Name = "btngiderler";
            this.btngiderler.Size = new System.Drawing.Size(293, 76);
            this.btngiderler.TabIndex = 4;
            this.btngiderler.Text = "Giderler";
            this.btngiderler.UseVisualStyleBackColor = false;
            this.btngiderler.Click += new System.EventHandler(this.btngiderler_Click);
            // 
            // btnfaturalar
            // 
            this.btnfaturalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btnfaturalar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaturalar.ForeColor = System.Drawing.Color.White;
            this.btnfaturalar.Location = new System.Drawing.Point(12, 221);
            this.btnfaturalar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfaturalar.Name = "btnfaturalar";
            this.btnfaturalar.Size = new System.Drawing.Size(293, 76);
            this.btnfaturalar.TabIndex = 3;
            this.btnfaturalar.Text = "Faturalar";
            this.btnfaturalar.UseVisualStyleBackColor = false;
            this.btnfaturalar.Click += new System.EventHandler(this.btnfaturalar_Click);
            // 
            // btnbankalar
            // 
            this.btnbankalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btnbankalar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbankalar.ForeColor = System.Drawing.Color.White;
            this.btnbankalar.Location = new System.Drawing.Point(12, 118);
            this.btnbankalar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbankalar.Name = "btnbankalar";
            this.btnbankalar.Size = new System.Drawing.Size(293, 81);
            this.btnbankalar.TabIndex = 2;
            this.btnbankalar.Text = "Bankalar";
            this.btnbankalar.UseVisualStyleBackColor = false;
            this.btnbankalar.Click += new System.EventHandler(this.btnbankalar_Click);
            // 
            // btnkategoriler
            // 
            this.btnkategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btnkategoriler.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkategoriler.ForeColor = System.Drawing.Color.White;
            this.btnkategoriler.Location = new System.Drawing.Point(12, 15);
            this.btnkategoriler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnkategoriler.Name = "btnkategoriler";
            this.btnkategoriler.Size = new System.Drawing.Size(293, 81);
            this.btnkategoriler.TabIndex = 1;
            this.btnkategoriler.Text = "Kategoriler";
            this.btnkategoriler.UseVisualStyleBackColor = false;
            this.btnkategoriler.Click += new System.EventHandler(this.btnkategoriler_Click);
            // 
            // btnbankahareket
            // 
            this.btnbankahareket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btnbankahareket.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbankahareket.ForeColor = System.Drawing.Color.White;
            this.btnbankahareket.Location = new System.Drawing.Point(12, 422);
            this.btnbankahareket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbankahareket.Name = "btnbankahareket";
            this.btnbankahareket.Size = new System.Drawing.Size(293, 76);
            this.btnbankahareket.TabIndex = 5;
            this.btnbankahareket.Text = "Banka Hareketleri";
            this.btnbankahareket.UseVisualStyleBackColor = false;
            this.btnbankahareket.Click += new System.EventHandler(this.btnbankahareket_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(18)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Controls.Add(this.btnayarlar);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.btnbankahareket);
            this.panel1.Controls.Add(this.btngiderler);
            this.panel1.Controls.Add(this.btnfaturalar);
            this.panel1.Controls.Add(this.btnbankalar);
            this.panel1.Controls.Add(this.btnkategoriler);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 822);
            this.panel1.TabIndex = 4;
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btncikis.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.ForeColor = System.Drawing.Color.White;
            this.btncikis.Location = new System.Drawing.Point(12, 730);
            this.btncikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(293, 78);
            this.btncikis.TabIndex = 8;
            this.btncikis.Text = "Çıkış Yap";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnayarlar
            // 
            this.btnayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btnayarlar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayarlar.ForeColor = System.Drawing.Color.White;
            this.btnayarlar.Location = new System.Drawing.Point(12, 622);
            this.btnayarlar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnayarlar.Name = "btnayarlar";
            this.btnayarlar.Size = new System.Drawing.Size(293, 80);
            this.btnayarlar.TabIndex = 7;
            this.btnayarlar.Text = "Ayarlar";
            this.btnayarlar.UseVisualStyleBackColor = false;
            this.btnayarlar.Click += new System.EventHandler(this.btnayarlar_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(185)))));
            this.btndashboard.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(12, 522);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(293, 78);
            this.btndashboard.TabIndex = 6;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(18)))), ((int)(((byte)(188)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(319, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1120, 52);
            this.panel4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1066, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Banka Hareketleri:";
            // 
            // FrmBankProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 820);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hareketleri:";
            this.Load += new System.EventHandler(this.FrmBankProcesses_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnliste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngiderler;
        private System.Windows.Forms.Button btnfaturalar;
        private System.Windows.Forms.Button btnbankalar;
        private System.Windows.Forms.Button btnkategoriler;
        private System.Windows.Forms.Button btnbankahareket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnayarlar;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbislemtipi;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.ComboBox cmbbankaad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}