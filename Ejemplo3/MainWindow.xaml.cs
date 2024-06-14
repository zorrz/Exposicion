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

namespace Ejemplo3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
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
                if ((sender as CheckBox).Content.ToString() == "Femenino")
                {
                    CheckBox_M.IsChecked = false;
                }
                else
                {
                    CheckBox_F.IsChecked = false;
                }
            }
        }


        private void Buttom_Generar_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox_F.IsChecked == true)
            {
                MessageBox.Show("Has seleccionado Femenino");
            }
            else if (CheckBox_M.IsChecked == true)
            {
                MessageBox.Show("Has seleccionado Masculino");
            }

            if (RadioButton18.IsChecked == true)
            {
                MessageBox.Show("Has seleccionado  18 años");
            }
            else if (RadioButton19.IsChecked == true)
            {
                MessageBox.Show("Has seleccionado 19 años");
            }
            else if (RadioButton20.IsChecked == true)
            {
                MessageBox.Show("Has seleccionado 20 años");
            }
        }

        private void Buttom_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            CheckBox_F.IsChecked = false;
            CheckBox_M.IsChecked = false;
            RadioButton18.IsChecked = false;
            RadioButton19.IsChecked = false;
            RadioButton20.IsChecked = false;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                string Edad = radioButton.Content.ToString();

            }
        }

        private void Button_Cancelar_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            //this.Close();
        }
    }
}

