using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioOperario : IRepositorioOperario
    {

        private readonly AppContext _appContext; 
        public RepositorioOperario(){

        _appContext = new AppContext();
        }


        Operario IRepositorioOperario.AddOperario(Operario operario)
        {
            var operarioAdicionado= _appContext.Operarios.Add(operario);
            _appContext.SaveChanges();
            return operarioAdicionado.Entity;

        }

        void IRepositorioOperario.DeleteOperario(int Id_Operario)
        {
            var operarioEncontrado = _appContext.Operarios.FirstOrDefault(o => o.Id==Id_Operario);
            if (operarioEncontrado==null)
            {
                return;
            }
            _appContext.Operarios.Remove(operarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Operario> IRepositorioOperario.GetAllOperarios()
        {
            return _appContext.Operarios;
        }
         Operario IRepositorioOperario.GetOperario(int Id_Operario)
        {
            return _appContext.Operarios.FirstOrDefault(o => o.Id==Id_Operario);

        }

        Operario IRepositorioOperario.UpdateOperario(Operario operario)
        {
            var operarioEncontrado=_appContext.Operarios.Find(operario.Id);
            if (operarioEncontrado != null)
                        {
                operarioEncontrado.IdRol=operario.IdRol;
                operarioEncontrado.Usuario=operario.Usuario;
                operarioEncontrado.Clave=operario.Clave;
                operarioEncontrado.Documento=operario.Documento;
                operarioEncontrado.Telefono=operario.Telefono;
                operarioEncontrado.Direccion=operario.Direccion;
                operarioEncontrado.Correo=operario.Correo;
                operarioEncontrado.Tipo=operario.Tipo;
                operarioEncontrado.Activo=operario.Activo;

                _appContext.SaveChanges();
                
            }
            return operarioEncontrado;
        
       
        }
        

    }

}

        
        