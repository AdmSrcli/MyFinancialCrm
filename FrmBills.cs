using System;
using System.Linq;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db=new FinancialCrmEntities();

        

        private void FrmBills_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            lbltoplamfatura.Text = db.Bills.Where(x => x.BillId != null).Sum(v => v.BillAmount).ToString()+" "+"₺";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtbaslik.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmiktar.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtperiyot.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnyeniödeme_Click(object sender, EventArgs e)
        {
            string title=txtbaslik.Text;
            decimal amount= decimal.Parse(txtmiktar.Text);
            string period = txtperiyot.Text;

            Bills bl= new Bills();
            bl.BillTitle = title;
            bl.BillAmount = amount; 
            bl.BillPeriod = period;
            db.Bills.Add(bl);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Şekilde Gerçekleşti","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnödemesil_Click(object sender, EventArgs e)
        {
            Bills bl= new Bills();
            int id=int.Parse( txtid.Text);
            var removevalue=db.Bills.Find(id);
            db.Bills.Remove(removevalue);
            db.SaveChanges();

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnödemeguncelle_Click(object sender, EventArgs e)
        {
            int id=int.Parse( txtid.Text);

            var bul=db.Bills.Find(id);
            bul.BillTitle=txtbaslik.Text;
            bul.BillAmount = decimal.Parse(txtmiktar.Text);
            bul.BillPeriod=txtperiyot.Text;
            db.SaveChanges();

            var values = db.Bills.ToList(); dataGridView1.DataSource = values;

        }

        private void btnbankalar_Click(object sender, EventArgs e)
        {
            FrmBanks fr=new FrmBanks();
            fr.Show();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard fd = new FrmDashboard();
            fd.Show();
            this.Hide();
        }

        private void btnfaturalar_Click(object sender, EventArgs e)
        {
            FrmBills fb = new FrmBills();
            fb.Show();
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
