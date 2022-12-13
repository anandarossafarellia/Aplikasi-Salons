using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class Menupelanggan : Form
    {
        public MySqlCommand cmd;
        public string idpelanggan;

        void tampil()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tbl_pelanggan`;", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgpelanggan.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        public Menupelanggan()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         Menujasa mj = new Menujasa();
            this.Hide();
            mj.Show(this);
        }

        private void Menupelanggan_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dgpelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgpelanggan.CurrentCell.RowIndex;
            idpelanggan = dgpelanggan.Rows[baris].Cells[0].Value.ToString();

            textBox1.Text = dgpelanggan.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = dgpelanggan.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = dgpelanggan.Rows[baris].Cells[3].Value.ToString();
            textBox4.Text = dgpelanggan.Rows[baris].Cells[3].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tbl_pelanggan` (`id_pelanggan`, `nama_pelanggan`, `alamat_pelanggan`, `nomor_telpon`) VALUES(NULL, '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+ "');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tbl_pelanggan` SET `alamat_pelanggan` = 'Kalimalang' WHERE `tbl_pelanggan`.`id_pelanggan` = '"+idpelanggan+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tbl_pelanggan WHERE `tbl_pelanggan`.`id_pelanggan` = '"+1+"'';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tbl_pelanggan` SET `alamat_pelanggan` = 'Kalimalang' WHERE `tbl_pelanggan`.`id_pelanggan` = '" + idpelanggan + "';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }
    }
}
