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
            //1. mengecek apakah username dan password sudah sesuai? username="admin" password="1234"
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "1234")
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
        }
    }
}