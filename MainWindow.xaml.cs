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

namespace Tema2_CalculadoraBasica
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Operando1.Text) || String.IsNullOrEmpty(Operando2.Text))
                MessageBox.Show("Se ha producido un error. Revise los operandos");
            else
            {
                try
                {
                    int n1 = int.Parse(Operando1.Text);
                    int n2 = int.Parse(Operando2.Text);
                    switch (Operador.Text)
                    {
                        case "+":
                            Resultado.Text = (n1 * n2).ToString();
                            break;
                        case "-":
                            Resultado.Text = (n1 - n2).ToString();
                            break;
                        case "*":
                            Resultado.Text = (n1 * n2).ToString();
                            break;
                        case "/":
                            Resultado.Text = (n1 / n2).ToString();
                            break;
                        default:
                            MessageBox.Show("Operador Incorrecto", "ERROR", MessageBoxButton.OK);
                            break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Se ha producido un error. Revise los operandos");
                }
                
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operador.Clear();
            Operando1.Clear();
            Operando2.Clear();
            Resultado.Clear();
        }

        private bool OperadorCorrecto()
        {
            if (Operador.Text != "" && Operador.Text == "/" || Operador.Text == "*" || Operador.Text == "-" || Operador.Text == "+")
                return true;
            else return false;
        }

        private void Operador_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OperadorCorrecto())
                CalcularButton.IsEnabled = true;
            else CalcularButton.IsEnabled = false;
        }
    }
}
