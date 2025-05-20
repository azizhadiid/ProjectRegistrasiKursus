namespace ProjectRegistrasiKursus
{
    partial class Main
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
            tombolDataBuku = new Button();
            SuspendLayout();
            // 
            // tombolDataBuku
            // 
            tombolDataBuku.Location = new Point(275, 157);
            tombolDataBuku.Name = "tombolDataBuku";
            tombolDataBuku.Size = new Size(150, 46);
            tombolDataBuku.TabIndex = 0;
            tombolDataBuku.Text = "Data Buku";
            tombolDataBuku.UseVisualStyleBackColor = true;
            tombolDataBuku.Click += tombolDataBuku_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tombolDataBuku);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button tombolDataBuku;
    }
}