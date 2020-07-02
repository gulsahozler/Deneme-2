using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StokTakipProgramı
{
    public partial class Form1 : Form
    {
        private SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();

        }

        void musteribilgiler()
        {
            baglanti = new SqlConnection("Server=.;Data Source=DESKTOP-N0CJVN5\\SQLEXPRESS02;Initial Catalog=musteribilgileriveribaglantisi;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM musteribilgitablosu", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            musteribilgiler();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO musteribilgitablosu(MusteriAdi,Telefon,KayitTarihi) VALUES (@MusteriAdi,@Telefon,@KayitTarihi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MusteriAdi", txtAd.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@KayitTarihi", dateTimePicker1.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            musteribilgiler();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM musteribilgitablosu WHERE MusteriNo=@MusteriNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MusteriNo", Convert.ToInt32(txtNo.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            musteribilgiler();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE musteribilgitablosu SET MusteriAdi=@MusteriAdi, Telefon=@Telefon, KayitTarihi=@KayitTarihi WHERE MusteriNo=@MusteriNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MusteriNo", Convert.ToInt32(txtNo.Text));
            komut.Parameters.AddWithValue("@MusteriAdi", txtAd.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@KayitTarihi", dateTimePicker1.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            musteribilgiler();
        }
    }
}




