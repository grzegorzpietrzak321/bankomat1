using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankomat
{
    public partial class Wyplata : Form
    {
        public Form1 form1;
        private user logowanieUser;

        public Wyplata(Form1 form1)
        {
            using (bankomatEntities wyplataBankomatEntities = new bankomatEntities())
            {
                logowanieUser =
                    wyplataBankomatEntities.users.Where(i => i.login == form1.username).SingleOrDefault();

            }
            this.form1 = form1;
            InitializeComponent();
        }

        public void pobierzZsalda(decimal kwotaDecimal)
        {
            if (logowanieUser.accbalance > kwotaDecimal)
            {
                logowanieUser.accbalance -= kwotaDecimal;
                using (bankomatEntities wyp = new bankomatEntities())
                {
                    wyp.users.Attach(logowanieUser);
                    wyp.Entry(logowanieUser).State = EntityState.Modified;
                    wyp.SaveChanges();
                }
                MessageBox.Show("Wypłacam pieniądze w kwocie: " + kwotaDecimal.ToString(),
                    "Wypłata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Brak wystarczających środków na koncie",
                    "Wypłata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btninnakwota3_Click(object sender, EventArgs e)
        {
            btn10pln3.Visible = false;
            btn20pln3.Visible = false;
            btn50pln3.Visible = false;
            btn100pln3.Visible = false;
            btn200pln3.Visible = false;
            btn10pln3.Enabled = false;
            btn20pln3.Enabled = false;
            btn50pln3.Enabled = false;
            btn100pln3.Enabled = false;
            btn200pln3.Enabled = false;
            btninnakwota3.Enabled = false;
            btninnakwota3.Visible = false;
            txbinnakwota3.Visible = true;
            txbinnakwota3.Enabled = true;
            btninnakwotaOK3.Visible = true;
            btninnakwotaOK3.Enabled = true;
            btninnakwotaAnuluj3.Visible = true;
            btninnakwotaAnuluj3.Enabled = true;
        }

        private void btninnakwotaOK3_Click(object sender, EventArgs e)
        {
            try
            {
                form1.KwotaWyplatyDecimal = Convert.ToDecimal(txbinnakwota3.Text);
                if (!(form1.KwotaWyplatyDecimal%10 == 0))
                {
                    MessageBox.Show("Wprowadzona kwota musi być wielokrotnością 10.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (bankomatEntities wyplataBankomatEntities = new bankomatEntities())
                    {
                        var logowanieUser =
                            wyplataBankomatEntities.users.Where(i => i.login == form1.username).SingleOrDefault();
                    }
                    if (true)
                    {
                        try
                        {
                            pobierzZsalda((int)form1.KwotaWyplatyDecimal);
                        }
                        catch
                        {

                        }
                    }
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Błędna kwota, wpisz ponownie.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btninnakwotaAnuluj3_Click(object sender, EventArgs e)
        {
            btn10pln3.Visible = true;
            btn20pln3.Visible = true;
            btn50pln3.Visible = true;
            btn100pln3.Visible = true;
            btn200pln3.Visible = true;
            btn10pln3.Enabled = true;
            btn20pln3.Enabled = true;
            btn50pln3.Enabled = true;
            btn100pln3.Enabled = true;
            btn200pln3.Enabled = true;
            btninnakwota3.Enabled = true;
            btninnakwota3.Visible = true;
            txbinnakwota3.Visible = false;
            txbinnakwota3.Enabled = false;
            btninnakwotaOK3.Visible = false;
            btninnakwotaOK3.Enabled = false;
            btninnakwotaAnuluj3.Visible = false;
            btninnakwotaAnuluj3.Enabled = false;
        }

        private void btn10pln3_Click(object sender, EventArgs e)
        {
            pobierzZsalda(10);
        }

        private void btn20pln3_Click(object sender, EventArgs e)
        {
            pobierzZsalda(20);
        }

        private void btn50pln3_Click(object sender, EventArgs e)
        {
            pobierzZsalda(50);
        }

        private void btn100pln3_Click(object sender, EventArgs e)
        {
            pobierzZsalda(100);
        }

        private void btn200pln3_Click(object sender, EventArgs e)
        {
            pobierzZsalda(200);
        }
    }
}
