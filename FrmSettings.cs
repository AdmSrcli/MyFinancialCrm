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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db=new FinancialCrmEntities();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
           
            FrmCategories fr=new FrmCategories();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmevcutsifre.Text != "" && txtusername.Text != "")
            {
                var user = txtusername.Text;
                var password = txtmevcutsifre.Text;
                var bul = db.Users.SingleOrDefault(u => u.Username == user && u.Password == password); ;
                if (bul != null)
                {
                    if (bul.Username == user && bul.Password == txtmevcutsifre.Text)
                    {
                        bul.Password = txtnewpassword.Text;
                        db.SaveChanges();
                        MessageBox.Show(" Parola Başarılı Şekilde  Güncellendi! ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Hatalı Kullanıcı Yada Parola Girdiniz. \n\n Lütfen Kontrol Edip Tekrar Deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Yada Parola Girdiniz. \n\n Lütfen Kontrol Edip Tekrar Deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           

        }
    }
}
