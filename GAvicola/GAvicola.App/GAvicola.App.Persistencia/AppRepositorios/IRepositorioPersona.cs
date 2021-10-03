using System.Collections.Generic;
using GAvicola.App.Dominio;
namespace GAvicola.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int IdPersona);    
        Persona GetPersona(int IdPersona);
        Galpon AsignarGalpon(int IdPersona, int IdGalpon);
   }
}