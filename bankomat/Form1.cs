using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankomat
{
    public partial class Form1 : Form
    {
        public Form1 form1;
        public bool bLogged = false;
        public string username = null;
        public decimal? KwotaWyplatyDecimal = null;
        public decimal? KwotaPrzelewuDecimal = null;
        public int przelewAdresat = 0;
        public string przelewUsername = null;

        /// <summary>
        /// Wywołanie okna logowania
        /// </summary>
        public void zaloguj()
        {
            Logowanie okienkoLogowanie = new Logowanie(this);
            okienkoLogowanie.Owner = this;
            okienkoLogowanie.ShowDialog();
        }

        /// <summary>
        /// Pobranie stanu konta z bazy SQL dla danego usera
        /// jeżeli nie jest zalogowany następuje prośba o zalogowanie
        /// </summary>
        public void sprawdzbalance()
        {
            using (bankomatEntities pobierzBankomatEntities = new bankomatEntities())
            {
                var tmp3 = pobierzBankomatEntities.users.Where(p => p.login == username)
                    .SingleOrDefault()
                    .accbalance.ToString();
                MessageBox.Show("Stan Twojego konta to: " + tmp3
                    , "Stan konta", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        /// <summary>
        /// Wywołanie okna pozwalającego wypłacić pieniądze
        /// </summary>
        public void wyplackase()
        {
            Wyplata okienkoWyplata = new Wyplata(this);
            okienkoWyplata.Owner = this;
            okienkoWyplata.Show();
        }

        public void przelew()
        {
            Przelew okienkoPrzelew = new Przelew(this);
            okienkoPrzelew.Owner = this;
            okienkoPrzelew.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Zamknięcie aplikacji z potwierdzeniem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e) //zamknij bankomat
        {
            if (MessageBox.Show("Bye bye?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Sprawdzenie stanu konta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) 
        {
            if (!bLogged)
            {
                if (MessageBox.Show("Aby sprawdzić stan konta należy się zalogować", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) zaloguj();
            }
            else sprawdzbalance();
        }

        /// <summary>
        /// Wypłata pieniędzy z konta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWyplac1_Click(object sender, EventArgs e) 
        {
            if (!bLogged)
            {
                if (
                    MessageBox.Show("Aby wypłacić pieniądze należy się zalogować", "", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK) zaloguj();
            }
            else wyplackase();
        }

        /// <summary>
        /// Wylogowanie użytkownika
        /// jeżeli nie jest zalogowany pojawia się komunikat 
        /// po wylogowaniu komunikat o poprawnym wylogowaniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWyloguj1_Click(object sender, EventArgs e)
        {
            if (!bLogged)
            {
                MessageBox.Show("Uzytkownik nie jest zalogowany", "Wyloguj", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                bLogged = false;
                username = null;
                MessageBox.Show("Uzytkownik został poprawnie wylogowany", "Wyloguj", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnPrzelew1_Click(object sender, EventArgs e)
        {
            if (!bLogged)
            {
                if (
                    MessageBox.Show("Aby wykonać przelew należy się zalogować", "", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK) zaloguj();
            }
            else
            {
                przelew();
            }
           
        }
    }
}
