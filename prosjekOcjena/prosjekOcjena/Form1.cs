using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosjekOcjena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ocjena;
        double zbrojOcjena = 0;
        double prosjek = 0;
        double brojOcjena = 0;


        private void BtnUnos_Click(object sender, EventArgs e)
        {
            try
            {

                ocjena = Convert.ToInt32(txtBox.Text);
                if (ocjena < 1 || ocjena > 5)
                {
                    MessageBox.Show("Upišite ispravnu ocjenu", "Pogreška");
                }
                else
                {
                    brojOcjena++;
                    zbrojOcjena += ocjena;
                    txtIspis.AppendText(ocjena + "\r\n");

                    DialogResult odgovor = MessageBox.Show("Želite li unesti još jednu ocjenu?",
                    "Izbor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (odgovor == DialogResult.Yes)
                    {
                        txtBox.Clear();
                    }
                    else
                    {
                        prosjek = zbrojOcjena / brojOcjena;
                        txtIspis.Text = "Prosjek je: " + prosjek;
                    }
                }
            }
            catch(Exception greska)
            {
                MessageBox.Show("Upišite ispravnu ocjenu", "Pogreška");
            }
        }
    }
}
