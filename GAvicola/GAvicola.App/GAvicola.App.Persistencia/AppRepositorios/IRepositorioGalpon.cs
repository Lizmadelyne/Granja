using System.Collections.Generic;
using GAvicola.App.Dominio;
namespace GAvicola.App.Persistencia
{
    public interface IRepositorioGalpon
    {
        IEnumerable<Galpon> GetAllGalpones();
        Galpon AddGalpon(Galpon galpon);
        Galpon UpdateGalpon(Galpon Galpon);
        void DeleteGalpon(int IdGalpon);    
        Galpon GetGalpon(int IdGalpon);
       
   }
}