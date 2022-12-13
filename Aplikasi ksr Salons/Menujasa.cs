using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_ksr_Salons
{
    public partial class Menujasa : Form
    {

        public MySqlCommand cmd;
        public string idJasa;

        public Menujasa()
        {
            InitializeComponent();
        }

        void tampil()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `tbl_jasa`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dgJasa.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("terjadi kesalahan");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menujasa jasa = new Menujasa();
            this.Hide();
            jasa.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            identitastk js = new identitastk();
            this.Hide();
            js.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menupelanggan mpl = new Menupelanggan();
            this.Hide();
            mpl.Show(this);

        }

        private void Menujasa_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dgJasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgJasa.CurrentCell.RowIndex;
            idJasa = dgJasa.Rows[baris].Cells[0].Value.ToString();

            search.Text = dgJasa.Rows[baris].Cells[1].Value.ToString();
            textBox1.Text = dgJasa.Rows[baris].Cells[2].Value.ToString();
            textBox2.Text = dgJasa.Rows[baris].Cells[3].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tbl_jasa` (`id_jasa`, `nama_jasa`, `harga_jasa`) VALUES (NULL, '"+search.Text+"', '"+textBox1.Text+ "');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tbl_jasa` SET `nama_jasa` = '"+search.Text+"', `harga_jasa` = '"+textBox1.Text+"' WHERE `tbl_jasa`.`id_jasa` = '"+idJasa+"'; ", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tbl_jasa WHERE `tbl_jasa`.`id_jasa` = '"+idJasa+"'';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tbl_jasa` SET `nama_jasa` = '" + search.Text + "', `harga_jasa` = '" + textBox1.Text + "' WHERE `tbl_jasa`.`id_jasa` = '" + idJasa + "'; ", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Bolo");
            Koneksi.conn.Close();
            tampil();
        }

        private void dgJasa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgJasa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgJasa.CurrentCell.RowIndex;
            idJasa = dgJasa.Rows[baris].Cells[0].Value.ToString();

            search.Text = dgJasa.Rows[baris].Cells[1].Value.ToString();
            textBox1.Text = dgJasa.Rows[baris].Cells[2].Value.ToString();
        }
    }
}
