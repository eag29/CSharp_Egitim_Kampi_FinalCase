using System;
using FinancialCrm.Models;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity.Migrations;

namespace FinancialCrm
{
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        FincancialCrmDbEntities db = new FincancialCrmDbEntities();

        void Listele()
        {
            dataGridView1.DataSource = db.Bills.ToList();
        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.BillTitle = txtbaslik.Text;
            bills.BillAmount = decimal.Parse(txtmiktar.Text);
            bills.BillPeriod = txtperiyot.Text;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var removeValue = db.Bills.Find(id);

            removeValue.BillTitle = txtbaslik.Text;
            removeValue.BillAmount = decimal.Parse(txtmiktar.Text);
            removeValue.BillPeriod = txtperiyot.Text;

            db.Bills.AddOrUpdate(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemden Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBankalar frmBankalar = new FrmBankalar();
            frmBankalar.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmAyarlar frmAyarlar = new FrmAyarlar();
            frmAyarlar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giderler frmGiderler = new Giderler();
            frmGiderler.Show();
            this.Hide();
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            FrmAyarlar frmAyarlar1 = new FrmAyarlar();
            frmAyarlar1.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmBankalar frmBankalar1 = new FrmBankalar();
            frmBankalar1.Show();
            this.Hide();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategori frmKategori = new FrmKategori();
            frmKategori.Show();
            this.Hide();
        }
    }
}
