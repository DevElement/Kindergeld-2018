using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergeldrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choosechild_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.choosechild.SelectedIndex)
            {
                case 0:
                    this.labchild.Text = "Sie erhalten 0 EUR Kindergeld, da Sie keine Kinder haben.";
                    break;
                case 1:
                    this.labchild.Text = "Sie erhalten für Ihr Kind 194 EUR Kindergeld.";
                    break;
                case 2:
                    this.labchild.Text = "Sie erhalten für Ihre beiden Kinder jeweils 194 EUR Kindergeld." + Environment.NewLine + "Insgesamt bekommen Sie pro Monat 388 EUR.";
                    break;
                case 3:
                    this.labchild.Text = "Sie erhalten für Ihre beiden ersten Kinder jeweils 194 EUR." + Environment.NewLine + "Für Ihr drittes Kind 200 EUR Kindergeld." + Environment.NewLine + "Insgesamt bekommen Sie pro Monat 588 EUR Kindergeld.\n";
                    break;
                case 4:
                    this.labchild.Text = "Sie erhalten für Ihre beiden ersten Kinder jeweils 194 EUR." + Environment.NewLine + "Für Ihr drittes Kind 200 EUR und für das vierte Kind 225 EUR Kindergeld." + Environment.NewLine + "Insgesamt bekommen Sie pro Monat 813 EUR Kindergeld.";
                    break;
                case 5:
                    this.labchild.Text = "Sie erhalten für Ihre beiden ersten Kinder jeweils 194 EUR." + Environment.NewLine + "Für Ihr drittes Kind 200 EUR und für das vierte und fünfte Kind jeweils 225 EUR Kindergeld." + Environment.NewLine + "Insgesamt bekommen Sie pro Monat 1.038 EUR Kindergeld.";
                    break;
                case 6:
                    this.labchild.Text = "Sie erhalten für Ihre beiden ersten Kinder jeweils 194 EUR." + Environment.NewLine + "Für Ihr drittes Kind 200 EUR und für das vierte, fünfte und sechste Kind jeweils 225 EUR Kindergeld." + Environment.NewLine + "Insgesamt bekommen Sie pro Monat 1.263 EUR Kindergeld.";
                    break;
                case 7:
                    this.labchild.Text = "Sie erhalten für Ihre beiden ersten Kinder jeweils 194 EUR." + Environment.NewLine + "Für Ihr drittes Kind 200 EUR und für das vierte bis siebente Kind jeweils 225 EUR Kindergeld." + Environment.NewLine + "Insgesamt bekommen Sie pro Monat 1.488 EUR Kindergeld.";
                    break;
                case 8:
                    this.labchild.Text = "Sie erhalten für Ihre beiden ersten Kinder jeweils 194 EUR." + Environment.NewLine + "Für Ihr drittes Kind 200 EUR und für das vierte bis achte Kind jeweils 225 EUR Kindergeld." + Environment.NewLine + "Insgesamt bekommen Sie pro Monat 1.713 EUR Kindergeld.";
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.develement.de");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.develement.de");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.develement.de");
        }
    }
}
