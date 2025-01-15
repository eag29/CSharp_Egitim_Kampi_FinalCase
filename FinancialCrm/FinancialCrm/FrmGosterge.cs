using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmGosterge : Form
    {
        public FrmGosterge()
        {
            InitializeComponent();
        }

        FincancialCrmDbEntities db = new FincancialCrmDbEntities();
        int count = 0;

        private void FrmGosterge_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lbltotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcedureAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lbllastBankProcessAmount.Text = lastBankProcedureAmount.ToString() + " ₺";


            //Chart1

            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");

            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //Chart1

            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount,
            }).ToList();

            chart2.Series.Clear();
            var series2 =  chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;

            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count % 4 == 1)
            {
                var telefonFaturasi = db.Bills.Where(x => x.BillTitle == "Telefon Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Telefon Faturası";
                lblBillAmount.Text = telefonFaturasi.ToString() + " ₺";
            }

            if (count % 4 == 2)
            {
                var digiturkFaturasi = db.Bills.Where(x => x.BillTitle == "Digiturk Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Digiturk Faturası";
                lblBillAmount.Text = digiturkFaturasi.ToString() + " ₺";
            }

            if (count % 4 == 3)
            {
                var ytOdemesi = db.Bills.Where(x => x.BillTitle == "Youtube Ödemesi").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Youtube Ödemesi";
                lblBillAmount.Text = ytOdemesi.ToString() + " ₺";
            }

            if (count % 4 == 0)
            {
                var telefonFaturasi = db.Bills.Where(x => x.BillTitle == "Telefon Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Telefon Faturası";
                lblBillAmount.Text = telefonFaturasi.ToString() + " ₺";
            }
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategori frmKategori = new FrmKategori();
            frmKategori.Show();
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
            FrmFaturalar frmOdemeler = new FrmFaturalar();
            frmOdemeler.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
