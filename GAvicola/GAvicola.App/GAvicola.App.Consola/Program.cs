using System;
using System.Collections.Generic;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;
namespace GAvicola.App.Consola
{
    class Program
    {
        private static IRepositorioGalpon _repoGalpon = new RepositorioGalpon();
        static void Main(string[] args)
    
        { 
          Console.WriteLine("Hello World!");
          AddGalpon();
         //EliminarGalpon(2);


       }
      private static void AddGalpon()
        {
            var galpon = new Galpon
            {
                Nombre="Galpon 2"
            };
            _repoGalpon.AddGalpon(galpon);
        }

    
    private static void EliminarGalpon(int IdGalpon)

        {
            _repoGalpon.DeleteGalpon(IdGalpon);
            
            Console.WriteLine( "Galpon Eliminado");

        }
}
}