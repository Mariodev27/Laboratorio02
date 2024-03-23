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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        string username_in = "admin";
        string password_in = "password";

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (username.Text != ""  && password.Password != "")
            {
                if(username.Text == username_in && password.Password == password_in)
                {
                    MessageBox.Show("Logeo correcto!", "Credenciales validas");
                    Menu menu = new Menu();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales invalidas, Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese su nombre y contraseña correctas", "Credenciales incorrectas");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
