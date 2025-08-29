using System.Windows;

namespace LAB01
{
    /// <summary>
    /// Lógica de interacción para MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void BtnOperaciones_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de Operaciones
            OperacionesWindow operacionesWindow = new OperacionesWindow();
            operacionesWindow.Show();
            this.Close();
        }

        private void BtnMantenimientos_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de Mantenimientos
            MantenimientosWindow mantenimientosWindow = new MantenimientosWindow();
            mantenimientosWindow.Show();
            this.Close();
        }

        private void BtnReportes_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de Reportes
            ReportesWindow reportesWindow = new ReportesWindow();
            reportesWindow.Show();
            this.Close();
        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Volver a la pantalla de login
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
