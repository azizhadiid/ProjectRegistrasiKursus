namespace ProjectRegistrasiKursus
{
    partial class Buku
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
            Form = new GroupBox();
            tahunTerbit = new Label();
            txtTahunTerbit = new TextBox();
            txtPenerbit = new TextBox();
            Penerbit = new Label();
            txtPenulis = new TextBox();
            Penulis = new Label();
            txtJudul = new TextBox();
            Judul = new Label();
            dgvBuku = new DataGridView();
            Aksi = new GroupBox();
            btnClear = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnSimpan = new Button();
            Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuku).BeginInit();
            Aksi.SuspendLayout();
            SuspendLayout();
            // 
            // Form
            // 
            Form.Controls.Add(tahunTerbit);
            Form.Controls.Add(txtTahunTerbit);
            Form.Controls.Add(txtPenerbit);
            Form.Controls.Add(Penerbit);
            Form.Controls.Add(txtPenulis);
            Form.Controls.Add(Penulis);
            Form.Controls.Add(txtJudul);
            Form.Controls.Add(Judul);
            Form.Location = new Point(12, 27);
            Form.Name = "Form";
            Form.Size = new Size(692, 369);
            Form.TabIndex = 0;
            Form.TabStop = false;
            Form.Text = "Form";
            // 
            // tahunTerbit
            // 
            tahunTerbit.AutoSize = true;
            tahunTerbit.Location = new Point(24, 305);
            tahunTerbit.Name = "tahunTerbit";
            tahunTerbit.Size = new Size(145, 32);
            tahunTerbit.TabIndex = 7;
            tahunTerbit.Text = "Tahun Terbit";
            // 
            // txtTahunTerbit
            // 
            txtTahunTerbit.Location = new Point(237, 302);
            txtTahunTerbit.Name = "txtTahunTerbit";
            txtTahunTerbit.Size = new Size(421, 39);
            txtTahunTerbit.TabIndex = 6;
            // 
            // txtPenerbit
            // 
            txtPenerbit.Location = new Point(237, 225);
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.Size = new Size(421, 39);
            txtPenerbit.TabIndex = 5;
            // 
            // Penerbit
            // 
            Penerbit.AutoSize = true;
            Penerbit.Location = new Point(24, 228);
            Penerbit.Name = "Penerbit";
            Penerbit.Size = new Size(102, 32);
            Penerbit.TabIndex = 4;
            Penerbit.Text = "Penerbit";
            // 
            // txtPenulis
            // 
            txtPenulis.Location = new Point(237, 141);
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new Size(421, 39);
            txtPenulis.TabIndex = 3;
            // 
            // Penulis
            // 
            Penulis.AutoSize = true;
            Penulis.Location = new Point(24, 141);
            Penulis.Name = "Penulis";
            Penulis.Size = new Size(89, 32);
            Penulis.TabIndex = 2;
            Penulis.Text = "Penulis";
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(237, 64);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(421, 39);
            txtJudul.TabIndex = 1;
            // 
            // Judul
            // 
            Judul.AutoSize = true;
            Judul.Location = new Point(24, 64);
            Judul.Name = "Judul";
            Judul.Size = new Size(71, 32);
            Judul.TabIndex = 0;
            Judul.Text = "Judul";
            // 
            // dgvBuku
            // 
            dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuku.Location = new Point(733, 42);
            dgvBuku.Name = "dgvBuku";
            dgvBuku.RowHeadersWidth = 82;
            dgvBuku.RowTemplate.Height = 41;
            dgvBuku.Size = new Size(1014, 759);
            dgvBuku.TabIndex = 1;
            dgvBuku.CellContentClick += dgvBuku_CellContentClick;
            // 
            // Aksi
            // 
            Aksi.Controls.Add(btnClear);
            Aksi.Controls.Add(btnHapus);
            Aksi.Controls.Add(btnEdit);
            Aksi.Controls.Add(btnSimpan);
            Aksi.Location = new Point(12, 525);
            Aksi.Name = "Aksi";
            Aksi.Size = new Size(692, 276);
            Aksi.TabIndex = 2;
            Aksi.TabStop = false;
            Aksi.Text = "Aksi";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 188);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(670, 66);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(488, 46);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(188, 136);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(237, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(237, 136);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(6, 46);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(216, 136);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // Buku
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 829);
            Controls.Add(Aksi);
            Controls.Add(dgvBuku);
            Controls.Add(Form);
            Name = "Buku";
            Text = "Buku";
            Form.ResumeLayout(false);
            Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuku).EndInit();
            Aksi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Form;
        private Label Judul;
        private Label tahunTerbit;
        private TextBox txtTahunTerbit;
        private TextBox txtPenerbit;
        private Label Penerbit;
        private TextBox txtPenulis;
        private Label Penulis;
        private TextBox txtJudul;
        private DataGridView dgvBuku;
        private GroupBox Aksi;
        private Button btnClear;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnSimpan;
    }
}