using System.Windows;

namespace LAB01
{
    /// <summary>
    /// Lógica de interacción para ReportesWindow.xaml
    /// </summary>
    public partial class ReportesWindow : Window
    {
        public ReportesWindow()
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
