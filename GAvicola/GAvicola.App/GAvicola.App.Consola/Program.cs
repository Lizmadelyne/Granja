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
            AsignarGalpon();
           // AddPersona();
          //EliminarGalpon(5);


       }
      private static void AddGalpon()
        {
            var galpon = new Galpon
            {
                Nombre="Galpon 4 PM",
                Latitud= 5.03907,
                Longitud= -7544626,
                NumAves =14000,
            };
            _repoGalpon.AddGalpon(galpon);
        }

    
    private static void EliminarGalpon(int IdGalpon)

        {
            _repoGalpon.DeleteGalpon(IdGalpon);
            
            Console.WriteLine( "Galpon Eliminado");

        }
         private static void AsignarGalpon()
        {
            var Galpon = _repoGalpon.AsignarGalpon(1, 1);
            Console.WriteLine(Galpon.Nombre);
        }
         private static void AddPersona()
        {
            var persona = new Persona
            {
                Usuario="pepito",
                Clave= 123456,
                Nombre= "Pepito Perez",
                Documento =100,
                NumeroTelefono=8808080,
                Direccion= "Kra 1 Nro2-3",
                Correo="pepitoperez@gmail.com",
                IdVeterinario=1,
                Activo=1,

            };
            _repoPersona.AddPersona(persona);
         }
         
    }
}