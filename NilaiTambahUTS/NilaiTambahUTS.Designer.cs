namespace NilaiTambahUTS
{
    partial class NilaiTambahUTS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NilaiTambahUTS));
            this.Perempuan = new System.Windows.Forms.RadioButton();
            this.Laki = new System.Windows.Forms.RadioButton();
            this.tbEMAIL = new System.Windows.Forms.TextBox();
            this.tbALAMAT = new System.Windows.Forms.TextBox();
            this.tbNOHP = new System.Windows.Forms.TextBox();
            this.tbNAMA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNIK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FormDataReservasi = new System.Windows.Forms.Button();
            this.tbJUMLAHTAMU = new System.Windows.Forms.TextBox();
            this.tbJUMLAHKAMAR = new System.Windows.Forms.TextBox();
            this.tbCHECKOUT = new System.Windows.Forms.TextBox();
            this.JUMLAHTAMU = new System.Windows.Forms.Label();
            this.tbCHECKIN = new System.Windows.Forms.TextBox();
            this.JUMLAHKAMAR = new System.Windows.Forms.Label();
            this.TIPEKAMAR = new System.Windows.Forms.Label();
            this.CHECKOUT = new System.Windows.Forms.Label();
            this.CHECKIN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.FormDataPembayaran = new System.Windows.Forms.Button();
            this.tbPembayaran = new System.Windows.Forms.TextBox();
            this.TOTALPEMBAYARAN = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.BATAL = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BRI = new System.Windows.Forms.CheckBox();
            this.Mandiri = new System.Windows.Forms.CheckBox();
            this.BCA = new System.Windows.Forms.CheckBox();
            this.OVO = new System.Windows.Forms.CheckBox();
            this.Pembayaran = new System.Windows.Forms.GroupBox();
            this.Gopay = new System.Windows.Forms.CheckBox();
            this.DANA = new System.Windows.Forms.CheckBox();
            this.MetodePembayaran = new System.Windows.Forms.GroupBox();
            this.Emoney = new System.Windows.Forms.RadioButton();
            this.Card = new System.Windows.Forms.RadioButton();
            this.Tunai = new System.Windows.Forms.RadioButton();
            this.PILIHMETODE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.Pembayaran.SuspendLayout();
            this.MetodePembayaran.SuspendLayout();
            this.SuspendLayout();
            // 
            // Perempuan
            // 
            this.Perempuan.AutoSize = true;
            this.Perempuan.Location = new System.Drawing.Point(267, 150);
            this.Perempuan.Name = "Perempuan";
            this.Perempuan.Size = new System.Drawing.Size(79, 17);
            this.Perempuan.TabIndex = 28;
            this.Perempuan.TabStop = true;
            this.Perempuan.Text = "Perempuan";
            this.Perempuan.UseVisualStyleBackColor = true;
            // 
            // Laki
            // 
            this.Laki.AutoSize = true;
            this.Laki.Location = new System.Drawing.Point(192, 150);
            this.Laki.Name = "Laki";
            this.Laki.Size = new System.Drawing.Size(68, 17);
            this.Laki.TabIndex = 27;
            this.Laki.TabStop = true;
            this.Laki.Text = "Laki-Laki";
            this.Laki.UseVisualStyleBackColor = true;
            // 
            // tbEMAIL
            // 
            this.tbEMAIL.Location = new System.Drawing.Point(500, 147);
            this.tbEMAIL.Name = "tbEMAIL";
            this.tbEMAIL.Size = new System.Drawing.Size(100, 20);
            this.tbEMAIL.TabIndex = 26;
            this.tbEMAIL.Leave += new System.EventHandler(this.tbEMAIL_Leave);
            // 
            // tbALAMAT
            // 
            this.tbALAMAT.Location = new System.Drawing.Point(500, 59);
            this.tbALAMAT.Name = "tbALAMAT";
            this.tbALAMAT.Size = new System.Drawing.Size(100, 20);
            this.tbALAMAT.TabIndex = 25;
            this.tbALAMAT.TextChanged += new System.EventHandler(this.tbALAMAT_TextChanged);
            // 
            // tbNOHP
            // 
            this.tbNOHP.Location = new System.Drawing.Point(500, 106);
            this.tbNOHP.Name = "tbNOHP";
            this.tbNOHP.Size = new System.Drawing.Size(100, 20);
            this.tbNOHP.TabIndex = 24;
            this.tbNOHP.TextChanged += new System.EventHandler(this.tbNOHP_TextChanged);
            // 
            // tbNAMA
            // 
            this.tbNAMA.Location = new System.Drawing.Point(192, 106);
            this.tbNAMA.Name = "tbNAMA";
            this.tbNAMA.Size = new System.Drawing.Size(100, 20);
            this.tbNAMA.TabIndex = 23;
            this.tbNAMA.TextChanged += new System.EventHandler(this.tbNAMA_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ALAMAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "EMAIL";
            // 
            // tbNIK
            // 
            this.tbNIK.Location = new System.Drawing.Point(192, 68);
            this.tbNIK.Name = "tbNIK";
            this.tbNIK.Size = new System.Drawing.Size(100, 20);
            this.tbNIK.TabIndex = 20;
            this.tbNIK.TextChanged += new System.EventHandler(this.tbNIK_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "NO HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "JENIS KELAMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "NIK";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 44);
            this.label7.TabIndex = 29;
            this.label7.Text = "FORM DATA DIRI";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDataReservasi
            // 
            this.FormDataReservasi.Location = new System.Drawing.Point(629, 128);
            this.FormDataReservasi.Name = "FormDataReservasi";
            this.FormDataReservasi.Size = new System.Drawing.Size(152, 39);
            this.FormDataReservasi.TabIndex = 30;
            this.FormDataReservasi.Text = "LANJUT ISI FORM DATA RESERVASI";
            this.FormDataReservasi.UseVisualStyleBackColor = true;
            this.FormDataReservasi.Click += new System.EventHandler(this.FormDataReservasi_Click);
            // 
            // tbJUMLAHTAMU
            // 
            this.tbJUMLAHTAMU.Location = new System.Drawing.Point(575, 331);
            this.tbJUMLAHTAMU.Margin = new System.Windows.Forms.Padding(4);
            this.tbJUMLAHTAMU.Name = "tbJUMLAHTAMU";
            this.tbJUMLAHTAMU.Size = new System.Drawing.Size(132, 20);
            this.tbJUMLAHTAMU.TabIndex = 39;
            // 
            // tbJUMLAHKAMAR
            // 
            this.tbJUMLAHKAMAR.Location = new System.Drawing.Point(575, 279);
            this.tbJUMLAHKAMAR.Margin = new System.Windows.Forms.Padding(4);
            this.tbJUMLAHKAMAR.Name = "tbJUMLAHKAMAR";
            this.tbJUMLAHKAMAR.Size = new System.Drawing.Size(132, 20);
            this.tbJUMLAHKAMAR.TabIndex = 38;
            // 
            // tbCHECKOUT
            // 
            this.tbCHECKOUT.Location = new System.Drawing.Point(209, 325);
            this.tbCHECKOUT.Margin = new System.Windows.Forms.Padding(4);
            this.tbCHECKOUT.Name = "tbCHECKOUT";
            this.tbCHECKOUT.Size = new System.Drawing.Size(132, 20);
            this.tbCHECKOUT.TabIndex = 37;
            this.tbCHECKOUT.TextChanged += new System.EventHandler(this.tbCHECKOUT_TextChanged);
            // 
            // JUMLAHTAMU
            // 
            this.JUMLAHTAMU.AutoSize = true;
            this.JUMLAHTAMU.Location = new System.Drawing.Point(415, 334);
            this.JUMLAHTAMU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JUMLAHTAMU.Name = "JUMLAHTAMU";
            this.JUMLAHTAMU.Size = new System.Drawing.Size(84, 13);
            this.JUMLAHTAMU.TabIndex = 36;
            this.JUMLAHTAMU.Text = "JUMLAH TAMU";
            // 
            // tbCHECKIN
            // 
            this.tbCHECKIN.Location = new System.Drawing.Point(209, 279);
            this.tbCHECKIN.Margin = new System.Windows.Forms.Padding(4);
            this.tbCHECKIN.Name = "tbCHECKIN";
            this.tbCHECKIN.Size = new System.Drawing.Size(132, 20);
            this.tbCHECKIN.TabIndex = 35;
            this.tbCHECKIN.TextChanged += new System.EventHandler(this.tbCHECKIN_TextChanged);
            // 
            // JUMLAHKAMAR
            // 
            this.JUMLAHKAMAR.AutoSize = true;
            this.JUMLAHKAMAR.Location = new System.Drawing.Point(415, 282);
            this.JUMLAHKAMAR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JUMLAHKAMAR.Name = "JUMLAHKAMAR";
            this.JUMLAHKAMAR.Size = new System.Drawing.Size(91, 13);
            this.JUMLAHKAMAR.TabIndex = 34;
            this.JUMLAHKAMAR.Text = "JUMLAH KAMAR";
            // 
            // TIPEKAMAR
            // 
            this.TIPEKAMAR.AutoSize = true;
            this.TIPEKAMAR.Location = new System.Drawing.Point(49, 385);
            this.TIPEKAMAR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TIPEKAMAR.Name = "TIPEKAMAR";
            this.TIPEKAMAR.Size = new System.Drawing.Size(72, 13);
            this.TIPEKAMAR.TabIndex = 33;
            this.TIPEKAMAR.Text = "TIPE KAMAR";
            // 
            // CHECKOUT
            // 
            this.CHECKOUT.AutoSize = true;
            this.CHECKOUT.Location = new System.Drawing.Point(49, 334);
            this.CHECKOUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CHECKOUT.Name = "CHECKOUT";
            this.CHECKOUT.Size = new System.Drawing.Size(69, 13);
            this.CHECKOUT.TabIndex = 32;
            this.CHECKOUT.Text = "CHECK OUT";
            // 
            // CHECKIN
            // 
            this.CHECKIN.AutoSize = true;
            this.CHECKIN.Location = new System.Drawing.Point(49, 287);
            this.CHECKIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CHECKIN.Name = "CHECKIN";
            this.CHECKIN.Size = new System.Drawing.Size(57, 13);
            this.CHECKIN.TabIndex = 31;
            this.CHECKIN.Text = "CHECK IN";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 44);
            this.label8.TabIndex = 44;
            this.label8.Text = "FORM DATA RESERVASI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // FormDataPembayaran
            // 
            this.FormDataPembayaran.Location = new System.Drawing.Point(629, 386);
            this.FormDataPembayaran.Name = "FormDataPembayaran";
            this.FormDataPembayaran.Size = new System.Drawing.Size(152, 39);
            this.FormDataPembayaran.TabIndex = 45;
            this.FormDataPembayaran.Text = "LANJUT ISI FORM DATA PEMBAYARAN";
            this.FormDataPembayaran.UseVisualStyleBackColor = true;
            this.FormDataPembayaran.Click += new System.EventHandler(this.FormDataPembayaran_Click);
            // 
            // tbPembayaran
            // 
            this.tbPembayaran.Location = new System.Drawing.Point(45, 572);
            this.tbPembayaran.Margin = new System.Windows.Forms.Padding(4);
            this.tbPembayaran.Name = "tbPembayaran";
            this.tbPembayaran.Size = new System.Drawing.Size(228, 20);
            this.tbPembayaran.TabIndex = 48;
            // 
            // TOTALPEMBAYARAN
            // 
            this.TOTALPEMBAYARAN.AutoSize = true;
            this.TOTALPEMBAYARAN.Location = new System.Drawing.Point(53, 536);
            this.TOTALPEMBAYARAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TOTALPEMBAYARAN.Name = "TOTALPEMBAYARAN";
            this.TOTALPEMBAYARAN.Size = new System.Drawing.Size(119, 13);
            this.TOTALPEMBAYARAN.TabIndex = 46;
            this.TOTALPEMBAYARAN.Text = "TOTAL PEMBAYARAN";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 463);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 44);
            this.label9.TabIndex = 52;
            this.label9.Text = "FORM DATA PEMBAYARAN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SUBMIT
            // 
            this.SUBMIT.Location = new System.Drawing.Point(809, 594);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(100, 39);
            this.SUBMIT.TabIndex = 59;
            this.SUBMIT.Text = "SUBMIT";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // BATAL
            // 
            this.BATAL.Location = new System.Drawing.Point(809, 649);
            this.BATAL.Name = "BATAL";
            this.BATAL.Size = new System.Drawing.Size(100, 39);
            this.BATAL.TabIndex = 63;
            this.BATAL.Text = "BATAL";
            this.BATAL.UseVisualStyleBackColor = true;
            this.BATAL.Click += new System.EventHandler(this.BATAL_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Standar",
            "Superior",
            "Deluxe"});
            this.comboBox1.Location = new System.Drawing.Point(209, 377);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 64;
            // 
            // BRI
            // 
            this.BRI.AutoSize = true;
            this.BRI.Enabled = false;
            this.BRI.Location = new System.Drawing.Point(16, 44);
            this.BRI.Name = "BRI";
            this.BRI.Size = new System.Drawing.Size(44, 17);
            this.BRI.TabIndex = 5;
            this.BRI.Text = "BRI";
            this.BRI.UseVisualStyleBackColor = true;
            // 
            // Mandiri
            // 
            this.Mandiri.AutoSize = true;
            this.Mandiri.Enabled = false;
            this.Mandiri.Location = new System.Drawing.Point(16, 121);
            this.Mandiri.Name = "Mandiri";
            this.Mandiri.Size = new System.Drawing.Size(60, 17);
            this.Mandiri.TabIndex = 6;
            this.Mandiri.Text = "Mandiri";
            this.Mandiri.UseVisualStyleBackColor = true;
            // 
            // BCA
            // 
            this.BCA.AutoSize = true;
            this.BCA.Enabled = false;
            this.BCA.Location = new System.Drawing.Point(16, 82);
            this.BCA.Name = "BCA";
            this.BCA.Size = new System.Drawing.Size(47, 17);
            this.BCA.TabIndex = 7;
            this.BCA.Text = "BCA";
            this.BCA.UseVisualStyleBackColor = true;
            // 
            // OVO
            // 
            this.OVO.AutoSize = true;
            this.OVO.Enabled = false;
            this.OVO.Location = new System.Drawing.Point(127, 44);
            this.OVO.Name = "OVO";
            this.OVO.Size = new System.Drawing.Size(49, 17);
            this.OVO.TabIndex = 8;
            this.OVO.Text = "OVO";
            this.OVO.UseVisualStyleBackColor = true;
            // 
            // Pembayaran
            // 
            this.Pembayaran.Controls.Add(this.Gopay);
            this.Pembayaran.Controls.Add(this.DANA);
            this.Pembayaran.Controls.Add(this.OVO);
            this.Pembayaran.Controls.Add(this.BCA);
            this.Pembayaran.Controls.Add(this.Mandiri);
            this.Pembayaran.Controls.Add(this.BRI);
            this.Pembayaran.Location = new System.Drawing.Point(522, 536);
            this.Pembayaran.Name = "Pembayaran";
            this.Pembayaran.Size = new System.Drawing.Size(242, 152);
            this.Pembayaran.TabIndex = 65;
            this.Pembayaran.TabStop = false;
            this.Pembayaran.Text = "Pembayaran";
            // 
            // Gopay
            // 
            this.Gopay.AutoSize = true;
            this.Gopay.Enabled = false;
            this.Gopay.Location = new System.Drawing.Point(127, 82);
            this.Gopay.Name = "Gopay";
            this.Gopay.Size = new System.Drawing.Size(57, 17);
            this.Gopay.TabIndex = 10;
            this.Gopay.Text = "Gopay";
            this.Gopay.UseVisualStyleBackColor = true;
            // 
            // DANA
            // 
            this.DANA.AutoSize = true;
            this.DANA.Enabled = false;
            this.DANA.Location = new System.Drawing.Point(127, 121);
            this.DANA.Name = "DANA";
            this.DANA.Size = new System.Drawing.Size(56, 17);
            this.DANA.TabIndex = 9;
            this.DANA.Text = "DANA";
            this.DANA.UseVisualStyleBackColor = true;
            // 
            // MetodePembayaran
            // 
            this.MetodePembayaran.Controls.Add(this.Emoney);
            this.MetodePembayaran.Controls.Add(this.Card);
            this.MetodePembayaran.Controls.Add(this.Tunai);
            this.MetodePembayaran.Controls.Add(this.PILIHMETODE);
            this.MetodePembayaran.Location = new System.Drawing.Point(308, 536);
            this.MetodePembayaran.Name = "MetodePembayaran";
            this.MetodePembayaran.Size = new System.Drawing.Size(198, 169);
            this.MetodePembayaran.TabIndex = 62;
            this.MetodePembayaran.TabStop = false;
            this.MetodePembayaran.Text = "PILIH METODE PEMBAYARAN";
            // 
            // Emoney
            // 
            this.Emoney.AutoSize = true;
            this.Emoney.Location = new System.Drawing.Point(32, 124);
            this.Emoney.Margin = new System.Windows.Forms.Padding(4);
            this.Emoney.Name = "Emoney";
            this.Emoney.Size = new System.Drawing.Size(67, 17);
            this.Emoney.TabIndex = 55;
            this.Emoney.TabStop = true;
            this.Emoney.Text = "E-Money";
            this.Emoney.UseVisualStyleBackColor = true;
            this.Emoney.CheckedChanged += new System.EventHandler(this.Emoney_CheckedChanged);
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.Location = new System.Drawing.Point(32, 80);
            this.Card.Margin = new System.Windows.Forms.Padding(4);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(47, 17);
            this.Card.TabIndex = 54;
            this.Card.TabStop = true;
            this.Card.Text = "Card";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.CheckedChanged += new System.EventHandler(this.Card_CheckedChanged);
            // 
            // Tunai
            // 
            this.Tunai.AutoSize = true;
            this.Tunai.Location = new System.Drawing.Point(32, 37);
            this.Tunai.Margin = new System.Windows.Forms.Padding(4);
            this.Tunai.Name = "Tunai";
            this.Tunai.Size = new System.Drawing.Size(52, 17);
            this.Tunai.TabIndex = 53;
            this.Tunai.TabStop = true;
            this.Tunai.Text = "Tunai";
            this.Tunai.UseVisualStyleBackColor = true;
            this.Tunai.CheckedChanged += new System.EventHandler(this.Tunai_CheckedChanged_2);
            // 
            // PILIHMETODE
            // 
            this.PILIHMETODE.AutoSize = true;
            this.PILIHMETODE.Location = new System.Drawing.Point(23, 23);
            this.PILIHMETODE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PILIHMETODE.Name = "PILIHMETODE";
            this.PILIHMETODE.Size = new System.Drawing.Size(0, 13);
            this.PILIHMETODE.TabIndex = 52;
            // 
            // NilaiTambahUTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(986, 765);
            this.Controls.Add(this.MetodePembayaran);
            this.Controls.Add(this.Pembayaran);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BATAL);
            this.Controls.Add(this.SUBMIT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPembayaran);
            this.Controls.Add(this.TOTALPEMBAYARAN);
            this.Controls.Add(this.FormDataPembayaran);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbJUMLAHTAMU);
            this.Controls.Add(this.tbJUMLAHKAMAR);
            this.Controls.Add(this.tbCHECKOUT);
            this.Controls.Add(this.JUMLAHTAMU);
            this.Controls.Add(this.tbCHECKIN);
            this.Controls.Add(this.JUMLAHKAMAR);
            this.Controls.Add(this.TIPEKAMAR);
            this.Controls.Add(this.CHECKOUT);
            this.Controls.Add(this.CHECKIN);
            this.Controls.Add(this.FormDataReservasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Perempuan);
            this.Controls.Add(this.Laki);
            this.Controls.Add(this.tbEMAIL);
            this.Controls.Add(this.tbALAMAT);
            this.Controls.Add(this.tbNOHP);
            this.Controls.Add(this.tbNAMA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNIK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NilaiTambahUTS";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.Pembayaran.ResumeLayout(false);
            this.Pembayaran.PerformLayout();
            this.MetodePembayaran.ResumeLayout(false);
            this.MetodePembayaran.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Perempuan;
        private System.Windows.Forms.RadioButton Laki;
        private System.Windows.Forms.TextBox tbEMAIL;
        private System.Windows.Forms.TextBox tbALAMAT;
        private System.Windows.Forms.TextBox tbNOHP;
        private System.Windows.Forms.TextBox tbNAMA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNIK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button FormDataReservasi;
        private System.Windows.Forms.TextBox tbJUMLAHTAMU;
        private System.Windows.Forms.TextBox tbJUMLAHKAMAR;
        private System.Windows.Forms.TextBox tbCHECKOUT;
        private System.Windows.Forms.Label JUMLAHTAMU;
        private System.Windows.Forms.TextBox tbCHECKIN;
        private System.Windows.Forms.Label JUMLAHKAMAR;
        private System.Windows.Forms.Label TIPEKAMAR;
        private System.Windows.Forms.Label CHECKOUT;
        private System.Windows.Forms.Label CHECKIN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Button FormDataPembayaran;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPembayaran;
        private System.Windows.Forms.Label TOTALPEMBAYARAN;
        private System.Windows.Forms.Button SUBMIT;
        private System.Windows.Forms.Button BATAL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox Pembayaran;
        private System.Windows.Forms.CheckBox Gopay;
        private System.Windows.Forms.CheckBox DANA;
        private System.Windows.Forms.CheckBox OVO;
        private System.Windows.Forms.CheckBox BCA;
        private System.Windows.Forms.CheckBox Mandiri;
        private System.Windows.Forms.CheckBox BRI;
        private System.Windows.Forms.GroupBox MetodePembayaran;
        private System.Windows.Forms.RadioButton Emoney;
        private System.Windows.Forms.RadioButton Card;
        private System.Windows.Forms.RadioButton Tunai;
        private System.Windows.Forms.Label PILIHMETODE;
    }
}

