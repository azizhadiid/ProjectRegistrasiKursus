namespace ProjectRegistrasiKursus
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 40);
            label1.Name = "label1";
            label1.Size = new Size(121, 31);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 112);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(205, 40);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "masukkan username";
            textBoxUsername.Size = new Size(323, 34);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(205, 109);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '#';
            textBoxPassword.PlaceholderText = "masukkan password";
            textBoxPassword.Size = new Size(323, 34);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.SeaGreen;
            buttonLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(205, 180);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(152, 50);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 278);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}