namespace Sistem_Pengelolaan_Inventaris_Obat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelDaftarObat = new DataGridView();
            Nama = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            textBoxNama = new TextBox();
            textBoxJumlah = new TextBox();
            textBoxHarga = new TextBox();
            btnSubmit = new Button();
            labelNama = new Label();
            label1 = new Label();
            label2 = new Label();
            textPencarian = new TextBox();
            btnCari = new Button();
            ((System.ComponentModel.ISupportInitialize)tabelDaftarObat).BeginInit();
            SuspendLayout();
            // 
            // tabelDaftarObat
            // 
            tabelDaftarObat.AllowUserToAddRows = false;
            tabelDaftarObat.AllowUserToDeleteRows = false;
            tabelDaftarObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelDaftarObat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            tabelDaftarObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelDaftarObat.Columns.AddRange(new DataGridViewColumn[] { Nama, Jumlah, Harga });
            tabelDaftarObat.Location = new Point(-4, 150);
            tabelDaftarObat.Name = "tabelDaftarObat";
            tabelDaftarObat.ReadOnly = true;
            tabelDaftarObat.Size = new Size(809, 305);
            tabelDaftarObat.TabIndex = 0;
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Obat";
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            // 
            // Jumlah
            // 
            Jumlah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jumlah.HeaderText = "Jumlah";
            Jumlah.Name = "Jumlah";
            Jumlah.ReadOnly = true;
            // 
            // Harga
            // 
            Harga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Harga.HeaderText = "Harga";
            Harga.Name = "Harga";
            Harga.ReadOnly = true;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(86, 43);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(100, 23);
            textBoxNama.TabIndex = 1;
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(86, 73);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(100, 23);
            textBoxJumlah.TabIndex = 3;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(86, 102);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(100, 23);
            textBoxHarga.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(202, 102);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(12, 46);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(68, 15);
            labelNama.TabIndex = 6;
            labelNama.Text = "Nama Obat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Jumlah";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Harga";
            label2.UseWaitCursor = true;
            // 
            // textPencarian
            // 
            textPencarian.Location = new Point(348, 101);
            textPencarian.Name = "textPencarian";
            textPencarian.Size = new Size(142, 23);
            textPencarian.TabIndex = 9;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(496, 101);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(75, 23);
            btnCari.TabIndex = 10;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(btnCari);
            Controls.Add(textPencarian);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelNama);
            Controls.Add(btnSubmit);
            Controls.Add(textBoxHarga);
            Controls.Add(textBoxJumlah);
            Controls.Add(textBoxNama);
            Controls.Add(tabelDaftarObat);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tabelDaftarObat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabelDaftarObat;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn Harga;
        private TextBox textBoxNama;
        private TextBox textBoxJumlah;
        private TextBox textBoxHarga;
        private Button btnSubmit;
        private Label labelNama;
        private Label label1;
        private Label label2;
        private TextBox textPencarian;
        private Button btnCari;
    }
}
