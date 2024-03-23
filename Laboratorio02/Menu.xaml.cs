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
using System.Windows.Shapes;

namespace Laboratorio02
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Ingreso_Click(object sender, RoutedEventArgs e)
        {
            Ingresos ingresosWindow = new Ingresos();

            ingresosWindow.Show();
        }

        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes poner el código para manejar el evento de clic en "Salida"
            MessageBox.Show("Has seleccionado Salida");
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Conductores");
        }

        private void Transportistas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Transportistas");
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Camiones");
        }

        private void Productos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Productos");
        }

        private void Cargas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Cargas");
        }

        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Ingresos");
        }

        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado Salidas");
        }
    }
}
