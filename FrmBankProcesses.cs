using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();   

        public void HareketListele()
        {
            var hareket = (from x in db.BankProcesses
                           select new
                           {
                               x.BankProcessId,
                               x.Description,
                               x.ProcessDate,
                               x.ProcessType,
                               x.Amount,
                               x.Banks.BankTitle
                           }).OrderByDescending(z=>z.BankProcessId).ToList();
            dataGridView1.DataSource= hareket;

            cmbbankaad.ValueMember = "BankId";
            cmbbankaad.DisplayMember = "BankTitle";
            cmbbankaad.DataSource = db.Banks.ToList();

            cmbislemtipi.Text = "----- İşlem Tipi Seçiniz! -----";
            cmbbankaad.Text = "----- Banka Seçiniz -----";
            txttutar.Text = "0.00" + " " + "₺";
            txtaciklama.Text = "";
            txtid.Text = "";
            
        }


        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            HareketListele();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtaciklama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dttarih.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbislemtipi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                decimal tutar = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
                txttutar.Text = tutar.ToString() + " " + "₺";
                cmbbankaad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Geçersiz değer bulundu! Lütfen kontrol ediniz.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                HareketListele();
            }


        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            HareketListele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            BankProcesses bp=new BankProcesses();
            bp.Description = txtaciklama.Text;
            bp.ProcessDate=dttarih.Value;
            bp.ProcessType = cmbislemtipi.Text.ToString();
            bp.Amount = Convert.ToDecimal(txttutar.Text);
            bp.BankId =Convert.ToInt32( cmbbankaad.SelectedValue);
            db.BankProcesses.Add(bp);
            db.SaveChanges();
            HareketListele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            var bul = db.BankProcesses.Find(id);
            bul.Description = txtaciklama.Text;
            bul.ProcessDate = dttarih.Value;
            bul.ProcessType = cmbislemtipi.Text.ToString();
            if (decimal.TryParse(txttutar.Text, out decimal amount))
            {
                bul.Amount = amount;
            }
            bul.BankId = Convert.ToInt32(cmbbankaad.SelectedValue);
            db.SaveChanges();
            HareketListele();
        }

        private void btnkategoriler_Click(object sender, EventArgs e)
        {
            FrmCategories fk=new FrmCategories();
            fk.Show();
            this.Hide();
        }

        private void btnbankalar_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnfaturalar_Click(object sender, EventArgs e)
        {
            FrmBills frmBills = new FrmBills();
            frmBills.Show();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngiderler_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void btnbankahareket_Click(object sender, EventArgs e)
        {

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
