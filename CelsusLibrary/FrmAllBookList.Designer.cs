namespace CelsusLibrary
{
    partial class FrmAllBookList
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
            this.grdAllBooksList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKitapKonusu = new System.Windows.Forms.RadioButton();
            this.btnYazarAdi = new System.Windows.Forms.RadioButton();
            this.aramaBox = new System.Windows.Forms.TextBox();
            this.btnYazarSoyad = new System.Windows.Forms.RadioButton();
            this.kitapAd = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllBooksList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdAllBooksList
            // 
            this.grdAllBooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAllBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllBooksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAllBooksList.Location = new System.Drawing.Point(0, 0);
            this.grdAllBooksList.MultiSelect = false;
            this.grdAllBooksList.Name = "grdAllBooksList";
            this.grdAllBooksList.ReadOnly = true;
            this.grdAllBooksList.RowHeadersVisible = false;
            this.grdAllBooksList.RowHeadersWidth = 82;
            this.grdAllBooksList.RowTemplate.Height = 33;
            this.grdAllBooksList.Size = new System.Drawing.Size(1853, 875);
            this.grdAllBooksList.TabIndex = 0;
            this.grdAllBooksList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllBooksList_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKitapKonusu);
            this.groupBox1.Controls.Add(this.btnYazarAdi);
            this.groupBox1.Controls.Add(this.aramaBox);
            this.groupBox1.Controls.Add(this.btnYazarSoyad);
            this.groupBox1.Controls.Add(this.kitapAd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1853, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Arama";
            // 
            // btnKitapKonusu
            // 
            this.btnKitapKonusu.AutoSize = true;
            this.btnKitapKonusu.Location = new System.Drawing.Point(880, 63);
            this.btnKitapKonusu.Name = "btnKitapKonusu";
            this.btnKitapKonusu.Size = new System.Drawing.Size(233, 36);
            this.btnKitapKonusu.TabIndex = 6;
            this.btnKitapKonusu.Text = "Kitabın Konusu";
            this.btnKitapKonusu.UseVisualStyleBackColor = true;
            this.btnKitapKonusu.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnYazarAdi
            // 
            this.btnYazarAdi.AutoSize = true;
            this.btnYazarAdi.Location = new System.Drawing.Point(294, 63);
            this.btnYazarAdi.Name = "btnYazarAdi";
            this.btnYazarAdi.Size = new System.Drawing.Size(163, 36);
            this.btnYazarAdi.TabIndex = 5;
            this.btnYazarAdi.Text = "Yazar Adı";
            this.btnYazarAdi.UseVisualStyleBackColor = true;
            // 
            // aramaBox
            // 
            this.aramaBox.Location = new System.Drawing.Point(30, 149);
            this.aramaBox.Name = "aramaBox";
            this.aramaBox.Size = new System.Drawing.Size(1175, 39);
            this.aramaBox.TabIndex = 4;
            // 
            // btnYazarSoyad
            // 
            this.btnYazarSoyad.AutoSize = true;
            this.btnYazarSoyad.Location = new System.Drawing.Point(572, 63);
            this.btnYazarSoyad.Name = "btnYazarSoyad";
            this.btnYazarSoyad.Size = new System.Drawing.Size(209, 36);
            this.btnYazarSoyad.TabIndex = 1;
            this.btnYazarSoyad.Text = "Yazar Soyadı";
            this.btnYazarSoyad.UseVisualStyleBackColor = true;
            this.btnYazarSoyad.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // kitapAd
            // 
            this.kitapAd.AutoSize = true;
            this.kitapAd.Checked = true;
            this.kitapAd.Location = new System.Drawing.Point(30, 63);
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.Size = new System.Drawing.Size(155, 36);
            this.kitapAd.TabIndex = 0;
            this.kitapAd.TabStop = true;
            this.kitapAd.Text = "Kitap Adı";
            this.kitapAd.UseVisualStyleBackColor = true;
            this.kitapAd.CheckedChanged += new System.EventHandler(this.btnKitapAdi);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdAllBooksList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1853, 875);
            this.panel1.TabIndex = 6;
            // 
            // FrmAllBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 1118);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAllBookList";
            this.Text = "FrmAllBookList";
            this.Load += new System.EventHandler(this.FrmAllBookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllBooksList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAllBooksList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kitapAd;
        private System.Windows.Forms.RadioButton btnYazarAdi;
        private System.Windows.Forms.TextBox aramaBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnKitapKonusu;
        private System.Windows.Forms.RadioButton btnYazarSoyad;
    }
}