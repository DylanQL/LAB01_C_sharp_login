using System.Windows;

namespace LAB01
{
    /// <summary>
    /// Lógica de interacción para MantenimientosWindow.xaml
    /// </summary>
    public partial class MantenimientosWindow : Window
    {
        public MantenimientosWindow()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            // Volver al menú principal
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }
    }
}
