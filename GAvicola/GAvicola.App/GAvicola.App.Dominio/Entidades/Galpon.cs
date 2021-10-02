using System;
namespace GAvicola.App.Dominio
{
     /// <summary>Class <c>Galpon</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Galpon
    {
        // Identificador único de cada galpon
    
        public int Id { get; set; }
        public int IdOperario { get; set; }
         public int IdVeterinario { get; set; }
        public string Nombre { get; set; }
        public double Longitud { get; set; }
        public double Latitud { get; set; }
        public string  Tipo { get; set; }
        public int NumAves { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int Activo { get; set; }
    }
}
   
    
        
   
        