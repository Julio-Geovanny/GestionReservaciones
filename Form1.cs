using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionReservaciones
{
    public partial class Form1 : Form
    {
        // Lista para almacenar las reservaciones
        private List<Reservacion> reservaciones;

        // Clase para manejar la lógica de lectura y almacenamiento de reservaciones
        private GestorReservaciones gestorReservaciones;

        // Lista para registrar el historial de acciones (aunque no se utiliza en el código actual)
        private List<string> historial = new List<string>();

        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario

            // Instancia el gestor de reservaciones
            gestorReservaciones = new GestorReservaciones();

            // Carga las reservaciones existentes desde el gestor
            reservaciones = gestorReservaciones.LeerReservaciones();
        }

        // Evento que se activa cuando se presiona el botón "Guardar"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Implementación pendiente
        }

        // Evento que se activa cuando se presiona el botón "Mostrar"
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Implementación pendiente
        }

        // Método para limpiar los campos del formulario después de realizar una acción
        private void LimpiarCampos()
        {
            txtNombreCliente.Clear(); // Limpia el campo de texto para el nombre del cliente
            cmbHabitacion.SelectedIndex = -1; // Deselecciona cualquier opción en el combo box
            dtpIngreso.Value = DateTime.Now; // Restaura la fecha de ingreso al día actual
            dtpSalida.Value = DateTime.Now.AddDays(1); // Establece la fecha de salida al día siguiente
        }

        // Evento que se activa al hacer clic en el título (sin implementación en este momento)
        private void txtTitulo_Click(object sender, EventArgs e)
        {
        }

        // Evento para manejar clics en las celdas del DataGridView (sin implementación en este momento)
        private void dgvReservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Evento que se activa cuando se presiona el botón "Eliminar Historial"
        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            // Solicita confirmación al usuario antes de eliminar el historial
            var confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar todo el historial?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) // Si el usuario confirma
            {
                // Limpia todas las reservaciones
                reservaciones.Clear();

                // Actualiza el DataGridView para reflejar los cambios
                dgvReservaciones.DataSource = null; // Desvincula la fuente de datos
                dgvReservaciones.Rows.Clear(); // Elimina todas las filas del DataGridView

                // Muestra un mensaje confirmando la eliminación
                MessageBox.Show("El historial ha sido eliminado correctamente.");
            }
        }

        // Evento para cerrar la aplicación cuando se presiona el botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Evento que se activa al hacer clic en el PictureBox (sin implementación en este momento)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Otro evento para cerrar la aplicación al presionar un botón (duplicado del anterior)
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Evento para guardar una nueva reservación
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Crea una nueva reservación con los datos ingresados en el formulario
                Reservacion nuevaReservacion = new Reservacion
                {
                    Id = reservaciones.Count > 0 ? reservaciones.Max(r => r.Id) + 1 : 1, // Genera un nuevo ID único
                    NombreCliente = txtNombreCliente.Text, // Obtiene el nombre del cliente
                    Habitacion = cmbHabitacion.SelectedItem?.ToString(), // Obtiene la habitación seleccionada
                    FechaIngreso = dtpIngreso.Value, // Obtiene la fecha de ingreso seleccionada
                    FechaSalida = dtpSalida.Value // Obtiene la fecha de salida seleccionada
                };

                // Verifica que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(nuevaReservacion.NombreCliente) || string.IsNullOrWhiteSpace(nuevaReservacion.Habitacion))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error");
                    return;
                }

                // Verifica que la fecha de salida sea posterior a la de ingreso
                if (nuevaReservacion.FechaSalida <= nuevaReservacion.FechaIngreso)
                {
                    MessageBox.Show("La fecha de salida debe ser posterior a la fecha de ingreso.", "Error");
                    return;
                }

                // Agrega la nueva reservación a la lista
                reservaciones.Add(nuevaReservacion);

                // Guarda las reservaciones actualizadas a través del gestor
                gestorReservaciones.GuardarReservaciones(reservaciones);

                // Notifica al usuario que la reservación fue guardada con éxito
                MessageBox.Show("Reservación guardada con éxito.", "Éxito");

                // Limpia los campos del formulario para ingresar una nueva reservación
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de excepción
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        // Evento para mostrar las reservaciones activas en el DataGridView
        private void btnMostrarReservaciones_Click(object sender, EventArgs e)
        {
            dgvReservaciones.DataSource = null; // Limpia cualquier fuente de datos previa
            dgvReservaciones.DataSource = reservaciones.Where(r => r.FechaSalida >= DateTime.Now).ToList(); // Filtra y muestra reservaciones futuras
        }
    }
}
