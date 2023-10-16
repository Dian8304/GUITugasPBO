using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasGUI
{
    public partial class Form1 : Form
    {
        public List<Pasien> daftarPasien = new List<Pasien>();
        public Form1()
        {
            InitializeComponent();

            Pasien pasien = new Pasien();
            pasien.Nama = "Yuli";
            pasien.TanggalInap = new DateTime(2004, 7, 30, 20, 30, 22);
            pasien.Alamat = "Jalan Jawa No 5";

            daftarPasien.Add(pasien);
            dataGridView1.DataSource = daftarPasien;
        }

        private void btn_TambahPasien_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    Pasien pasien1 = form2.GetPasien();
                    daftarPasien.Add(pasien1);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = daftarPasien;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class Pasien
    {
        public string Nama { get; set; }
        public DateTime TanggalInap { get; set; }
        public string Alamat { get; set; }
    }
}
