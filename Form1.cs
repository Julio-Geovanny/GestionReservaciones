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

    }
}
