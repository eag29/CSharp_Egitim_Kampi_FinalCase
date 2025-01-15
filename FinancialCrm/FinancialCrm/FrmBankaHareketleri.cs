using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBankaHareketleri : Form
    {

        FincancialCrmDbEntities db = new FincancialCrmDbEntities();

        public FrmBankaHareketleri()
        {
            InitializeComponent();
        }

        void Listele()
        {
            dataGridView1.DataSource = db.BankProcesses.ToList();
        }

        private void FrmBankaHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnIdTumu_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void btnIdFiltrele_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            dataGridView1.DataSource = db.BankProcesses.Where(x => x.BankProcessId == id).ToList();
        }

        private void btnTarihTumu_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.Show();
            this.Hide();
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
        private void button3_Click(object sender, EventArgs e)
        {
            Giderler giderler = new Giderler();
            giderler.Show();
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
    }
}
