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
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db=new FinancialCrmEntities();

        public void HarcamaListele()
        {
            var listele = (from x in db.Spendings
                           select new
                           {
                               x.SpendingId,
                               x.SpendingTitle,
                               x.SpendingAmount,
                               x.SpendingDate,
                               x.Categoryes.CategoryName
                           }).OrderByDescending(z => z.SpendingId).ToList();
            dataGridView1.DataSource= listele;

            cmbkategori.ValueMember = "CategoryId";
            cmbkategori.DisplayMember = "CategoryName";
            cmbkategori.DataSource = db.Categoryes.ToList();
            cmbkategori.Text = "----- Kategori Seçiniz -----";
            txttutar.Text = "0.00";

            lbltopharcama.Text=db.Spendings.Where(z=>z.CategoryId!=null).Sum(x=>x.SpendingAmount).ToString()+" "+"₺";

            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSpending_Load(object sender, EventArgs e)
        {
            HarcamaListele();
        }

        private void btnkategoriler_Click(object sender, EventArgs e)
        {
            FrmCategories fc=new FrmCategories();
            fc.Show();
            this.Hide();
        }

        private void btnbankalar_Click(object sender, EventArgs e)
        {
            FrmBanks fb=new FrmBanks();
            fb.Show();
            this.Hide();
        }

        private void btnfaturalar_Click(object sender, EventArgs e)
        {
            FrmBills fb=new FrmBills();
            fb.Show();
            this.Hide();
        }

        private void btnbankahareket_Click(object sender, EventArgs e)
        {
            FrmBankProcesses fm=new FrmBankProcesses();
            fm.Show();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard fd=new FrmDashboard();
            fd.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            HarcamaListele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Spendings sp=new Spendings();
            sp.SpendingTitle=txtdetay.Text;
            sp.SpendingAmount =Convert.ToDecimal( txttutar.Text);
            sp.SpendingDate=Convert.ToDateTime( dttarih.Text);
            sp.CategoryId =Convert.ToInt32( cmbkategori.SelectedValue);
            db.Spendings.Add(sp);
            db.SaveChanges();
            HarcamaListele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                int id = Convert.ToInt32(txtid.Text);
               var bul= db.Spendings.Find(id);
                if( bul != null )
                {
                    bul.SpendingTitle = txtdetay.Text;
                    bul.SpendingAmount = Convert.ToDecimal(txttutar.Text);
                    bul.SpendingDate = Convert.ToDateTime(dttarih.Text);
                    bul.CategoryId = Convert.ToInt32(cmbkategori.SelectedValue);
                    db.SaveChanges();
                    HarcamaListele();
                }
                else
                {
                    MessageBox.Show("Aranan Kayıt Bulunamadı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HarcamaListele();
                }

            }
            else
            {
                HarcamaListele();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text= Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value).ToString();
            txtdetay.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttutar.Text = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value).ToString();
            dttarih.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value).ToString();
            cmbkategori.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnayarlar_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }
    }
}
