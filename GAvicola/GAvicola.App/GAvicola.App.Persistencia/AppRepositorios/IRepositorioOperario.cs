using System.Collections.Generic;
using System.Linq;  
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public interface IRepositorioOperario
    {
        IEnumerable<Operario> GetAllOperarios();
        Operario AddOperario(Operario operario);
        Operario UpdateOperario(Operario operario);
        void DeleteOperario(int Id_Operario);
        Operario GetOperario(int Id_Operario);

    }
}