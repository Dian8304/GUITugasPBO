using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas2PBO
{
    public partial class TambahObat : Form
    {
        public string Nama { get; set; }
        public string Fungsi { get; set; }
        public string Harga { get; set; }

        public TambahObat()
        {
            InitializeComponent();
        }

        private void txb_NamaObat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Fungsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Nama_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tambah_Click(object sender, EventArgs e)
        {
            Nama = txb_NamaObat.Text;
            Fungsi = txb_Fungsi.Text;
            Harga = txb_Harga.Text;

            DialogResult = DialogResult.OK;
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
