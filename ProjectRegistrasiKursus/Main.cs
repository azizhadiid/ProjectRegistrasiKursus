using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRegistrasiKursus
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tombolDataBuku_Click(object sender, EventArgs e)
        {
            this.Hide(); // Sembunyikan form utama
            Buku bukuForm = new Buku();
            bukuForm.FormClosed += (s, args) => this.Show(); // Tampilkan kembali form utama saat Buku ditutup
            bukuForm.Show();
        }
    }
}
