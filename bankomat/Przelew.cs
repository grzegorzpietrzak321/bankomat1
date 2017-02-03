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
    public partial class Przelew : Form
    {
        public Form1 form1;
        public Przelew(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //anuluj
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) //wykonaj przelew
        {
            MessageBox.Show("Wykonano przelew na kwotę " + txbKwotaPrzelewu4.Text, "", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void sprawdzAdresata(object sender, EventArgs e)
        {
            try
            {
                form1.przelewAdresat = Convert.ToInt32(txbKonto4.Text);
                using (bankomatEntities context = new bankomatEntities())
                {
                    txbAdresat4.Text = context.users.Where(i => i.id == form1.przelewAdresat).SingleOrDefault().login;
                }
            }
            catch
            {
                if (!(txbKonto4.Text == ""))
                {
                    txbAdresat4.Text = "błędny numer konta";
                }
                else
                {
                    txbAdresat4.Text = "";
                }
            }
        }
    }
}
