using System;
namespace GAvicola.App.Dominio
{
     /// <summary>Class <c>GAmbiente</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class GAmbiente
    {
        // Identificador único de cada galpon
        public int Id { get; set; }
        public int IdGalpon { get; set; }
        public int IdOperario { get; set; }
        public double Temperatura{ get; set; }
        public double Agua { get; set; }
        public double Alimento { get; set; }
        public int Huevos { get; set; }
        public int Enfermas { get; set; }
        public DateTime Fecha { get; set; }
        public int Activo { get; set; }
        
    }
}