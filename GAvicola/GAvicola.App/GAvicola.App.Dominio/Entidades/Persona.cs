using System;
namespace GAvicola.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Usuario { get; set; }
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int Documento { get; set; }
        public string NumeroTelefono { get; set; }
        public string  Direccion { get; set; }
        public string Correo { get; set; }
        public int IdVeterinario { get; set; }
        public int IdOperario { get; set; }
        public int IdAuxiliar { get; set; }
        public string Tipo { get; set; }
        public int Activo{ get; set; }   

    }
}