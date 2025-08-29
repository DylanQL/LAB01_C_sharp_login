using System;
using System.Windows;

namespace LAB01
{
    /// <summary>
    /// Lógica de interacción para IngresosWindow.xaml
    /// </summary>
    public partial class IngresosWindow : Window
    {
        public IngresosWindow()
        {
            InitializeComponent();
            
            // Establecer la fecha actual por defecto
            dpFecha.SelectedDate = DateTime.Today;
            
            // Establecer la hora actual por defecto
            txtHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Volver a la ventana de Operaciones
            OperacionesWindow operacionesWindow = new OperacionesWindow();
            operacionesWindow.Show();
            this.Close();
        }
    }
}
