using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace GestionReservaciones
{
    public class GestorReservaciones
    {
        // Ruta del archivo donde se almacenarán las reservaciones en formato JSON
        private readonly string archivo = "reservaciones.json";

        // Método para guardar una lista de reservaciones en un archivo JSON
        public void GuardarReservaciones(List<Reservacion> reservaciones)
        {
            // Serializa la lista de reservaciones a formato JSON con indentación para facilitar la lectura
            string json = JsonSerializer.Serialize(reservaciones, new JsonSerializerOptions { WriteIndented = true });

            // Escribe el JSON en el archivo especificado
            File.WriteAllText(archivo, json);
        }

        // Método para leer las reservaciones almacenadas en el archivo JSON
        public List<Reservacion> LeerReservaciones()
        {
            // Verifica si el archivo no existe; si no existe, retorna una lista vacía
            if (!File.Exists(archivo))
            {
                return new List<Reservacion>();
            }

            // Lee el contenido del archivo JSON
            string json = File.ReadAllText(archivo);

            // Deserializa el JSON en una lista de reservaciones; si es nulo, retorna una lista vacía
            return JsonSerializer.Deserialize<List<Reservacion>>(json) ?? new List<Reservacion>();

        }
    }
}




