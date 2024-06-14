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


namespace GroupBox
{
    public partial class MainWindow : Window
    {
        bool Verificar = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
            Verificar = (sender as CheckBox).IsChecked.Value;
            if (Verificar)
            {
                if ((sender as CheckBox).Content.ToString() == "Carro")
                {
                    CheckBoxCasa.IsChecked = false;
                }
                else if ((sender as CheckBox).Content.ToString() == "Casa")
                {
                    CheckBoxCarro.IsChecked = false;
                }
            }
        }

        private void BotonGenerar_Click(object sender, RoutedEventArgs e)
        {
            string Bien = "";
            if (CheckBoxCarro.IsChecked == true)
            {
                Bien = "Carro";
               
            }
            else if (CheckBoxCasa.IsChecked == true)
            {
                Bien = "Casa";
                
            }
            else
            {
                MessageBox.Show("Seleccione un bien.");
                Limpiar();
                return;
            }

            string TipoPago = "";
            if (RadioButtonEfectivo.IsChecked == true)
            {
                TipoPago = "Efectivo";
                
            }
            else if (RadioButtonTarjeta.IsChecked == true)
            {
                TipoPago = "Tarjeta";
                
            }
            else if (RadioButtonTransferencia.IsChecked == true)
            {
                TipoPago = "Transferencia";
              
            }
            else
            {
                MessageBox.Show("Seleccione tipo de pago.");
                Limpiar();
                return;
            }

            MessageBox.Show($"Se va comprar un(a): {Bien}\n Se va pagar con: {TipoPago}");


            Limpiar();

        }

        private void Limpiar() 
        {
            CheckBoxCarro.IsChecked = false;
            CheckBoxCasa.IsChecked = false;

            RadioButtonEfectivo.IsChecked = false;
            RadioButtonTarjeta.IsChecked = false;
            RadioButtonTransferencia.IsChecked = false;
        }

        private void BotonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxCarro.IsChecked = false;
            CheckBoxCasa.IsChecked = false;

            RadioButtonEfectivo.IsChecked = false;
            RadioButtonTarjeta.IsChecked = false;
            RadioButtonTransferencia.IsChecked = false;
        }

        private void BotonCancelar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
