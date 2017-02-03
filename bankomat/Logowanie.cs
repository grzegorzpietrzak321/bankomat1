using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace bankomat
{
    public partial class Logowanie : Form
    {
        public Form1 form1;
        private string tmp1 = null;
        private string tmp2 = null;
        public Logowanie(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void btnZaloguj2_Click(object sender, EventArgs e)
        {
            tmp1 = textBox1.Text;
            tmp2 = textBox2.Text;
            using (bankomatEntities contextBankomatEntities = new bankomatEntities())
            {
                user logowanieUser = contextBankomatEntities.users.Where(i => i.login == tmp1).SingleOrDefault();
                try
                {
                    if (Equals(logowanieUser.passhash.ToString(), tmp2))
                    {
                        MessageBox.Show("Zalogowano", "My Application",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        form1.bLogged = true;
                        form1.username = tmp1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Błędne hasło", "My Application",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch
                {
                    MessageBox.Show("Nie ma takiego usera", "My Application",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
