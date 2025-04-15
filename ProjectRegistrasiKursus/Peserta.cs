using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRegistrasiKursus
{
    internal class Peserta
    {
        //property
        int id;
        string nama;
        string bahasaPemrograman;
        string hariKursus;
        List<string> skill = new List<string>();
        protected const String conString = "server=localhost;database=db_kursus;uid=root;pwd=;";

        //Konstruktor
        public Peserta()
        {

        }
        public Peserta(int id,string nama,string bahasaPemrograman,
            string hariKursus,List<string> skill)
        {
            this.id = id;
            this.nama = nama;
            this.bahasaPemrograman = bahasaPemrograman;
            this.hariKursus = hariKursus;
            this.skill = skill;
        }

        //method untuk insert ke tabel peserta (instance method)
        public int insert()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString); // Objek koneksi
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_peserta (nama,bahasa,hari,skill) VALUES(@nama,@bahasa,@hari,@skill)");
            //ubah list
            string ListSkill = "";
            foreach (String valSkill in skill)
            {
                ListSkill = ListSkill + "," + valSkill;
            }

            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@bahasa", bahasaPemrograman);
            cmd.Parameters.AddWithValue("@hari", hariKursus);
            cmd.Parameters.AddWithValue("@skill", ListSkill);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open(); // memnbuka koneksi ke database
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            //cara 1
            MySqlConnection connect = new MySqlConnection(conString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_peserta", connect))
            {
                try
                {
                    connect.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);

                }
                catch (Exception e)
                {
                    String error = e.Message;
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return dt;
        }
        public int delete()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString); // Objek koneksi
            MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_peserta WHERE id = @id");
            //ubah list

            cmd.Parameters.AddWithValue("@id", id);
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open(); // memnbuka koneksi ke database
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

        public int edit()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString); // Objek koneksi
            MySqlCommand cmd = new MySqlCommand("UPDATE tb_peserta SET nama = @nama,bahasa = @bahasa,hari = @hari,skill = @skill WHERE id = @id");
            //ubah list
            string ListSkill = "";
            foreach (String valSkill in skill)
            {
                ListSkill = ListSkill + "," + valSkill;
            }

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@bahasa", bahasaPemrograman);
            cmd.Parameters.AddWithValue("@hari", hariKursus);
            cmd.Parameters.AddWithValue("@skill", ListSkill);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open(); // memnbuka koneksi ke database
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }
    }
}
