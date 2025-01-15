using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        FincancialCrmDbEntities db = new FincancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri

            var garanti = db.Banks.Where(x => x.BankTitle == "Garanti").Select(y => y.BankBalance).FirstOrDefault();
            var vakifbank = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var akbank = db.Banks.Where(x => x.BankTitle == "Akbank").Select(y => y.BankBalance).FirstOrDefault();

            lblziraatBalance.Text = garanti.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifbank.ToString() + " ₺";
            lblAkbankBalance.Text = akbank.ToString() + " ₺";


            //Banka Hareketleri
            var bankProcess = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess.Descripiton + " " + bankProcess.Amount + " " + bankProcess.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Descripiton + " " + bankProcess2.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Descripiton + " " + bankProcess3.Amount + " " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Descripiton + " " + bankProcess4.Amount + " " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Descripiton + " " + bankProcess5.Amount + " " + bankProcess5.ProcessDate;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFaturalar frmFaturalar = new FrmFaturalar();
            frmFaturalar.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FrmFaturalar frmOdemeler = new FrmFaturalar();
            frmOdemeler.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmAyarlar frmAyarlar = new FrmAyarlar();
            frmAyarlar.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategori frmKategori = new FrmKategori();
            frmKategori.Show();
            this.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmFaturalar frmFaturalar = new FrmFaturalar();
            frmFaturalar.Show();
            this.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
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
    }
}
