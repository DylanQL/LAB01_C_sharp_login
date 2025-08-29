using System.Windows;

namespace LAB01
{
    /// <summary>
    /// Lógica de interacción para ListaConductoresWindow.xaml
    /// </summary>
    public partial class ListaConductoresWindow : Window
    {
        public ListaConductoresWindow()
        {
            InitializeComponent();
            
            // Cargar los conductores en el DataGrid
            CargarConductores();
        }
        
        private void CargarConductores()
        {
            // Asignar la lista de conductores al DataGrid
            dgConductores.ItemsSource = null; // Limpiar primero
            dgConductores.ItemsSource = RegistroConductoresWindow.Conductores;
        }

        private void BtnNuevoConductor_Click(object sender, RoutedEventArgs e)
        {
            // Volver a la ventana de registro de conductores
            RegistroConductoresWindow registroConductoresWindow = new RegistroConductoresWindow();
            registroConductoresWindow.Show();
            this.Close();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            // Volver a la ventana de mantenimientos
            MantenimientosWindow mantenimientosWindow = new MantenimientosWindow();
            mantenimientosWindow.Show();
            this.Close();
        }
    }
}
