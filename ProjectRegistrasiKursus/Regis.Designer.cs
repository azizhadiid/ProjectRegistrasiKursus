namespace ProjectRegistrasiKursus
{
    partial class Regis
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxBahasaPemrograman = new ComboBox();
            richTextBoxHasil = new RichTextBox();
            buttonDaftar = new Button();
            radioButtonHari1 = new RadioButton();
            radioButtonHari2 = new RadioButton();
            radioButtonHari3 = new RadioButton();
            groupBoxPilihanHari = new GroupBox();
            checkBoxWeb = new CheckBox();
            checkBoxMobile = new CheckBox();
            checkBoxDesktop = new CheckBox();
            label5 = new Label();
            textBoxNama = new TextBox();
            dgviewPeserta = new DataGridView();
            buttonHapus = new Button();
            labelId = new Label();
            buttonEdit = new Button();
            groupBoxPilihanHari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgviewPeserta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 116);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(490, 50);
            label1.TabIndex = 0;
            label1.Text = "Pilih Bahasa Pemrograman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 191);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(309, 50);
            label2.TabIndex = 1;
            label2.Text = "Pilih Hari Kursus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 348);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(443, 50);
            label3.TabIndex = 2;
            label3.Text = "Pilih Skill Pemrograman";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 486);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(305, 50);
            label4.TabIndex = 3;
            label4.Text = "Pilih Jam Kursus";
            // 
            // comboBoxBahasaPemrograman
            // 
            comboBoxBahasaPemrograman.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBahasaPemrograman.FormattingEnabled = true;
            comboBoxBahasaPemrograman.Items.AddRange(new object[] { "C#", "Java", "Python", "PHP", "JavaScript", "Kotlin" });
            comboBoxBahasaPemrograman.Location = new Point(527, 113);
            comboBoxBahasaPemrograman.Name = "comboBoxBahasaPemrograman";
            comboBoxBahasaPemrograman.Size = new Size(322, 58);
            comboBoxBahasaPemrograman.TabIndex = 4;
            comboBoxBahasaPemrograman.SelectedValueChanged += comboBoxBahasaPemrograman_SelectedValueChanged;
            // 
            // richTextBoxHasil
            // 
            richTextBoxHasil.Location = new Point(1020, 54);
            richTextBoxHasil.Name = "richTextBoxHasil";
            richTextBoxHasil.Size = new Size(820, 123);
            richTextBoxHasil.TabIndex = 5;
            richTextBoxHasil.Text = "";
            // 
            // buttonDaftar
            // 
            buttonDaftar.Location = new Point(397, 541);
            buttonDaftar.Name = "buttonDaftar";
            buttonDaftar.Size = new Size(164, 57);
            buttonDaftar.TabIndex = 6;
            buttonDaftar.Text = "Daftar";
            buttonDaftar.UseVisualStyleBackColor = true;
            buttonDaftar.Click += buttonDaftar_Click;
            // 
            // radioButtonHari1
            // 
            radioButtonHari1.AutoSize = true;
            radioButtonHari1.Location = new Point(25, 19);
            radioButtonHari1.Name = "radioButtonHari1";
            radioButtonHari1.Size = new Size(273, 54);
            radioButtonHari1.TabIndex = 7;
            radioButtonHari1.TabStop = true;
            radioButtonHari1.Text = "Senin - Rabu";
            radioButtonHari1.UseVisualStyleBackColor = true;
            radioButtonHari1.Click += radioButtonHari1_Click;
            // 
            // radioButtonHari2
            // 
            radioButtonHari2.AutoSize = true;
            radioButtonHari2.Location = new Point(25, 60);
            radioButtonHari2.Name = "radioButtonHari2";
            radioButtonHari2.Size = new Size(301, 54);
            radioButtonHari2.TabIndex = 8;
            radioButtonHari2.TabStop = true;
            radioButtonHari2.Text = "Selasa - Kamis";
            radioButtonHari2.UseVisualStyleBackColor = true;
            radioButtonHari2.CheckedChanged += radioButtonHari2_CheckedChanged;
            // 
            // radioButtonHari3
            // 
            radioButtonHari3.AutoSize = true;
            radioButtonHari3.Location = new Point(25, 101);
            radioButtonHari3.Name = "radioButtonHari3";
            radioButtonHari3.Size = new Size(324, 54);
            radioButtonHari3.TabIndex = 9;
            radioButtonHari3.TabStop = true;
            radioButtonHari3.Text = "Sabtu - Minggu";
            radioButtonHari3.UseVisualStyleBackColor = true;
            radioButtonHari3.CheckedChanged += radioButtonHari3_CheckedChanged;
            // 
            // groupBoxPilihanHari
            // 
            groupBoxPilihanHari.Controls.Add(radioButtonHari1);
            groupBoxPilihanHari.Controls.Add(radioButtonHari3);
            groupBoxPilihanHari.Controls.Add(radioButtonHari2);
            groupBoxPilihanHari.Location = new Point(507, 191);
            groupBoxPilihanHari.Name = "groupBoxPilihanHari";
            groupBoxPilihanHari.Size = new Size(391, 169);
            groupBoxPilihanHari.TabIndex = 10;
            groupBoxPilihanHari.TabStop = false;
            // 
            // checkBoxWeb
            // 
            checkBoxWeb.AutoSize = true;
            checkBoxWeb.Location = new Point(523, 344);
            checkBoxWeb.Name = "checkBoxWeb";
            checkBoxWeb.Size = new Size(391, 54);
            checkBoxWeb.TabIndex = 11;
            checkBoxWeb.Text = "Pemrograman Web";
            checkBoxWeb.UseVisualStyleBackColor = true;
            checkBoxWeb.CheckedChanged += checkBoxWeb_CheckedChanged;
            // 
            // checkBoxMobile
            // 
            checkBoxMobile.AutoSize = true;
            checkBoxMobile.Location = new Point(523, 391);
            checkBoxMobile.Name = "checkBoxMobile";
            checkBoxMobile.Size = new Size(435, 54);
            checkBoxMobile.TabIndex = 12;
            checkBoxMobile.Text = "Pemrograman Mobile";
            checkBoxMobile.UseVisualStyleBackColor = true;
            checkBoxMobile.CheckedChanged += checkBoxMobile_CheckedChanged;
            // 
            // checkBoxDesktop
            // 
            checkBoxDesktop.AutoSize = true;
            checkBoxDesktop.Location = new Point(523, 442);
            checkBoxDesktop.Name = "checkBoxDesktop";
            checkBoxDesktop.Size = new Size(456, 54);
            checkBoxDesktop.TabIndex = 13;
            checkBoxDesktop.Text = "Pemrograman Desktop";
            checkBoxDesktop.UseVisualStyleBackColor = true;
            checkBoxDesktop.CheckedChanged += checkBoxDesktop_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 54);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 50);
            label5.TabIndex = 14;
            label5.Text = "Nama";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(531, 48);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(322, 56);
            textBoxNama.TabIndex = 15;
            // 
            // dgviewPeserta
            // 
            dgviewPeserta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgviewPeserta.Location = new Point(1020, 183);
            dgviewPeserta.Name = "dgviewPeserta";
            dgviewPeserta.RowHeadersWidth = 82;
            dgviewPeserta.RowTemplate.Height = 41;
            dgviewPeserta.Size = new Size(820, 415);
            dgviewPeserta.TabIndex = 16;
            dgviewPeserta.CellClick += dgviewPeserta_CellClick;
            dgviewPeserta.SelectionChanged += dgviewPeserta_SelectionChanged;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.IndianRed;
            buttonHapus.Location = new Point(583, 541);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(164, 57);
            buttonHapus.TabIndex = 17;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(29, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 50);
            labelId.TabIndex = 18;
            labelId.Visible = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.PaleGreen;
            buttonEdit.Location = new Point(765, 541);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(164, 57);
            buttonEdit.TabIndex = 19;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Regis
            // 
            AutoScaleDimensions = new SizeF(22F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1874, 610);
            Controls.Add(buttonEdit);
            Controls.Add(labelId);
            Controls.Add(buttonHapus);
            Controls.Add(dgviewPeserta);
            Controls.Add(textBoxNama);
            Controls.Add(label5);
            Controls.Add(checkBoxDesktop);
            Controls.Add(checkBoxMobile);
            Controls.Add(checkBoxWeb);
            Controls.Add(groupBoxPilihanHari);
            Controls.Add(buttonDaftar);
            Controls.Add(richTextBoxHasil);
            Controls.Add(comboBoxBahasaPemrograman);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Regis";
            Text = "Regis";
            Load += Regis_Load;
            groupBoxPilihanHari.ResumeLayout(false);
            groupBoxPilihanHari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgviewPeserta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxBahasaPemrograman;
        private RichTextBox richTextBoxHasil;
        private Button buttonDaftar;
        private RadioButton radioButtonHari1;
        private RadioButton radioButtonHari2;
        private RadioButton radioButtonHari3;
        private GroupBox groupBoxPilihanHari;
        private CheckBox checkBoxWeb;
        private CheckBox checkBoxMobile;
        private CheckBox checkBoxDesktop;
        private Label label5;
        private TextBox textBoxNama;
        private DataGridView dgviewPeserta;
        private Button buttonHapus;
        private Label labelId;
        private Button buttonEdit;
    }
}