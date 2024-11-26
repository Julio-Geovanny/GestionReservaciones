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

      
    }
}
