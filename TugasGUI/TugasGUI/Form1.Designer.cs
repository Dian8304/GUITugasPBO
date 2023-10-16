namespace TugasGUI
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_TambahPasien = new System.Windows.Forms.Button();
            this.lbl_Judul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_TambahPasien
            // 
            this.btn_TambahPasien.Location = new System.Drawing.Point(654, 377);
            this.btn_TambahPasien.Name = "btn_TambahPasien";
            this.btn_TambahPasien.Size = new System.Drawing.Size(134, 31);
            this.btn_TambahPasien.TabIndex = 1;
            this.btn_TambahPasien.Text = "Tambah Pasien";
            this.btn_TambahPasien.UseVisualStyleBackColor = true;
            this.btn_TambahPasien.Click += new System.EventHandler(this.btn_TambahPasien_Click);
            // 
            // lbl_Judul
            // 
            this.lbl_Judul.AutoSize = true;
            this.lbl_Judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Judul.Location = new System.Drawing.Point(215, 9);
            this.lbl_Judul.Name = "lbl_Judul";
            this.lbl_Judul.Size = new System.Drawing.Size(393, 52);
            this.lbl_Judul.TabIndex = 2;
            this.lbl_Judul.Text = "Daftar Pasien IGD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Judul);
            this.Controls.Add(this.btn_TambahPasien);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_TambahPasien;
        private System.Windows.Forms.Label lbl_Judul;
    }
}

