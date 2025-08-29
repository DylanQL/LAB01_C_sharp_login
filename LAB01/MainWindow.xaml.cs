using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Credenciales hardcodeadas
        private const string VALID_USERNAME = "admin";
        private const string VALID_PASSWORD = "admin";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Validación de credenciales
            if (username == VALID_USERNAME && password == VALID_PASSWORD)
            {
                // Credenciales válidas, abrir la ventana del menú
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                this.Close();
            }
            else
            {
                // Credenciales inválidas, mostrar mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", 
                                "Error de autenticación", 
                                MessageBoxButton.OK, 
                                MessageBoxImage.Error);
                
                // Limpiar los campos
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}