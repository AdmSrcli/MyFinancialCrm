using MyFinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db=new FinancialCrmEntities();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalbalance = db.Banks.Sum(z => z.BankBalance).Value;
            lbltotalbalance.Text = totalbalance.ToString() + " " + " ₺";

            var sonhavale=db.BankProcesses.OrderByDescending(z=>z.BankProcessId).Take(1).Select(x=>x.Amount).FirstOrDefault();
            lblhavalesonbakiye.Text=sonhavale.ToString()+" ₺";

            //chart1 kodları 

            var bankdata = db.Banks.Select(z => new
            {
                z.BankTitle,
                z.BankBalance,
            }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Bankalar");
            foreach (var item in bankdata)
            { 
            series.Points.AddXY(item.BankTitle,item.BankBalance);
            
            }

            //chart 2 Kodları 

            var billdata = db.Bills.Select(z => new
            {
                z.BillTitle,
                z.BillAmount
            }).ToList();

            chart2.Series.Clear();
            
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie);
            foreach(var item in billdata)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
            
                    






        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count % 4 == 1)
            {
                var elektrik = db.Bills.Where(x => x.BillTitle == "Elektrik faturası").Select(z => z.BillAmount).FirstOrDefault();
                lblbilltitle.Text = "Elektrik faturası";
                lblbillamount.Text = elektrik.ToString()+" ₺";
            }

            if (count % 4 == 2)
            {
                var Dogalgaz = db.Bills.Where(x => x.BillTitle == "Doğalgaz faturası").Select(z => z.BillAmount).FirstOrDefault();
                lblbilltitle.Text = "Doğalgaz faturası";
                lblbillamount.Text = Dogalgaz.ToString() + " ₺";
            }
            if (count % 4 == 3)
            {
                var internet = db.Bills.Where(x => x.BillTitle == "İnternet faturası ").Select(z => z.BillAmount).FirstOrDefault();
                lblbilltitle.Text = "İnternet faturası ";
                lblbillamount.Text = internet.ToString() + " ₺";
            }
            if (count % 4 == 0)
            {
                var su = db.Bills.Where(x => x.BillTitle == "Su faturası ").Select(z => z.BillAmount).FirstOrDefault();
                lblbilltitle.Text = "Su faturası ";
                lblbillamount.Text = su.ToString() + " ₺";
            }

        }

        private void btnbankalar_Click(object sender, EventArgs e)
        {
            FrmBanks fr = new FrmBanks();
            fr.Show();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard fd = new FrmDashboard();
            fd.Show();
            this.Hide();
        }

        private void btngiderler_Click(object sender, EventArgs e)
        {
            FrmSpending fs=new FrmSpending();
            fs.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnkategoriler_Click(object sender, EventArgs e)
        {
            FrmCategories fc=new FrmCategories();
            fc.Show();
            this.Hide();
        }

        private void btnfaturalar_Click(object sender, EventArgs e)
        {
            FrmBills bills = new FrmBills();
            bills.Show();
            this.Hide();
        }

        private void btnbankahareket_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmb=new FrmBankProcesses();
            frmb.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnayarlar_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }
    }
}
