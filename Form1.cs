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

        // Clase para manejar la l�gica de lectura y almacenamiento de reservaciones
        private GestorReservaciones gestorReservaciones;

        // Lista para registrar el historial de acciones (aunque no se utiliza en el c�digo actual)
        private List<string> historial = new List<string>();

        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario

            // Instancia el gestor de reservaciones
            gestorReservaciones = new GestorReservaciones();

            // Carga las reservaciones existentes desde el gestor
            reservaciones = gestorReservaciones.LeerReservaciones();
        }

        // Evento que se activa cuando se presiona el bot�n "Guardar"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Implementaci�n pendiente
        }

        // Evento que se activa cuando se presiona el bot�n "Mostrar"
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Implementaci�n pendiente
        }

        // M�todo para limpiar los campos del formulario despu�s de realizar una acci�n
        private void LimpiarCampos()
        {
            txtNombreCliente.Clear(); // Limpia el campo de texto para el nombre del cliente
            cmbHabitacion.SelectedIndex = -1; // Deselecciona cualquier opci�n en el combo box
            dtpIngreso.Value = DateTime.Now; // Restaura la fecha de ingreso al d�a actual
            dtpSalida.Value = DateTime.Now.AddDays(1); // Establece la fecha de salida al d�a siguiente
        }

        // Evento que se activa al hacer clic en el t�tulo (sin implementaci�n en este momento)
        private void txtTitulo_Click(object sender, EventArgs e)
        {
        }

        // Evento para manejar clics en las celdas del DataGridView (sin implementaci�n en este momento)
        private void dgvReservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Evento que se activa cuando se presiona el bot�n "Eliminar Historial"
        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            // Solicita confirmaci�n al usuario antes de eliminar el historial
            var confirmResult = MessageBox.Show("�Est�s seguro de que quieres eliminar todo el historial?",
                                                "Confirmar eliminaci�n",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) // Si el usuario confirma
            {
                // Limpia todas las reservaciones
                reservaciones.Clear();

                // Actualiza el DataGridView para reflejar los cambios
                dgvReservaciones.DataSource = null; // Desvincula la fuente de datos
                dgvReservaciones.Rows.Clear(); // Elimina todas las filas del DataGridView

                // Muestra un mensaje confirmando la eliminaci�n
                MessageBox.Show("El historial ha sido eliminado correctamente.");
            }
        }

        // Evento para cerrar la aplicaci�n cuando se presiona el bot�n "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicaci�n
        }

        // Evento que se activa al hacer clic en el PictureBox (sin implementaci�n en este momento)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Otro evento para cerrar la aplicaci�n al presionar un bot�n (duplicado del anterior)
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicaci�n
        }

        // Evento para guardar una nueva reservaci�n
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Crea una nueva reservaci�n con los datos ingresados en el formulario
                Reservacion nuevaReservacion = new Reservacion
                {
                    Id = reservaciones.Count > 0 ? reservaciones.Max(r => r.Id) + 1 : 1, // Genera un nuevo ID �nico
                    NombreCliente = txtNombreCliente.Text, // Obtiene el nombre del cliente
                    Habitacion = cmbHabitacion.SelectedItem?.ToString(), // Obtiene la habitaci�n seleccionada
                    FechaIngreso = dtpIngreso.Value, // Obtiene la fecha de ingreso seleccionada
                    FechaSalida = dtpSalida.Value // Obtiene la fecha de salida seleccionada
                };

                // Verifica que los campos obligatorios no est�n vac�os
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

                // Agrega la nueva reservaci�n a la lista
                reservaciones.Add(nuevaReservacion);

                // Guarda las reservaciones actualizadas a trav�s del gestor
                gestorReservaciones.GuardarReservaciones(reservaciones);

                // Notifica al usuario que la reservaci�n fue guardada con �xito
                MessageBox.Show("Reservaci�n guardada con �xito.", "�xito");

                // Limpia los campos del formulario para ingresar una nueva reservaci�n
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de excepci�n
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
