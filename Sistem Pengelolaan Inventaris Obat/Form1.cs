namespace Sistem_Pengelolaan_Inventaris_Obat
{
    public partial class Form1 : Form
    {
        private List<Obat> daftarObat = new List<Obat>();
        private InventarisObat inventaris = new InventarisObat();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            int jumlah = int.Parse(textBoxJumlah.Text);
            double harga = double.Parse(textBoxHarga.Text);

            Obat obat = inventaris.Tambah(nama, jumlah, harga);
            daftarObat.Add(obat);

            inventaris.TampilData(daftarObat, tabelDaftarObat);

            textBoxNama.Clear();
            textBoxJumlah.Clear();
            textBoxHarga.Clear();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = textPencarian.Text;

            List<Obat> hasilPencarian = inventaris.CariObatBerdasarkanNama(keyword, daftarObat);

            inventaris.TampilData(hasilPencarian, tabelDaftarObat);
        }

        private void textPencarian_TextChanged(object sender, EventArgs e)
        {
            string keyword = textPencarian.Text;

            List<Obat> hasilPencarian = inventaris.CariObatBerdasarkanNama(keyword, daftarObat);

            inventaris.TampilData(hasilPencarian, tabelDaftarObat);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Obat
    {
        public string Nama { get; set; }
        public int Jumlah { get; set; }
        public double Harga { get; set; }

        public Obat(string nama, int jumlah, double harga)
        {
            Nama = nama;
            Jumlah = jumlah;
            Harga = harga;
        }
    }

    public class InventarisObat
    {
        public Obat Tambah(string nama, int jumlah, double harga)
        {
            return new Obat(nama, jumlah, harga);
        }

        public void TampilData(List<Obat> daftarObat, DataGridView tabel)
        {
            tabel.Rows.Clear();

            foreach (var obat in daftarObat)
            {
                tabel.Rows.Add(obat.Nama, obat.Jumlah, obat.Harga);
            }
        }

        public List<Obat> CariObatBerdasarkanNama(string nama, List<Obat> daftarObat)
        {
            return daftarObat.Where(o => o.Nama.Contains(nama, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
