using System;
using System.Collections.Generic;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;
namespace GAvicola.App.Consola
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona();
        static void Main(string[] args)
    

       { 
        Console.WriteLine("Hello World!");
        AddPersona();  


       }
        private static void AddPersona()
        {
            var persona = new Persona
            {
               Usuario = "pablito",
                Clave = "123",
                Nombre = "Pablo Perez",
                NumeroTelefono = "3001645",
                Direccion = "Calle 4 No 7-4",
                Correo = "pablito@gmail.com",
            };
            _repoPersona.AddPersona(persona);
        }
    
        private static void BuscarPersona(int IdPersona)
        {
            var persona = _repoPersona.GetPersona(IdPersona);
            Console.WriteLine(persona.Nombre);
        }
        private static void EliminarPersona(int IdPersona)
        {
            _repoPaciente.DeletePersona(IdPersona);
            Console.WriteLine("persona Eliminada");
        }
        private static void MostrarPersonas()
        {
            IEnumerable<Persona> personas = _repoPersona.GetAllPersonas();
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.Nombre + " " + persona.Documento);
            }
        }
    }
}        
