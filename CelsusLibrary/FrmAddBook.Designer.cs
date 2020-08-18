namespace CelsusLibrary
{
    partial class FrmAddBook
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
            this.BoxAddBook = new System.Windows.Forms.GroupBox();
            this.LblBookBringer = new System.Windows.Forms.Label();
            this.BoxBookBringer = new System.Windows.Forms.TextBox();
            this.LblEntrDate = new System.Windows.Forms.Label();
            this.LblBookLang = new System.Windows.Forms.Label();
            this.BoxBookLang = new System.Windows.Forms.TextBox();
            this.LblPrintDate = new System.Windows.Forms.Label();
            this.LblBookType = new System.Windows.Forms.Label();
            this.LblWriteSurname = new System.Windows.Forms.Label();
            this.LblWriterName = new System.Windows.Forms.Label();
            this.LblBookName = new System.Windows.Forms.Label();
            this.BoxBookName = new System.Windows.Forms.TextBox();
            this.BoxPrintDate = new System.Windows.Forms.TextBox();
            this.BoxWriterSurname = new System.Windows.Forms.TextBox();
            this.BoxBookType = new System.Windows.Forms.TextBox();
            this.BoxWriterName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BoxEntryDate = new System.Windows.Forms.DateTimePicker();
            this.BoxAddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxAddBook
            // 
            this.BoxAddBook.Controls.Add(this.BoxEntryDate);
            this.BoxAddBook.Controls.Add(this.LblBookBringer);
            this.BoxAddBook.Controls.Add(this.BoxBookBringer);
            this.BoxAddBook.Controls.Add(this.LblEntrDate);
            this.BoxAddBook.Controls.Add(this.LblBookLang);
            this.BoxAddBook.Controls.Add(this.BoxBookLang);
            this.BoxAddBook.Controls.Add(this.LblPrintDate);
            this.BoxAddBook.Controls.Add(this.LblBookType);
            this.BoxAddBook.Controls.Add(this.LblWriteSurname);
            this.BoxAddBook.Controls.Add(this.LblWriterName);
            this.BoxAddBook.Controls.Add(this.LblBookName);
            this.BoxAddBook.Controls.Add(this.BoxBookName);
            this.BoxAddBook.Controls.Add(this.BoxPrintDate);
            this.BoxAddBook.Controls.Add(this.BoxWriterSurname);
            this.BoxAddBook.Controls.Add(this.BoxBookType);
            this.BoxAddBook.Controls.Add(this.BoxWriterName);
            this.BoxAddBook.Controls.Add(this.BtnSave);
            this.BoxAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAddBook.Location = new System.Drawing.Point(253, 94);
            this.BoxAddBook.Name = "BoxAddBook";
            this.BoxAddBook.Size = new System.Drawing.Size(971, 925);
            this.BoxAddBook.TabIndex = 0;
            this.BoxAddBook.TabStop = false;
            this.BoxAddBook.Text = "Kitap Ekle";
            // 
            // LblBookBringer
            // 
            this.LblBookBringer.AutoSize = true;
            this.LblBookBringer.Location = new System.Drawing.Point(22, 687);
            this.LblBookBringer.Name = "LblBookBringer";
            this.LblBookBringer.Size = new System.Drawing.Size(386, 38);
            this.LblBookBringer.TabIndex = 16;
            this.LblBookBringer.Text = "Kitap Bize Kimden Geldi?";
            // 
            // BoxBookBringer
            // 
            this.BoxBookBringer.Location = new System.Drawing.Point(439, 682);
            this.BoxBookBringer.Name = "BoxBookBringer";
            this.BoxBookBringer.Size = new System.Drawing.Size(446, 44);
            this.BoxBookBringer.TabIndex = 15;
            // 
            // LblEntrDate
            // 
            this.LblEntrDate.AutoSize = true;
            this.LblEntrDate.Location = new System.Drawing.Point(22, 596);
            this.LblEntrDate.Name = "LblEntrDate";
            this.LblEntrDate.Size = new System.Drawing.Size(333, 38);
            this.LblEntrDate.TabIndex = 14;
            this.LblEntrDate.Text = "Envantere Giriş Tarihi";
            // 
            // LblBookLang
            // 
            this.LblBookLang.AutoSize = true;
            this.LblBookLang.Location = new System.Drawing.Point(22, 512);
            this.LblBookLang.Name = "LblBookLang";
            this.LblBookLang.Size = new System.Drawing.Size(145, 38);
            this.LblBookLang.TabIndex = 12;
            this.LblBookLang.Text = "Kitap Dili";
            // 
            // BoxBookLang
            // 
            this.BoxBookLang.Location = new System.Drawing.Point(252, 506);
            this.BoxBookLang.Name = "BoxBookLang";
            this.BoxBookLang.Size = new System.Drawing.Size(633, 44);
            this.BoxBookLang.TabIndex = 11;
            // 
            // LblPrintDate
            // 
            this.LblPrintDate.AutoSize = true;
            this.LblPrintDate.Location = new System.Drawing.Point(22, 423);
            this.LblPrintDate.Name = "LblPrintDate";
            this.LblPrintDate.Size = new System.Drawing.Size(198, 38);
            this.LblPrintDate.TabIndex = 10;
            this.LblPrintDate.Text = "Basım Tarihi";
            // 
            // LblBookType
            // 
            this.LblBookType.AutoSize = true;
            this.LblBookType.Location = new System.Drawing.Point(22, 336);
            this.LblBookType.Name = "LblBookType";
            this.LblBookType.Size = new System.Drawing.Size(167, 38);
            this.LblBookType.TabIndex = 9;
            this.LblBookType.Text = "Kitap Türü";
            // 
            // LblWriteSurname
            // 
            this.LblWriteSurname.AutoSize = true;
            this.LblWriteSurname.Location = new System.Drawing.Point(22, 255);
            this.LblWriteSurname.Name = "LblWriteSurname";
            this.LblWriteSurname.Size = new System.Drawing.Size(212, 38);
            this.LblWriteSurname.TabIndex = 8;
            this.LblWriteSurname.Text = "Yazar Soyadı";
            // 
            // LblWriterName
            // 
            this.LblWriterName.AutoSize = true;
            this.LblWriterName.Location = new System.Drawing.Point(22, 175);
            this.LblWriterName.Name = "LblWriterName";
            this.LblWriterName.Size = new System.Drawing.Size(159, 38);
            this.LblWriterName.TabIndex = 7;
            this.LblWriterName.Text = "Yazar Adı";
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Location = new System.Drawing.Point(22, 86);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(147, 38);
            this.LblBookName.TabIndex = 6;
            this.LblBookName.Text = "Kitap Adı";
            // 
            // BoxBookName
            // 
            this.BoxBookName.Location = new System.Drawing.Point(252, 81);
            this.BoxBookName.Name = "BoxBookName";
            this.BoxBookName.Size = new System.Drawing.Size(633, 44);
            this.BoxBookName.TabIndex = 5;
            this.BoxBookName.TextChanged += new System.EventHandler(this.BoxBookName_TextChanged);
            // 
            // BoxPrintDate
            // 
            this.BoxPrintDate.Location = new System.Drawing.Point(252, 418);
            this.BoxPrintDate.Name = "BoxPrintDate";
            this.BoxPrintDate.Size = new System.Drawing.Size(633, 44);
            this.BoxPrintDate.TabIndex = 4;
            // 
            // BoxWriterSurname
            // 
            this.BoxWriterSurname.Location = new System.Drawing.Point(252, 250);
            this.BoxWriterSurname.Name = "BoxWriterSurname";
            this.BoxWriterSurname.Size = new System.Drawing.Size(633, 44);
            this.BoxWriterSurname.TabIndex = 3;
            // 
            // BoxBookType
            // 
            this.BoxBookType.Location = new System.Drawing.Point(252, 330);
            this.BoxBookType.Name = "BoxBookType";
            this.BoxBookType.Size = new System.Drawing.Size(633, 44);
            this.BoxBookType.TabIndex = 2;
            // 
            // BoxWriterName
            // 
            this.BoxWriterName.Location = new System.Drawing.Point(252, 169);
            this.BoxWriterName.Name = "BoxWriterName";
            this.BoxWriterName.Size = new System.Drawing.Size(633, 44);
            this.BoxWriterName.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(679, 780);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(205, 105);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BoxEntryDate
            // 
            this.BoxEntryDate.Location = new System.Drawing.Point(363, 590);
            this.BoxEntryDate.Name = "BoxEntryDate";
            this.BoxEntryDate.Size = new System.Drawing.Size(522, 44);
            this.BoxEntryDate.TabIndex = 17;
            this.BoxEntryDate.ValueChanged += new System.EventHandler(this.BoxEntryDate_ValueChanged);
            // 
            // FrmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 1124);
            this.Controls.Add(this.BoxAddBook);
            this.Name = "FrmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.BoxAddBook.ResumeLayout(false);
            this.BoxAddBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxAddBook;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.TextBox BoxBookName;
        private System.Windows.Forms.TextBox BoxPrintDate;
        private System.Windows.Forms.TextBox BoxWriterSurname;
        private System.Windows.Forms.TextBox BoxBookType;
        private System.Windows.Forms.TextBox BoxWriterName;
        private System.Windows.Forms.Label LblPrintDate;
        private System.Windows.Forms.Label LblBookType;
        private System.Windows.Forms.Label LblWriteSurname;
        private System.Windows.Forms.Label LblWriterName;
        private System.Windows.Forms.Label LblEntrDate;
        private System.Windows.Forms.Label LblBookLang;
        private System.Windows.Forms.TextBox BoxBookLang;
        private System.Windows.Forms.Label LblBookBringer;
        private System.Windows.Forms.TextBox BoxBookBringer;
        private System.Windows.Forms.DateTimePicker BoxEntryDate;
    }
}