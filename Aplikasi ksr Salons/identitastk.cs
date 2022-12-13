using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_ksr_Salons
{
    public partial class identitastk : Form
    {
        public MySqlCommand cmd;
        public string id;

        public identitastk()
        {
            InitializeComponent();
        }

        void tampil()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `tbl_identitas`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
           
                datgdid.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("terjadi kesalahan");
            }
        }

        private void IdToko_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridIden_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menujasa jasa = new Menujasa();
            this.Hide();
            jasa.Show();
        }

        private void dataGridIden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = datgdid.CurrentCell.RowIndex;
            id = datgdid.Rows[baris].Cells[0].Value.ToString();

            textBox1.Text = datgdid.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = datgdid.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = datgdid.Rows[baris].Cells[3].Value.ToString();
            tkcp1.Text = datgdid.Rows[baris].Cells[4].Value.ToString();
            textBox4.Text = datgdid.Rows[baris].Cells[5].Value.ToString();
            tkcp3.Text = datgdid.Rows[baris].Cells[6].Value.ToString();
        }

        private void Idtks_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tbl_identitas` SET `Nama_Toko` = '"+textBox1.Text+"', `alamat_toko` = '"+textBox2.Text+"', `Nomor_Telepon` = '"+textBox3.Text+"', `Caption_Pertama` = '"+tkcp1.Text+"', `Caption_Kedua` = '"+textBox4.Text+"', `Caption_Ketiga` = '"+tkcp3.Text+"' WHERE `tbl_identitas`.`id_identitas` = '"+id+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Menujasa menujasa = new Menujasa();
            this.Hide();
            menujasa.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menupelanggan menupelanggan = new Menupelanggan();
            this.Hide();
            menupelanggan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tbl_identitas` (`id_identitas`, `Nama_Toko`, `alamat_toko`, `Nomor_Telepon`, `Caption_Pertama`, `Caption_Kedua`, `Caption_Ketiga`) VALUES (NULL, '"+textBox1.Text+"', '"+ textBox2.Text+"', '"+ textBox3.Text+"', '"+tkcp1.Text+"', '"+ textBox4.Text+"', '"+tkcp3.Text+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tbl_identitas WHERE `tbl_identitas`.`id_identitas` = '"+id+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tbl_identitas` SET `Nama_Toko` = '" + textBox1.Text + "', `alamat_toko` = '" + textBox2.Text + "', `Nomor_Telepon` = '" + textBox3.Text + "', `Caption_Pertama` = '" + tkcp1.Text + "', `Caption_Kedua` = '" + textBox4.Text + "', `Caption_Ketiga` = '" + tkcp3.Text + "' WHERE `tbl_identitas`.`id_identitas` = '" + id + "';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }
    }
}