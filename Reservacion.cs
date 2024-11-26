using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservaciones
{
    public class Reservacion
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string Habitacion { get; set; } 
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
