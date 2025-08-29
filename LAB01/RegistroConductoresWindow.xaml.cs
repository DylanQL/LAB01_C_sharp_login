using System.Collections.Generic;
using System.Windows;

namespace LAB01
{
    /// <summary>
    /// Lógica de interacción para RegistroConductoresWindow.xaml
    /// </summary>
    public partial class RegistroConductoresWindow : Window
    {
        // Lista estática para almacenar los conductores (en una aplicación real se usaría una base de datos)
        public static List<Conductor> Conductores { get; set; } = new List<Conductor>();

        public RegistroConductoresWindow()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Validar que se hayan completado todos los campos
            if (string.IsNullOrWhiteSpace(txtNombreConductor.Text) ||
                string.IsNullOrWhiteSpace(txtLicencia.Text) ||
                string.IsNullOrWhiteSpace(txtTransporte.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Crear un nuevo conductor
            Conductor nuevoConductor = new Conductor
            {
                Nombre = txtNombreConductor.Text,
                Licencia = txtLicencia.Text,
                Transporte = txtTransporte.Text
            };

            // Agregar a la lista
            Conductores.Add(nuevoConductor);

            // Mostrar mensaje de éxito
            MessageBox.Show("Conductor registrado exitosamente.", "Registro Exitoso", MessageBoxButton.OK, MessageBoxImage.Information);

            // Limpiar los campos
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreConductor.Clear();
            txtLicencia.Clear();
            txtTransporte.Clear();
            txtNombreConductor.Focus();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Volver a la ventana de mantenimientos
            MantenimientosWindow mantenimientosWindow = new MantenimientosWindow();
            mantenimientosWindow.Show();
            this.Close();
        }

        private void BtnVerLista_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de lista de conductores
            ListaConductoresWindow listaConductoresWindow = new ListaConductoresWindow();
            listaConductoresWindow.Show();
            this.Close();
        }
    }

    // Clase para representar un conductor
    public class Conductor
    {
        public string Nombre { get; set; } = string.Empty;
        public string Licencia { get; set; } = string.Empty;
        public string Transporte { get; set; } = string.Empty;
    }
}
