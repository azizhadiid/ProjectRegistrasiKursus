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
    public partial class Regis : Form
    {

        String bahasaPemrograman;
        String hariKursus;
        List<String> skill = new List<string>();
        int id;
        string nama;
        List<Peserta> listPeserta = new List<Peserta>();

        public Regis()
        {
            InitializeComponent();
            bahasaPemrograman = "";
            hariKursus = "";
            id = 0;
            nama = "";

        }

        private void comboBoxBahasaPemrograman_SelectedValueChanged(object sender, EventArgs e)
        {
            bahasaPemrograman = comboBoxBahasaPemrograman.SelectedItem.ToString();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            //membuat objek peserta
            id++;
            nama = textBoxNama.Text;
            Peserta peserta = new Peserta(id, nama, bahasaPemrograman, hariKursus, skill);
            //menambahkan objek peserta ke dalam listPeserta
            listPeserta.Add(peserta);
            //menampilkan hasil isian form ke richtextbox
            richTextBoxHasil.AppendText("Anda sudah melakukan registrasi dengan rincian sebagai berikut:\n");
            richTextBoxHasil.AppendText("Nama :" + nama + "\n");
            richTextBoxHasil.AppendText("Bahasa Pemrograman :" + bahasaPemrograman + "\n");
            richTextBoxHasil.AppendText("Hari Kursus :" + hariKursus + "\n");
            richTextBoxHasil.AppendText("Pilihan Skill:\n");
            foreach (String valSkill in skill)
            {
                richTextBoxHasil.AppendText(valSkill.ToString() + "\n");
            }

            //penyimpanan data ke database
            if (peserta.insert() != 0)
            {
                MessageBox.Show("Insert Data Sukses!");
                //membaca data peserta dari database
                DataTable dt = new DataTable();
                dt = Peserta.SelectAll();
                //menampilkan data peserta pada datagridview
                //dgviewPeserta.AutoGenerateColumns = false;
                dgviewPeserta.DataSource = dt;
                dgviewPeserta.Show();
            }
            else
            {
                MessageBox.Show("Insert Data Gagal!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonHari1_Click(object sender, EventArgs e)
        {
            hariKursus = radioButtonHari1.Text;
        }

        private void radioButtonHari2_CheckedChanged(object sender, EventArgs e)
        {
            hariKursus = radioButtonHari2.Text;
        }

        private void radioButtonHari3_CheckedChanged(object sender, EventArgs e)
        {
            hariKursus = radioButtonHari3.Text;
        }

        private void checkBoxWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWeb.Checked)
            {
                //tambahkan skill web pada list skill
                skill.Add(checkBoxWeb.Text);
            }
            else
            {
                //menghapus skill web pada list skill
                skill.Remove(checkBoxWeb.Text);
            }
        }

        private void checkBoxMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMobile.Checked)
            {
                skill.Add(checkBoxMobile.Text);
            }
            else
            {
                skill.Remove(checkBoxMobile.Text);
            }
        }

        private void checkBoxDesktop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDesktop.Checked)
            {
                skill.Add(checkBoxDesktop.Text);
            }
            else
            {
                skill.Remove(checkBoxDesktop.Text);
            }
        }

        private void Regis_Load(object sender, EventArgs e)
        {
            //membaca data peserta dari database
            DataTable dt = new DataTable();
            dt = Peserta.SelectAll();
            //menampilkan data peserta pada datagridview
            //dgviewPeserta.AutoGenerateColumns = false;
            dgviewPeserta.DataSource = dt;
            dgviewPeserta.Show();
        }

        private void dgviewPeserta_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgviewPeserta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearForm();
            int index = dgviewPeserta.CurrentRow.Index;
            id = Convert.ToInt32(dgviewPeserta.Rows[index].Cells[0].Value);
            nama = dgviewPeserta.Rows[index].Cells[1].Value.ToString();
            bahasaPemrograman = dgviewPeserta.Rows[index].Cells[2].Value.ToString();
            hariKursus = dgviewPeserta.Rows[index].Cells[3].Value.ToString();
            string skill = dgviewPeserta.Rows[index].Cells[4].Value.ToString();
            // convert string skill ke dalam bentuk koleksi
            // List<string> Listskill = new List<string>();
            string[] listSkill = skill.Split(',');

            labelId.Text = id.ToString();
            textBoxNama.Text = nama;
            comboBoxBahasaPemrograman.Text = bahasaPemrograman;
            // untuk menentukan hari
            if (hariKursus == "Senin - Rabu") radioButtonHari1.Checked = true;
            else if (hariKursus == "Selasa - Kamis") radioButtonHari2.Checked = true;
            else if (hariKursus == "Sabtu - Minggu") radioButtonHari3.Checked = true;

            for (int i = 1; i < listSkill.Length; i++)
            {
                this.skill.Add(listSkill[i]);
                if (listSkill[i] == "Pemrograman Web") checkBoxWeb.Checked = true;
                else if (listSkill[i] == "Pemrograman Desktop") checkBoxDesktop.Checked = true;
                else if (listSkill[i] == "Pemrograman Mobile") checkBoxMobile.Checked = true;
            }
            buttonHapus.Enabled = true;
            buttonEdit.Enabled = true;
        }

        private void clearForm()
        {
            textBoxNama.Text = "";
            comboBoxBahasaPemrograman.Text = "";
            radioButtonHari1.Checked = false;
            radioButtonHari2.Checked = false;
            radioButtonHari3.Checked = false;
            checkBoxWeb.Checked = false;
            checkBoxMobile.Checked = false;
            checkBoxDesktop.Checked = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            // menghapus data yang dipilih berdasarkan id
            Peserta peserta = new Peserta(id, nama, bahasaPemrograman, hariKursus, skill);
            peserta.delete();
            //membaca data peserta dari database
            DataTable dt = new DataTable();
            dt = Peserta.SelectAll();
            //menampilkan data peserta pada datagridview
            //dgviewPeserta.AutoGenerateColumns = false;
            dgviewPeserta.DataSource = dt;
            dgviewPeserta.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // menghapus data yang dipilih berdasarkan id
            nama = textBoxNama.Text;
            Peserta peserta = new Peserta(id, nama, bahasaPemrograman, hariKursus, skill);
            peserta.edit();
            //membaca data peserta dari database
            DataTable dt = new DataTable();
            dt = Peserta.SelectAll();
            //menampilkan data peserta pada datagridview
            //dgviewPeserta.AutoGenerateColumns = false;
            dgviewPeserta.DataSource = dt;
            dgviewPeserta.Show();
        }
    }
}
