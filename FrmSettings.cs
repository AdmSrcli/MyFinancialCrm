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

        private void rdkoyutema_CheckedChanged(object sender, EventArgs e)
        {
            FrmSettings fs=new FrmSettings();
            fs.BackColor=Color.Black;
            fs.ForeColor=Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rdkoyutema.Checked = false;
            rdaciktema.Checked = false;
            rdingilizce.Checked = false;
            rdturkce.Checked = false;
            FrmCategories fr=new FrmCategories();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdkoyutema.Checked )
            {
                FrmSettings fs = new FrmSettings();
                fs.BackColor = Color.Black;
                fs.ForeColor = Color.White;
            }
            if (rdaciktema.Checked )
            {
                FrmSettings fs = new FrmSettings();
                fs.BackColor = Color.White;
                fs.ForeColor = Color.Black;
            }
            if(rdturkce.Checked )
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("tr-TR"));
            }
            if (rdingilizce.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("df-DF"));
            }
            Application.Exit();
        }
    }
}
