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

            //BuscarGalpon(1)
            //MostrarGalpon();
            //AsignarGalpon();
           // AddGalpon();
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
}
}