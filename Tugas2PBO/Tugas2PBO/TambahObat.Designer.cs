namespace Tugas2PBO
{
    partial class TambahObat
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
            lbl_Judul = new Label();
            lbl_Nama = new Label();
            lbl_FungsiObat = new Label();
            lbl_Harga = new Label();
            txb_NamaObat = new TextBox();
            txb_Fungsi = new TextBox();
            txb_Harga = new TextBox();
            btn_Tambah = new Button();
            btn_Batal = new Button();
            SuspendLayout();
            // 
            // lbl_Judul
            // 
            lbl_Judul.AutoSize = true;
            lbl_Judul.Font = new Font("Franklin Gothic Medium Cond", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Judul.Location = new Point(247, 9);
            lbl_Judul.Name = "lbl_Judul";
            lbl_Judul.Size = new Size(311, 47);
            lbl_Judul.TabIndex = 0;
            lbl_Judul.Text = "Tambah Daftar Obat";
            // 
            // lbl_Nama
            // 
            lbl_Nama.AutoSize = true;
            lbl_Nama.Location = new Point(47, 86);
            lbl_Nama.Name = "lbl_Nama";
            lbl_Nama.Size = new Size(104, 25);
            lbl_Nama.TabIndex = 1;
            lbl_Nama.Text = "Nama Obat";
            lbl_Nama.Click += lbl_Nama_Click;
            // 
            // lbl_FungsiObat
            // 
            lbl_FungsiObat.AutoSize = true;
            lbl_FungsiObat.Location = new Point(47, 134);
            lbl_FungsiObat.Name = "lbl_FungsiObat";
            lbl_FungsiObat.Size = new Size(109, 25);
            lbl_FungsiObat.TabIndex = 2;
            lbl_FungsiObat.Text = "Fungsi Obat";
            // 
            // lbl_Harga
            // 
            lbl_Harga.AutoSize = true;
            lbl_Harga.Location = new Point(47, 181);
            lbl_Harga.Name = "lbl_Harga";
            lbl_Harga.Size = new Size(105, 25);
            lbl_Harga.TabIndex = 3;
            lbl_Harga.Text = "Harga Obat";
            // 
            // txb_NamaObat
            // 
            txb_NamaObat.Location = new Point(184, 80);
            txb_NamaObat.Name = "txb_NamaObat";
            txb_NamaObat.Size = new Size(225, 31);
            txb_NamaObat.TabIndex = 4;
            txb_NamaObat.TextChanged += txb_NamaObat_TextChanged;
            // 
            // txb_Fungsi
            // 
            txb_Fungsi.Location = new Point(184, 128);
            txb_Fungsi.Name = "txb_Fungsi";
            txb_Fungsi.Size = new Size(282, 31);
            txb_Fungsi.TabIndex = 5;
            txb_Fungsi.TextChanged += txb_Fungsi_TextChanged;
            // 
            // txb_Harga
            // 
            txb_Harga.Location = new Point(184, 175);
            txb_Harga.Name = "txb_Harga";
            txb_Harga.Size = new Size(146, 31);
            txb_Harga.TabIndex = 6;
            txb_Harga.TextChanged += txb_Harga_TextChanged;
            // 
            // btn_Tambah
            // 
            btn_Tambah.Location = new Point(571, 241);
            btn_Tambah.Name = "btn_Tambah";
            btn_Tambah.Size = new Size(86, 34);
            btn_Tambah.TabIndex = 7;
            btn_Tambah.Text = "Tambah";
            btn_Tambah.UseVisualStyleBackColor = true;
            btn_Tambah.Click += btn_Tambah_Click;
            // 
            // btn_Batal
            // 
            btn_Batal.Location = new Point(663, 241);
            btn_Batal.Name = "btn_Batal";
            btn_Batal.Size = new Size(86, 34);
            btn_Batal.TabIndex = 8;
            btn_Batal.Text = "Batal";
            btn_Batal.UseVisualStyleBackColor = true;
            btn_Batal.Click += btn_Batal_Click;
            // 
            // TambahObat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Batal);
            Controls.Add(btn_Tambah);
            Controls.Add(txb_Harga);
            Controls.Add(txb_Fungsi);
            Controls.Add(txb_NamaObat);
            Controls.Add(lbl_Harga);
            Controls.Add(lbl_FungsiObat);
            Controls.Add(lbl_Nama);
            Controls.Add(lbl_Judul);
            Name = "TambahObat";
            Text = "TambahObat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Judul;
        private Label lbl_Nama;
        private Label lbl_FungsiObat;
        private Label lbl_Harga;
        private TextBox txb_NamaObat;
        private TextBox txb_Fungsi;
        private TextBox txb_Harga;
        private Button btn_Tambah;
        private Button btn_Batal;
    }
}