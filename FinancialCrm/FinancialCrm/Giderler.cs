using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }

        FincancialCrmDbEntities db = new FincancialCrmDbEntities();

        void Listele()
        {
            var harcamalar = db.Spendings.ToList();
            dataGridView1.DataSource = harcamalar;
        }
        /*private void FrmBankaHareketleri_Load(object sender, EventArgs e)
        {
            var kategori = (from x in db.Spendings
                             select new
                             {
                                 x.SpendingId,
                                 x.CategoryId
                             }).ToList();

            cmbCategory.ValueMember = "SpendingId";
            cmbCategory.DisplayMember = "CategoryId";
            cmbCategory.DataSource = kategori;


            var tarih = (from x in db.Spendings
                         select new
                         {
                             x.SpendingId,
                             x.SpendingDate
                         }).ToList();

            cmbDate.ValueMember = "SpendingId";
            cmbDate.DisplayMember = "SpendingDate";
            cmbDate.DataSource = tarih;

            Listele();
        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            int categoryid = int.Parse(cmbCategory.SelectedValue.ToString());
            var filtrelenenKategori = db.Spendings.Where(x => x.CategoryId == categoryid).ToList();
            dataGridView1.DataSource = filtrelenenKategori;
            MessageBox.Show("Seçilen Kategori Listelenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = DateTime.Parse(cmbDate.SelectedValue.ToString());
            var filtrelenenTarih = db.Spendings.Where(x => x.SpendingDate == secilenTarih).ToList();
            dataGridView1.DataSource = filtrelenenTarih;
            MessageBox.Show("Banka Hareketleri Listelenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int categoryid = int.Parse(cmbCategory.SelectedValue.ToString());

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = txtTitle.Text;
            spendings.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
            spendings.SpendingDate = DateTime.Parse(cmbDate.Text);
            spendings.CategoryId = categoryid;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Banka Hareketleri Ekllenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }*/
        private void btnKategori_Click_1(object sender, EventArgs e)
        {
            FrmKategori frmKategori = new FrmKategori();
            frmKategori.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmBankalar frmBankalar = new FrmBankalar();
            frmBankalar.Show();
            this.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmFaturalar frm = new FrmFaturalar();
            frm.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmFaturalar frmOdemeler = new FrmFaturalar();
            frmOdemeler.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmBankaHareketleri frmBankaHareketleri = new FrmBankaHareketleri();
            frmBankaHareketleri.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FrmGosterge frmGosterge = new FrmGosterge();
            frmGosterge.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FrmAyarlar frmAyarlar = new FrmAyarlar();
            frmAyarlar.Show();
            this.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Spendings.ToList();
        }
    }
}
