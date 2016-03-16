using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace amadei.nicola._5H.IntegraleDefinito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbFunzione.Items.Add("4/(x^2+4)");
            cmbFunzione.Items.Add("e^-1/2 x^2");
            cmbFunzione.SelectedIndex = 0;
            cmbMetodo.Items.Add("Rettangoli");
            cmbMetodo.Items.Add("Trapezi");
            cmbMetodo.Items.Add("Prabole");
            cmbMetodo.SelectedIndex = 0;
            txtN.Text = "10";
        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double area = 0;
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double n = Convert.ToDouble(txtN.Text);
                double h = (b - a) / n;
                switch (cmbMetodo.SelectedIndex)
                {
                    case 0:
                        {
                            for (int i = 0; i < n; i++)
                            {
                                a += h;
                                area += h * f(a);
                            }
                            break;
                        }
                    case 1:
                        {
                            for (double i = a; i <= b; i += h)
                            {
                                if (i == a || i == b)
                                    area += (f(i) / 2);
                                else
                                    area += f(i);
                            }
                            area *= h;
                            break;
                        }
                    case 2:
                        {
                            if (n % 2 != 0)
                            {
                                MessageBox.Show("Il numero di intervalli per il metodo delle parabole deve essere pari.\nControlla i dati inseriti.", "Così non va...");
                                return;
                            }
                            area += f(0) + f(n);
                            for (int i = 1; i < n - 1; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    area += 2 * f(i);
                                }
                                else
                                {
                                    area += 4 * f(i);
                                }
                            }
                            area *= h / 3;
                            break;
                        }
                }
                lstOut.Items.Add(area.ToString() + " " + cmbMetodo.SelectionBoxItem);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nei dati inseriti. Prova a ricontrollare.", "Qualcosa non va...");
                return;
            }
            
        }

        public double f(double numero)
        {
            switch (cmbFunzione.SelectedIndex)
            {
                case 0: return 4/(Math.Pow(numero, 2) + 4);
                case 1: return Math.Pow(Math.E, -1 / 2 * Math.Pow(numero, 2));      
                default: throw new Exception("Nessuna funzione valida selezionata");
            }

        }
    }
}
