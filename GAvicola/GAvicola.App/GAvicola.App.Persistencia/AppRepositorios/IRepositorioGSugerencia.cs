using System.Collections.Generic;
using System.Linq;  
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioGSugerencia
    {
        IEnumerable<GSugerencia> GetAllGSugerencias();
        GSugerencia AddGSugerencia(GSugerencia sugerencia);
        GSugerencia UpdateGSugerencia(GSugerencia sugerencia);
        void DeleteGSugerencia(int IdGSugerencia);
        GSugerencia GetGSugerencia(int IdGSugerencia);
        Veterinario AsignarVeterinario(int IdGSugerencia, int IdVeterinario);
        

    }
}