namespace Tugas2PBO
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
            lbl_Judul = new Label();
            dataGridView1 = new DataGridView();
            btn_Tambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Judul
            // 
            lbl_Judul.AutoSize = true;
            lbl_Judul.Font = new Font("Franklin Gothic Medium Cond", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Judul.Location = new Point(226, 9);
            lbl_Judul.Name = "lbl_Judul";
            lbl_Judul.Size = new Size(368, 47);
            lbl_Judul.TabIndex = 0;
            lbl_Judul.Text = "Daftar Obat Apotek ABC";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 280);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Tambah
            // 
            btn_Tambah.ImageAlign = ContentAlignment.TopLeft;
            btn_Tambah.Location = new Point(697, 384);
            btn_Tambah.Name = "btn_Tambah";
            btn_Tambah.RightToLeft = RightToLeft.Yes;
            btn_Tambah.Size = new Size(91, 34);
            btn_Tambah.TabIndex = 2;
            btn_Tambah.Text = "Tambah";
            btn_Tambah.UseVisualStyleBackColor = true;
            btn_Tambah.Click += btn_Tambah_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(btn_Tambah);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_Judul);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Judul;
        private DataGridView dataGridView1;
        private Button btn_Tambah;
    }
}
