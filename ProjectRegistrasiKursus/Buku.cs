using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectRegistrasiKursus
{
    public partial class Buku : Form
    {
        private int selectedId = -1;
        public Buku()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM buku";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Tambahkan kolom No (nomor urut)
                    dt.Columns.Add("No", typeof(int));

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["No"] = i + 1;
                    }

                    // Pindahkan kolom "No" ke posisi paling kiri (opsional)
                    dt.Columns["No"].SetOrdinal(0);

                    dgvBuku.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load data: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtJudul.Clear();
            txtPenerbit.Clear();
            txtPenerbit.Clear();
            txtTahunTerbit.Clear();
            selectedId = -1;
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO buku (judul, penulis, penerbit, tahun_terbit) " +
                                   "VALUES (@judul, @penulis, @penerbit, @tahun_terbit)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@penulis", txtPenulis.Text);
                    cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", txtTahunTerbit.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil disimpan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal simpan: " + ex.Message);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valueSelectedId = dgvBuku.Rows[e.RowIndex].Cells["id"].Value;
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value)
                    ? Convert.ToInt32(valueSelectedId)
                    : -1;

                txtJudul.Text = dgvBuku.Rows[e.RowIndex].Cells["judul"].Value?.ToString() ?? "";
                txtPenulis.Text = dgvBuku.Rows[e.RowIndex].Cells["penulis"].Value?.ToString() ?? "";
                txtPenerbit.Text = dgvBuku.Rows[e.RowIndex].Cells["penerbit"].Value?.ToString() ?? "";
                txtTahunTerbit.Text = dgvBuku.Rows[e.RowIndex].Cells["tahun_terbit"].Value?.ToString() ?? "";
                btnSimpan.Enabled = false;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE buku SET judul=@judul, penulis=@penulis, penerbit=@penerbit," +
                                   " tahun_terbit=@tahun_terbit WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@penulis", txtPenulis.Text);
                    cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
                    cmd.Parameters.AddWithValue("@tahun_terbit", txtTahunTerbit.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil diperbarui!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update: " + ex.Message);
                }
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data buku ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM buku WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data buku berhasil dihapus.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus: " + ex.Message);
                }
            }

        }
    }
}
