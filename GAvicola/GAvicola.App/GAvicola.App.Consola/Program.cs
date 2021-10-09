using System;
using System.Collections.Generic;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;
namespace GAvicola.App.Consola
{
    class Program
    {
        private static IRepositorioGalpon _repoGalpon = new RepositorioGalpon();
        private static IRepositorioPersona _repoPersona = new RepositorioPersona();
        static void Main(string[] args)
    
        { 
          Console.WriteLine("Hello World!");

            //BuscarGalpon(1)
            //MostrarGalpon();
           AddGalpon();
          // AddPersona();
          //EliminarGalpon(5);


       }
      private static void AddGalpon()
        {
            var galpon = new Galpon
            {
                Nombre="Galpon 1 HGP",
                Latitud= 5.03909,
                Longitud= 7544624,
                NumAves = 15000,

            };
            _repoGalpon.AddGalpon(galpon);
        }

    
    private static void EliminarGalpon(int IdGalpon)

        {
            _repoGalpon.DeleteGalpon(IdGalpon);
            
            Console.WriteLine( "Galpon Eliminado");

        }
         
         private static void AddPersona()
        {
            var persona = new Persona
            {
                Usuario="camilita",
                Clave= 123,
                Nombre= "Camila Fajardo",
                Documento =1020,
                Telefono=9876654,
                Direccion= "Kra 2 Nro3-4",
                Correo="camila@gmail.com",
                

            };
            _repoPersona.AddPersona(persona);
         }
         
    }
}