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

    }
}
