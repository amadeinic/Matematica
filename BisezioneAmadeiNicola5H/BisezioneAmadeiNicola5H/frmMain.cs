using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisezioneAmadeiNicola5H
{
    public partial class frmMain : Form
    {    
       

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtPrec.Text = "10";
            cmbScelta.SelectedIndex = 0;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
        
            try
            {
                if (Convert.ToInt32(txtPrec.Text) > 13 || Convert.ToInt32(txtPrec.Text) < 1)
                {
                    txtPrec.Text = "10";
                }
            }
            catch (FormatException erore)
            {
                txtPrec.Text = "10";
                MessageBox.Show("La precisione deve essere compresa tra 1 e 15.\n\nOriginal message:\n" + erore.Message, "Attenzione!");
            }



            try
            {
                lstDisplay.Items.Clear();
                if (Convert.ToDouble(txtA.Text) < Convert.ToDouble(txtB.Text))
                {

                    Intervallatore(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));

                    if (lstDisplay.Items.Count == 0)
                        lstDisplay.Items.Add("Nessuno zero nell'intervallo specificato");
                    Grafico(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
                }
                else
                {
                    MessageBox.Show("L'estremo sinistro non può essere maggiore di quello destro", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {

                MessageBox.Show("Dati non validi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

    
        public void Intervallatore(double estremoSx, double estremoDx)
        {
            double incremento = (estremoDx - estremoSx) / 100, temp = 0;
            for (double a = estremoSx; a < estremoDx; a += incremento)
            {
                if (temp != 0)
                    if (Funzione(temp) * Funzione(a) < 0)
                    {
                        if (rdbBisezione.Checked)
                        {
                            Bisezione(temp, a);
                        }
                        if(rdbTangenti.Checked)
                        {
                            Console.WriteLine("Eccomi");
                            Tangenti(temp, a);
                        }
                    }
                temp = a;
            }
        }

        public void Bisezione(double a, double b)
        {
            double differenza, c;
            int cont;

            for (differenza = b - a, c = (a + b) / 2, cont = 0; differenza > Math.Pow(10, -Convert.ToInt32(txtPrec.Text)); cont++, differenza = b - a, c = (a + b) / 2)
            {
                if (Funzione(a) * Funzione(c) > 0)
                    a = c;
                else
                    b = c;
            }
            StampaZero(c, cont);
        }

        public void Tangenti(double a, double b)
        {
            int cont = 0;
            double c = a;
            for (double dif = 1; dif > Math.Pow(10, -Convert.ToInt32(txtPrec.Text)); cont++)
            {
                c = c - (Funzione(c) / Derivata(c));
                dif = Math.Abs(Funzione(c) / Derivata(c));
            }
            StampaZero(c, cont);

        }

        public double Funzione(double numero)
        {
            switch (cmbScelta.SelectedIndex)
            {
                case 0: return Math.Pow(numero, 3) + numero - 7;
                case 1: return Math.Pow(Math.E, numero) - 3 * numero - 5;
                case 2: return 2 * numero + Math.Sin(numero) - 8;
                case 3: return Math.Pow(numero, 3) + (3 * numero) + Math.Sin(numero) - 7;
                case 4: return Math.Pow(Math.E, 2 * numero) + numero - 5;
                case 5: return Math.Pow(numero, 3) - (5 * numero) - 1;
                default: return 0;
            }
        }

        public double Derivata(double numero)
        {
            switch (cmbScelta.SelectedIndex)
            {
                //case 0: return Math.Pow(numero, 3) + numero - 7;
                //case 1: return Math.Pow(Math.E, numero) - 3 * numero - 5;
                //case 2: return 2 * numero + Math.Sin(numero) - 8;
                //case 3: return Math.Pow(numero, 3) + (3 * numero) + Math.Sin(numero) - 7;
                //case 4: return Math.Pow(Math.E, 2 * numero) + numero - 5;
                case 5: return 3* Math.Pow(numero, 2) - 5;
                default: return 0;
            }
        }
       
        public void StampaZero(double value, int ncicli)
        {
            lstDisplay.Items.Add("Zero di funzione in: " + value + " Trovato in " + ncicli + " iterazioni.");
        }

        public void Grafico(double sinistra, double destra)
        {
            //preparo
            crtGrafico.Series.Clear();
            crtGrafico.Series.Add(cmbScelta.Text);
            crtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            double incremento = (destra - sinistra) / 50;
            for (double a = sinistra; a < destra; a += incremento)
            {
                crtGrafico.Series[0].Points.AddXY(a, Funzione(a));
            }
        }
    }
}
