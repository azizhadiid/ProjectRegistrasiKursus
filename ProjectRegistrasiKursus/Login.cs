using MySql.Data.MySqlClient;

namespace ProjectRegistrasiKursus
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisikan.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password FROM pengguna WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashFromDb = reader.GetString("password");
                            bool isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDb);

                            if (isValid)
                            {
                                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Regis objRegis = new Regis();
                                objRegis.Show();
                            }
                            else
                            {
                                MessageBox.Show("Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username tidak ditemukan!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan koneksi:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /*if (username == username && password == password)
        {
            //2. Jika sesuai, tampilkan pesan "login sukses" 
            MessageBox.Show("Login Sukses");
            //3. Beralih ke form pendaftaran kursus
            this.Hide();
            Regis objRegis = new Regis();
            objRegis.Show();

        }
        else
        {
            //3. Jika tidak sesuai, tampilkan pesan "login gagal" dan reset form login
            MessageBox.Show("Login Gagal");
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
        */

    }
}