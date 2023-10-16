namespace Tugas2PBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nama";
            dataGridView1.Columns[1].Name = "Fungsi";
            dataGridView1.Columns[2].Name = "Harga";

            //Obat Pertama
            dataGridView1.Rows.Add("Amoxicillin", "Infeksi bakteri", "Rp 5000");
            dataGridView1.Rows.Add("Paracetamol", "Pereda nyeri", "Rp 2500");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Tambah_Click(object sender, EventArgs e)
        {
            TambahObat tambahObat = new TambahObat();
            if (tambahObat.ShowDialog() == DialogResult.OK) 
            {
                dataGridView1.Rows.Add(tambahObat.Nama, tambahObat.Fungsi, tambahObat.Harga);
            }
        }
    }
}