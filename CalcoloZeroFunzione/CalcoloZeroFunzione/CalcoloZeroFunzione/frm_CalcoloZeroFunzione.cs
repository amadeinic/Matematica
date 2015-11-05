using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CalcoloZeroFunzione
{
    public partial class frm_CalcoloZeroFunzione : Form
    {
        public frm_CalcoloZeroFunzione()
        {
            InitializeComponent();
        }
        private void btn_calcola_Click(object sender, EventArgs e)
        {
            try
            {
                lstLista.Items.Clear();
                if (Convert.ToDouble(txtB_a.Text) < Convert.ToDouble(txtB_b.Text))
                {
                    TrovaIntervalli(Convert.ToDouble(txtB_a.Text), Convert.ToDouble(txtB_b.Text));
                    if (lstLista.Items.Count == 0)
                        lstLista.Items.Add("La bisezione non presenta zero in questo intervallo");
                    Grafico(Convert.ToDouble(txtB_a.Text), Convert.ToDouble(txtB_b.Text));
                }
                else
                {
                    MessageBox.Show("L'estremo sinistro non può essere maggiore di quello destro", "ALT!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {

                MessageBox.Show("Impossibile calcolare la bisetrice con questi dati!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
}
        public void TrovaZero(double a, double b)
        {
            double dif, c;
            int x;

            for (dif = b - a, c = (a + b) / 2, x = 0; dif > Math.Pow(10, -Convert.ToInt32(nUD.Value)); x++, dif = b - a, c = (a + b) / 2)
                if (CalcoloFunzione(a) * CalcoloFunzione(c) > 0)
                    a = c;
                else
                    b = c;
            if ((int)CalcoloFunzione(c) == 0)
                lstLista.Items.Add(" E' stato trovato uno zero in ascissa: " + c + ". Calcolato in " + x +" ciclo/i");
        }
        public double CalcoloFunzione(double numero)
        {
            switch (cmb_funzione.SelectedIndex)
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
        public void Grafico(double estremoSx, double estremoDx)
        {
            chrtGrafico.Series.Clear();
            chrtGrafico.Series.Add(cmb_funzione.Text);
            chrtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            double incremento = (estremoDx - estremoSx) / 50;
            for (double a = estremoSx; a < estremoDx; a += incremento)
            {
                chrtGrafico.Series[0].Points.AddXY(a, CalcoloFunzione(a));
            }
        }
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
        private void frm_CalcoloZeroFunzione_Load(object sender, EventArgs e)
        {
            cmb_funzione.SelectedIndex = 0;
        }
    }
}
