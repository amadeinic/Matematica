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
        int contatore;

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
                    TrovaIntervalli(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
                    if (lstDisplay.Items.Count == 0)
                        lstDisplay.Items.Add("Nessuno zer nell'intervallo");
                    Grafico(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
                }
                else
                {
                    MessageBox.Show("L'estremo sinistro non può essere maggiore di quello destro", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {

                MessageBox.Show("Nessuna bisettrice con l'inserimento corrente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        #region Metodi
        public void TrovaIntervalli(double estremoSx, double estremoDx)
        {
            double incremento = (estremoDx - estremoSx) / 100, temp = 0;
            for (double a = estremoSx; a < estremoDx; a += incremento)
            {
                if (temp != 0)
                    if (CalcoloFunzione(temp) * CalcoloFunzione(a) < 0)
                        TrovaZero(temp, a);
                temp = a;
            }
        }
        public void TrovaZero(double a, double b)
        {
            double dif, c;
            int x;

            for (dif = b - a, c = (a + b) / 2, x = 0; dif > Math.Pow(10, -Convert.ToInt32(txtPrec.Text)); x++, dif = b - a, c = (a + b) / 2)
                if (CalcoloFunzione(a) * CalcoloFunzione(c) > 0)
                    a = c;
                else
                    b = c;
            if ((int)CalcoloFunzione(c) == 0)
                lstDisplay.Items.Add(" E' stato trovato uno zero in ascissa: " + c + ". Calcolato in " + x + " ciclo/i");
        }


        public double CalcoloFunzione(double numero)
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
        #endregion

        public double Bisezione(double A, double B, double precisione)
        {
            double differenza;
            double C;
            contatore = 0;
            if (CalcolaFunzione(A) > 0 && CalcolaFunzione(B) < 0 || CalcolaFunzione(A) < 0 && CalcolaFunzione(B) > 0)
            {
                do
                {
                    contatore++;
                    C = (A + B) / 2;
                    if (CalcolaFunzione(A) * CalcolaFunzione(C) < 0)
                    {
                        B = C;
                    }
                    else
                    {
                        A = C;
                    }
                    differenza = B - A;
                }
                while (differenza > precisione);
                return C;
            }
            else
            {
                return 999;
            }
        }

        private double CalcolaFunzione(double variabileInc)
        {
            switch(cmbScelta.SelectedIndex)
            {
                case 0:
                    {
                        return Math.Pow(Math.E, 2 * variabileInc) + variabileInc - 5;                        
                    }
                case 1:
                    {
                        return Math.Pow(variabileInc, 3) + 3 * variabileInc + Math.Sin(variabileInc) - 7;
                    }
                case 2:
                    {
                        return Math.Pow(variabileInc, 3) - 5 * variabileInc - 1;
                    }             
            }
            return 999;
        }
        public void Grafico(double estremoSx, double estremoDx)
        {
            crtGrafico.Series.Clear();
            crtGrafico.Series.Add(cmbScelta.Text);
            crtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            double incremento = (estremoDx - estremoSx) / 50;
            for (double a = estremoSx; a < estremoDx; a += incremento)
            {
                crtGrafico.Series[0].Points.AddXY(a, CalcoloFunzione(a));
            }
        }

        private void txtPrec_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
