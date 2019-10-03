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

namespace InterfasDinamica
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

        private void CbLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            GrdInterfaz.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            GrdInterfaz.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            GrdInterfaz.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Visible;
            GrdInterfaz.Children.Clear();
            switch(cbLista.SelectedIndex)
            {
                case 0:
                    GrdInterfaz.Children.Add(new Alumno());
                    break;
                case 1:
                    GrdInterfaz.Children.Add(new Maestro());
                    break;
            }
        }
    }
}
