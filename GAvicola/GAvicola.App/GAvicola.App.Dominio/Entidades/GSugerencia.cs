using System;
namespace GAvicola.App.Dominio
{
     /// <summary>Class <c>GSugerencia/c>

     /// </summary>   
    public class GSugerencia
    {
        // Identificador único de cada galpon
        public int Id { get; set; }
        public int IdVeterinario{ get; set; }
        public int IdRol { get; set; }
        public string Diagnostico { get; set; }
        public string Sugerencia { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public int Activo { get; set; }
    }
}