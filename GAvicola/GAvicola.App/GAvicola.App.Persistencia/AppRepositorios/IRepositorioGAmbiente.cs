using System.Collections.Generic;
using System.Linq;  
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioGAmbiente
    {
        IEnumerable<GAmbiente> GetAllGAmbientes();
        GAmbiente AddGAmbiente(GAmbiente ambiente);
        GAmbiente UpdateGAmbiente(GAmbiente ambiente);
        void DeleteGAmbiente(int IdAmbiente);
        GAmbiente GetGAmbiente(int IdAmbiente);
         Galpon AsignarGalpon(int IdGAmbiente, int IdGalpon);
         Operario AsignarOperario(int IdGAmbiente, int IdOperario);

    }
}