using System;
using FinancialCrm.Models;
using System.Windows.Forms;
using System.Linq;

namespace FinancialCrm
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        FincancialCrmDbEntities db = new FincancialCrmDbEntities();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtad.Text;
            string sifre = txtsifre.Text;

            var kullanici = db.Users.FirstOrDefault(x => x.Username == kullaniciAdi && x.Password == sifre);

            if (kullanici != null)
            {
                FrmGosterge frmGosterge = new FrmGosterge();
                MessageBox.Show("Hoşgeldiniz: " + kullaniciAdi + " :)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmGosterge.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şire Hatalı", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
