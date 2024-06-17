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

namespace WPF_Masked
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string NombreCompleto = NombreCompletoMaskedTextBox.Text;
            string TarjetaDeCredito = TarjetaDeCreditoMaskedTextBox.Text;
            string Fecha = FechaMaskedTextBox.Text;
            string Telefono = TelefonoMaskedTextBox.Text;
            string IP = IpMaskedTextBox.Text;

            MessageBox.Show($"El nombre completo ingresado es {NombreCompleto}, Tarjeta de Crédito: {TarjetaDeCredito}, " +
                $"Fecha: {Fecha}, Telefono{Telefono}, IP {IP}", "Información Proporcionada", MessageBoxButton.OK, MessageBoxImage.Information);


        }
    }
}
