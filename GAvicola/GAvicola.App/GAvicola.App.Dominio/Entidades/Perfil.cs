using System;
namespace GAvicola.App.Dominio
{
     /// <summary>Class <c>Perfil</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Perfil
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public int IdPrograma { get; set; }
        public int Activo{ get; set; }   

    }
}