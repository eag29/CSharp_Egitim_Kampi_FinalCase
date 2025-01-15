using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmKategori : Form
    {
        FincancialCrmDbEntities db = new FincancialCrmDbEntities();

        public FrmKategori()
        {
            InitializeComponent();
        }

        void Listele()
        {
            dataGridView1.DataSource = db.Categories.ToList();
        }
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.CategoryName = txtname.Text;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);
            var deletedValues = db.Categories.Find(id);
            db.Categories.Remove(deletedValues);
            db.SaveChanges();
            MessageBox.Show("Kategori Silinmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);
            var updatedValue = db.Categories.Find(id);

            updatedValue.CategoryName = txtname.Text;

            db.Categories.AddOrUpdate(updatedValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmBankalar frmBankalar1 = new FrmBankalar();
            frmBankalar1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFaturalar frmFaturalar = new FrmFaturalar();
            frmFaturalar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giderler giderler = new Giderler();
            giderler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBankaHareketleri frm = new FrmBankaHareketleri();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGosterge frm = new FrmGosterge();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmAyarlar frm = new FrmAyarlar();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
