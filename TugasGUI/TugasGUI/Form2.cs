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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
              this.DialogResult = DialogResult.OK;
        }

        public Pasien GetPasien()
        {
            Pasien pasien1 = new Pasien();
            pasien1.Nama = txb_Nama.Text;
            pasien1.TanggalInap = dtime_TglLahir.Value;
            pasien1.Alamat = txb2_Alamat.Text;
            return pasien1;
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
