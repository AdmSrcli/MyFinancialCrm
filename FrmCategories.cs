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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db=new FinancialCrmEntities();

        public void KategoriListele()
        {
            dataGridView1.DataSource = (from x in db.Categoryes
                                        select new
                                        {
                                            x.CategoryId,
                                            x.CategoryName
                                        }).OrderByDescending(z=>z.CategoryId).ToList();
        }
        private void btnbankalar_Click(object sender, EventArgs e)
        {
            FrmBanks fr = new FrmBanks();
            fr.Show();
            this.Hide();
        }

        private void btngiderler_Click(object sender, EventArgs e)
        {
            FrmSpending fs= new FrmSpending();
            fs.Show();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {

            FrmDashboard fd = new FrmDashboard();
            fd.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnkategoriler_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                txtad.Text = "";
                txtid.Text = "";
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Categoryes ct=new Categoryes();
            ct.CategoryName = txtad.Text;
            db.Categoryes.Add(ct);
            db.SaveChanges();
            KategoriListele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {           
              if (txtid.Text != "")
                {
                    if (int.TryParse(txtid.Text, out int id))
                    {
                        var bul = db.Categoryes.Find(id);

                        if (bul != null)
                        {
                            bul.CategoryName = txtad.Text;
                            db.SaveChanges();
                            KategoriListele();
                        }
                        else
                        {
                            MessageBox.Show("Bu Id de Kategori Bulunamadı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Id formatı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }

        private void btnfaturalar_Click(object sender, EventArgs e)
        {
            FrmBills fb = new FrmBills();
            fb.Show();
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
