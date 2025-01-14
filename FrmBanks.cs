using MyFinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db=new FinancialCrmEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //BANKA BAKİYELERİ:

            var ziraatbankbalance = db.Banks.Where(z => z.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifbankbalance = db.Banks.Where(z => z.BankTitle == "Vakıf Bank").Select(y => y.BankBalance).FirstOrDefault();
            var isbankasibalance = db.Banks.Where(z => z.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblisbankbakiye.Text=isbankasibalance.ToString()+" "+"₺";
            lblvakifbakiye.Text= vakifbankbalance.ToString()+" " + "₺";
            lblziraatbakiye.Text = ziraatbankbalance.ToString()+" " + "₺";

            // BANKA HAREKETLERİ:
            var bankprocess1 = db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            lblbankproces1.Text = bankprocess1.Description + "   " + bankprocess1.Amount +" ₺"+ "   " +  bankprocess1.ProcessDate;

            var bankprocess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblbankproces2.Text = bankprocess2.Description + "   " + bankprocess2.Amount + " ₺" + "   " + bankprocess2.ProcessDate;

            var bankprocess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblbankproces3.Text = bankprocess3.Description + "   " + bankprocess3.Amount + " ₺" + "   " + bankprocess3.ProcessDate;

            var bankprocess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblbankproces4.Text = bankprocess4.Description + "   " + bankprocess4.Amount + " ₺" + "   " + bankprocess4.ProcessDate;

            var bankprocess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblbankproces5.Text = bankprocess5.Description + "   " + bankprocess5.Amount + " ₺" + "   " + bankprocess5.ProcessDate;

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btngiderler_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.ShowDialog();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard fd=new FrmDashboard();
            fd.Show();
            this.Hide();
        }

        private void btnbankalar_Click(object sender, EventArgs e)
        {
            FrmBanks fr = new FrmBanks();
            fr.Show();
            this.Hide();
        }

        private void btnkategoriler_Click(object sender, EventArgs e)
        {
            FrmCategories fc=new FrmCategories();
            fc.Show();
            this.Hide();
        }

        private void btnfaturalar_Click(object sender, EventArgs e)
        {
            FrmBills fb = new FrmBills();
            fb.Show();
            this.Hide();
        }

        private void btnbankahareket_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmb = new FrmBankProcesses(); 
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
