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
       //Nicola Amadei 2016

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtPrec.Text = "10";
            cmbScelta.SelectedIndex = 0;
            txtA.Text = "-10";
            txtB.Text = "10";
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
                    EseguiSuIntervallo(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));                    
                    Grafico(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
                    if (lstDisplay.Items.Count == 0)
                    {
                        lstDisplay.Items.Add("Non ho trovato nessuno zero.");
                    }
                }
                else
                {
                    MessageBox.Show("L'estremo sinistro non può essere maggiore di quello destro", "Non posso continuare...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {

                MessageBox.Show("Dati non validi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

    
        public void EseguiSuIntervallo(double estremoSx, double estremoDx)
        {
            double incremento = (estremoDx - estremoSx) / 100, temp = 0;
            for (double a = estremoSx; a < estremoDx; a += incremento)
            {
                if (temp != 0)
                    if (f(temp) * f(a) < 0)
                    {
                        if (rdbBisezione.Checked)
                        {
                            Bisezione(temp, a);
                        }
                        if(rdbTangenti.Checked)
                        {
                            Console.WriteLine("Eccomi");
                            Tangenti(temp);
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
                if (f(a) * f(c) > 0)
                    a = c;
                else
                    b = c;
            }
            StampaZero(c, cont);
        }

        public void Tangenti(double a)
        {
            int cont = 0;            
            for (double differenza = 1; differenza > Math.Pow(10, -Convert.ToInt32(txtPrec.Text)); cont++)
            {
                a = a - (f(a) / Derivata(a));
                differenza = Math.Abs(f(a) / Derivata(a));
            }
            StampaZero(a, cont);

        }

        public double f(double numero)
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
                case 0: return 3* Math.Pow(numero, 2) + 1;
                case 1: return Math.Pow(Math.E, numero) - 3;
                case 2: return 2 + Math.Cos(numero);
                case 3: return 3*Math.Pow(numero, 2) + 3 + Math.Cos(numero);
                case 4: return Math.Pow(Math.E, 2 * numero) + 1;
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
                crtGrafico.Series[0].Points.AddXY(a, f(a));
            }
        }
    }
}
