﻿using System;
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

namespace CuadroDialogo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AbrirDialogo_Click(object sender, RoutedEventArgs e)
        {
                miDialogo dialog = new miDialogo();
                bool? resultado = dialog.ShowDialog();
                if (resultado == true)
                {
                    MessageBox.Show("El dialogo fue aceptado");
                }
                else
                {
                    MessageBox.Show("El dialogo Fue cancelado");
                }
            }
        }
    }

