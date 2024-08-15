namespace kumbara1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblKumbaraDurum = new System.Windows.Forms.Label();
            lblParaIsmi = new System.Windows.Forms.Label();
            lblParaDegeri = new System.Windows.Forms.Label();
            lblHataMesajı = new System.Windows.Forms.Label();
            txtKumbaraHacmi = new System.Windows.Forms.TextBox();
            btnParaEkle = new System.Windows.Forms.Button();
            btnKumbaraKır = new System.Windows.Forms.Button();
            btnShake = new System.Windows.Forms.Button();
            lstParalar = new System.Windows.Forms.ListBox();
            grpKumbaraBilgileri = new System.Windows.Forms.GroupBox();
            grpParaEkle = new System.Windows.Forms.GroupBox();
            cmbParaSec = new System.Windows.Forms.ComboBox();
            pnlKumbara = new System.Windows.Forms.Panel();
            grpParaEkle.SuspendLayout();
            pnlKumbara.SuspendLayout();
            SuspendLayout();
            // 
            // lblKumbaraDurum
            // 
            lblKumbaraDurum.AutoSize = true;
            lblKumbaraDurum.Location = new System.Drawing.Point(63, 45);
            lblKumbaraDurum.Name = "lblKumbaraDurum";
            lblKumbaraDurum.Size = new System.Drawing.Size(176, 25);
            lblKumbaraDurum.TabIndex = 0;
            lblKumbaraDurum.Text = "KUMBARA DURUMU";
            lblKumbaraDurum.Click += label1_Click_1;
            // 
            // lblParaIsmi
            // 
            lblParaIsmi.AutoSize = true;
            lblParaIsmi.Location = new System.Drawing.Point(63, 83);
            lblParaIsmi.Name = "lblParaIsmi";
            lblParaIsmi.Size = new System.Drawing.Size(97, 25);
            lblParaIsmi.TabIndex = 1;
            lblParaIsmi.Text = "PARA İSMİ";
            // 
            // lblParaDegeri
            // 
            lblParaDegeri.AutoSize = true;
            lblParaDegeri.Location = new System.Drawing.Point(63, 122);
            lblParaDegeri.Name = "lblParaDegeri";
            lblParaDegeri.Size = new System.Drawing.Size(120, 25);
            lblParaDegeri.TabIndex = 2;
            lblParaDegeri.Text = "PARA DEĞERİ";
            // 
            // lblHataMesajı
            // 
            lblHataMesajı.AutoSize = true;
            lblHataMesajı.Location = new System.Drawing.Point(63, 160);
            lblHataMesajı.Name = "lblHataMesajı";
            lblHataMesajı.Size = new System.Drawing.Size(120, 25);
            lblHataMesajı.TabIndex = 3;
            lblHataMesajı.Text = "HATA MESAJI";
            // 
            // txtKumbaraHacmi
            // 
            txtKumbaraHacmi.Location = new System.Drawing.Point(302, 160);
            txtKumbaraHacmi.Name = "txtKumbaraHacmi";
            txtKumbaraHacmi.Size = new System.Drawing.Size(150, 31);
            txtKumbaraHacmi.TabIndex = 6;
            txtKumbaraHacmi.TextChanged += txtKumbaraHacmi_TextChanged;
            // 
            // btnParaEkle
            // 
            btnParaEkle.Location = new System.Drawing.Point(23, 30);
            btnParaEkle.Name = "btnParaEkle";
            btnParaEkle.Size = new System.Drawing.Size(182, 34);
            btnParaEkle.TabIndex = 7;
            btnParaEkle.Text = "PARA EKLE";
            btnParaEkle.UseVisualStyleBackColor = true;
            // 
            // btnKumbaraKır
            // 
            btnKumbaraKır.Location = new System.Drawing.Point(24, 95);
            btnKumbaraKır.Name = "btnKumbaraKır";
            btnKumbaraKır.Size = new System.Drawing.Size(134, 83);
            btnKumbaraKır.TabIndex = 8;
            btnKumbaraKır.Text = "KUMBARA KIR";
            btnKumbaraKır.UseVisualStyleBackColor = true;
            // 
            // btnShake
            // 
            btnShake.Location = new System.Drawing.Point(164, 95);
            btnShake.Name = "btnShake";
            btnShake.Size = new System.Drawing.Size(156, 83);
            btnShake.TabIndex = 9;
            btnShake.Text = "KUMBARAYI SALLA";
            btnShake.UseVisualStyleBackColor = true;
            // 
            // lstParalar
            // 
            lstParalar.FormattingEnabled = true;
            lstParalar.ItemHeight = 25;
            lstParalar.Location = new System.Drawing.Point(40, 245);
            lstParalar.Name = "lstParalar";
            lstParalar.Size = new System.Drawing.Size(180, 129);
            lstParalar.TabIndex = 10;
            // 
            // grpKumbaraBilgileri
            // 
            grpKumbaraBilgileri.Location = new System.Drawing.Point(83, 14);
            grpKumbaraBilgileri.Name = "grpKumbaraBilgileri";
            grpKumbaraBilgileri.Size = new System.Drawing.Size(188, 63);
            grpKumbaraBilgileri.TabIndex = 11;
            grpKumbaraBilgileri.TabStop = false;
            grpKumbaraBilgileri.Text = "KUMBARA BİLGİLERİ";
            // 
            // grpParaEkle
            // 
            grpParaEkle.Controls.Add(cmbParaSec);
            grpParaEkle.Controls.Add(btnParaEkle);
            grpParaEkle.Location = new System.Drawing.Point(526, 193);
            grpParaEkle.Name = "grpParaEkle";
            grpParaEkle.Size = new System.Drawing.Size(245, 147);
            grpParaEkle.TabIndex = 12;
            grpParaEkle.TabStop = false;
            grpParaEkle.Text = "PARA BİLGİLERİ";
            // 
            // cmbParaSec
            // 
            cmbParaSec.FormattingEnabled = true;
            cmbParaSec.Location = new System.Drawing.Point(23, 79);
            cmbParaSec.Name = "cmbParaSec";
            cmbParaSec.Size = new System.Drawing.Size(182, 33);
            cmbParaSec.TabIndex = 14;
            // 
            // pnlKumbara
            // 
            pnlKumbara.Controls.Add(btnShake);
            pnlKumbara.Controls.Add(grpKumbaraBilgileri);
            pnlKumbara.Controls.Add(btnKumbaraKır);
            pnlKumbara.Location = new System.Drawing.Point(411, 383);
            pnlKumbara.Name = "pnlKumbara";
            pnlKumbara.Size = new System.Drawing.Size(360, 181);
            pnlKumbara.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(821, 702);
            Controls.Add(pnlKumbara);
            Controls.Add(grpParaEkle);
            Controls.Add(lstParalar);
            Controls.Add(txtKumbaraHacmi);
            Controls.Add(lblHataMesajı);
            Controls.Add(lblParaDegeri);
            Controls.Add(lblParaIsmi);
            Controls.Add(lblKumbaraDurum);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            grpParaEkle.ResumeLayout(false);
            pnlKumbara.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblKumbaraDurum;
        private System.Windows.Forms.Label lblParaIsmi;
        private System.Windows.Forms.Label lblParaDegeri;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtYükseklik;
        private System.Windows.Forms.Label lblHataMesajı;
        private System.Windows.Forms.TextBox txtParaIsmi;
        private System.Windows.Forms.TextBox txtParaDegeri;
        private System.Windows.Forms.TextBox txtKumbaraHacmi;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.Button btnKumbaraKır;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.ListBox lstParalar;
        private System.Windows.Forms.GroupBox grpKumbaraBilgileri;
        private System.Windows.Forms.GroupBox grpParaEkle;
        private System.Windows.Forms.Panel pnlKumbara;
        private System.Windows.Forms.ComboBox cmbParaSec;
    }
}