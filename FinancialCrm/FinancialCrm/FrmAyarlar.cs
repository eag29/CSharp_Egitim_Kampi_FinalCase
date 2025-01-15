using System;
using FinancialCrm.Models;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity.Migrations;

namespace FinancialCrm
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        FincancialCrmDbEntities db = new FincancialCrmDbEntities();

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBankalar frmBankalar = new FrmBankalar();
            frmBankalar.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmFaturalar frmOdemeler = new FrmFaturalar();
            frmOdemeler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGosterge frmGosterge = new FrmGosterge();
            frmGosterge.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Username = txtad.Text;
            users.Password = txtsifre.Text;
            db.Users.Add(users);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Eklenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);
            var deletedValue = db.Users.Find(id);
            db.Users.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Silinmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);
            var updatedValue = db.Users.Find(id);

            updatedValue.Username = txtad.Text;
            updatedValue.Password = txtsifre.Text;

            db.Users.AddOrUpdate(updatedValue);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Güncellenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmBankalar frmBankalar = new FrmBankalar();
            frmBankalar.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmFaturalar frmFaturalar = new FrmFaturalar();
            frmFaturalar.Show();
            this.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Giderler giderler = new Giderler();
            giderler.Show();
            this.Hide();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmBankaHareketleri frmBankaHareketleri = new FrmBankaHareketleri();
            frmBankaHareketleri.Show();
            this.Hide();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            FrmGosterge frmGosterge = new FrmGosterge();
            frmGosterge.Show();
            this.Hide();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            FrmKategori frmKategori = new FrmKategori(); 
            frmKategori.Show();
            this.Hide();
        }
    }
}
