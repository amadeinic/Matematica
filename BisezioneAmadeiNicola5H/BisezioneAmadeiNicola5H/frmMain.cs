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
        double A, B, C, precisione, differenza;
        int contatore;

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtPrec.Text = "0,00005";
            cmbScelta.SelectedIndex = 0;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            contatore = 0;
            A = Convert.ToDouble(txtA.Text);
            B = Convert.ToDouble(txtB.Text);
            precisione = Convert.ToDouble(txtPrec.Text);
            if (calcolaFunzione(A) > 0 && calcolaFunzione(B) < 0 || calcolaFunzione(A) < 0 && calcolaFunzione(B) > 0)
            {
                do
                {
                    contatore++;
                    C = (A + B) / 2;
                    if (calcolaFunzione(A) * calcolaFunzione(C) < 0)
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
                lstDisplay.Items.Clear();
                lstDisplay.Items.Add("Funzione: " + cmbScelta.Text);
                lstDisplay.Items.Add("Risultato: " + C);
                lstDisplay.Items.Add("Calcolato in " + contatore + " cicli.");
            }
            else
            {
                lstDisplay.Items.Clear();
                lstDisplay.Items.Add("Nessuno zero di funzione nell'intervallo " + A + "-" + B);
            }
            //double passo = B - A / 50;
            //double x, y;
            //while()
            //{
            //    y = calcolaFunzione(i);
            //    crtGrafico.Series[0].Points.Add(i, y);
            //}
        }
        private double calcolaFunzione(double variabileInc)
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
                default:
                    {
                        return 99;
                    }
            }
        }
    }
}
