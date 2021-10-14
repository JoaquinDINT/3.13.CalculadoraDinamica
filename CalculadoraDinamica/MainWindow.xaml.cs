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

namespace Calculadora
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int numeroFilas = gridPrincipal.RowDefinitions.Count;
            int numeroColumnas = gridPrincipal.ColumnDefinitions.Count;
            int contador = 1;

            for (int fila = 1; fila < numeroFilas -1; fila++)
            {
                for (int columna = 0; columna < numeroColumnas; columna++, contador++)
                {
                    Button boton = new Button();
                    Grid.SetRow(boton, fila);
                    Grid.SetColumn(boton, columna);
                    boton.Tag = contador;
                    Viewbox viewbox = new Viewbox();
                    viewbox.Child = new TextBlock();
                    (viewbox.Child as TextBlock).Text = contador.ToString();
                    boton.Content = viewbox;
                    gridPrincipal.Children.Add(boton);
                }
            }
        }

        private void entradaRaton(object sender, MouseEventArgs e)
        {
            Button recuadro = (Button)sender;
            recuadro.BorderBrush = Brushes.SkyBlue;
            recuadro.Background = Brushes.LightSkyBlue;
        }

        private void salidaRaton(object sender, MouseEventArgs e)
        {
            Button recuadro = (Button)sender;
            recuadro.BorderBrush = Brushes.Black;
            recuadro.Background = Brushes.LightGray;
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += ((Button)sender).Tag.ToString();
        }
    }
}
