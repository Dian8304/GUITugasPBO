namespace TugasGUI
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
            this.lbl_Judul = new System.Windows.Forms.Label();
            this.lbl_Nama = new System.Windows.Forms.Label();
            this.lbl_TglLahir = new System.Windows.Forms.Label();
            this.lbl_Alamat = new System.Windows.Forms.Label();
            this.btn_Batal = new System.Windows.Forms.Button();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.txb_Nama = new System.Windows.Forms.TextBox();
            this.txb2_Alamat = new System.Windows.Forms.TextBox();
            this.dtime_TglLahir = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_Judul
            // 
            this.lbl_Judul.AutoSize = true;
            this.lbl_Judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Judul.Location = new System.Drawing.Point(271, 9);
            this.lbl_Judul.Name = "lbl_Judul";
            this.lbl_Judul.Size = new System.Drawing.Size(270, 52);
            this.lbl_Judul.TabIndex = 0;
            this.lbl_Judul.Text = "Data Pasien";
            this.lbl_Judul.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Nama
            // 
            this.lbl_Nama.AutoSize = true;
            this.lbl_Nama.Location = new System.Drawing.Point(45, 96);
            this.lbl_Nama.Name = "lbl_Nama";
            this.lbl_Nama.Size = new System.Drawing.Size(51, 20);
            this.lbl_Nama.TabIndex = 1;
            this.lbl_Nama.Text = "Nama";
            // 
            // lbl_TglLahir
            // 
            this.lbl_TglLahir.AutoSize = true;
            this.lbl_TglLahir.Location = new System.Drawing.Point(45, 150);
            this.lbl_TglLahir.Name = "lbl_TglLahir";
            this.lbl_TglLahir.Size = new System.Drawing.Size(105, 20);
            this.lbl_TglLahir.TabIndex = 2;
            this.lbl_TglLahir.Text = "Tanggal Lahir";
            // 
            // lbl_Alamat
            // 
            this.lbl_Alamat.AutoSize = true;
            this.lbl_Alamat.Location = new System.Drawing.Point(45, 203);
            this.lbl_Alamat.Name = "lbl_Alamat";
            this.lbl_Alamat.Size = new System.Drawing.Size(59, 20);
            this.lbl_Alamat.TabIndex = 3;
            this.lbl_Alamat.Text = "Alamat";
            // 
            // btn_Batal
            // 
            this.btn_Batal.Location = new System.Drawing.Point(542, 258);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(75, 35);
            this.btn_Batal.TabIndex = 5;
            this.btn_Batal.Text = "Batal";
            this.btn_Batal.UseVisualStyleBackColor = true;
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Location = new System.Drawing.Point(623, 258);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(75, 35);
            this.btn_Simpan.TabIndex = 6;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = true;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // txb_Nama
            // 
            this.txb_Nama.Location = new System.Drawing.Point(182, 90);
            this.txb_Nama.Name = "txb_Nama";
            this.txb_Nama.Size = new System.Drawing.Size(226, 26);
            this.txb_Nama.TabIndex = 7;
            this.txb_Nama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb2_Alamat
            // 
            this.txb2_Alamat.Location = new System.Drawing.Point(182, 197);
            this.txb2_Alamat.Name = "txb2_Alamat";
            this.txb2_Alamat.Size = new System.Drawing.Size(258, 26);
            this.txb2_Alamat.TabIndex = 8;
            this.txb2_Alamat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dtime_TglLahir
            // 
            this.dtime_TglLahir.Location = new System.Drawing.Point(182, 144);
            this.dtime_TglLahir.Name = "dtime_TglLahir";
            this.dtime_TglLahir.Size = new System.Drawing.Size(275, 26);
            this.dtime_TglLahir.TabIndex = 9;
            this.dtime_TglLahir.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtime_TglLahir);
            this.Controls.Add(this.txb2_Alamat);
            this.Controls.Add(this.txb_Nama);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.lbl_Alamat);
            this.Controls.Add(this.lbl_TglLahir);
            this.Controls.Add(this.lbl_Nama);
            this.Controls.Add(this.lbl_Judul);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Judul;
        private System.Windows.Forms.Label lbl_Nama;
        private System.Windows.Forms.Label lbl_TglLahir;
        private System.Windows.Forms.Label lbl_Alamat;
        private System.Windows.Forms.Button btn_Batal;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.TextBox txb_Nama;
        private System.Windows.Forms.TextBox txb2_Alamat;
        private System.Windows.Forms.DateTimePicker dtime_TglLahir;
    }
}