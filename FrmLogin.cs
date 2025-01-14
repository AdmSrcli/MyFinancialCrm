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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        FinancialCrmEntities db= new FinancialCrmEntities();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.PasswordChar = default;
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != "" && txtuser.Text != "")
            {

                var kullanici = txtuser.Text.ToString();
                var sifre = txtpassword.Text.ToString();

                if (db.Users.Where(x => x.Username == kullanici).Any() && db.Users.Where(z => z.Password == sifre).Any())
                {
                    FrmDashboard fk = new FrmDashboard();
                    fk.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı yada Parola. \n \n  Lütfen Kontrol Edip Tekrar Deneyiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtuser.Text = "";
                txtpassword.Text = "";
            }
        }
    }
}
