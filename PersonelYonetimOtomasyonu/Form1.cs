namespace PersonelYonetimOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MuhasebeIslem muhasebeIslem = new MuhasebeIslem();
        BireyselIslem bireyselIslem= new BireyselIslem();
        void temizle()
        {
            textBoxTC.Clear();
            textBoxAdSoyad.Clear();
            textBoxTelNo.Clear();
            textBoxYas.Clear();
            textBoxHesapSatisHedefi.Clear();
            textBoxMaasPrim.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            textBoxHesapSatisHedefi.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBoxMaasPrim.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBoxTC.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBoxAdSoyad.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            textBoxTelNo.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            textBoxYas.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
        }

        private void btnMuhasebeEkle_Click(object sender, EventArgs e)
        {
            muhasebeIslem.Add(new Muhasebe
                (textBoxTC.Text,textBoxAdSoyad.Text,textBoxTelNo.Text,int.Parse(textBoxYas.Text),textBoxHesapSatisHedefi.Text,
                textBoxMaasPrim.Text));
            MessageBox.Show("Muhasebe kaydı yapıldı.Görmek için Muhasebe Listele Butonuna tıklayınız.");
            temizle();
        }

        private void btnMuhasebeListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = muhasebeIslem.list();
        }

        private void btnMuhasebeSil_Click(object sender, EventArgs e)
        {
            muhasebeIslem.Delete(textBoxTC.Text);
            dataGridView1.DataSource = muhasebeIslem.list();
            temizle();
        }

        private void btnBireyselEkle_Click(object sender, EventArgs e)
        {
            bireyselIslem.Add(new Bireysel
                (textBoxTC.Text,textBoxAdSoyad.Text,textBoxTelNo.Text,int.Parse(textBoxYas.Text),textBoxHesapSatisHedefi.Text,
                textBoxMaasPrim.Text));
            MessageBox.Show("Bireysel kaydı yapıldı.Görmek için Bireysel Listele Butonuna tıklayınız.");
            temizle();
        }

        private void btnBireyselListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= bireyselIslem.list();
        }

        private void btnBireyselSil_Click(object sender, EventArgs e)
        {
            bireyselIslem.Delete(textBoxTC.Text);
            dataGridView1.DataSource= bireyselIslem.list();
            temizle();
        }

    }
}