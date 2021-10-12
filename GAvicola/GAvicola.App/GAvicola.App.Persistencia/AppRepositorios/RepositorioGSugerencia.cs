using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioGSugerencia : IRepositorioGSugerencia
    {

        private readonly AppContext _appContext;
       
        public RepositorioGSugerencia(){
            _appContext = new AppContext();
        }



        GSugerencia IRepositorioGSugerencia.AddGSugerencia(GSugerencia sugerencia)
        {
            var sugerenciaAdicionado = _appContext.GSugerencias.Add(sugerencia);
            _appContext.SaveChanges();
            return sugerenciaAdicionado.Entity;

        }

        void IRepositorioGSugerencia.DeleteGSugerencia(int IdGSugerencia)
        {
            var sugerenciaEncontrado = _appContext.GSugerencias.FirstOrDefault(S => S.Id == IdGSugerencia);
            if (sugerenciaEncontrado == null)
            {
                return;
            }
            _appContext.GSugerencias.Remove(sugerenciaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<GSugerencia> IRepositorioGSugerencia.GetAllGSugerencias()
        {
            return _appContext.GSugerencias;
        }

        GSugerencia IRepositorioGSugerencia.GetGSugerencia(int IdGSugerencia)
        {
            return _appContext.GSugerencias.FirstOrDefault(s => s.Id == IdGSugerencia);

        }

        GSugerencia IRepositorioGSugerencia.UpdateGSugerencia(GSugerencia sugerencia)
        {
            var sugerenciaEncontrado = _appContext.GSugerencias.Find(sugerencia.Id);
            if (sugerenciaEncontrado != null)
            {
                sugerenciaEncontrado.Diagnostico =sugerencia.Diagnostico;
                sugerenciaEncontrado.Sugerencia= sugerencia.Sugerencia;
                sugerenciaEncontrado.Fecha= sugerencia.Fecha;

                _appContext.SaveChanges();

            }
            return sugerenciaEncontrado;


        }

       
        Veterinario IRepositorioGSugerencia.AsignarVeterinario(int IdGSugerencia, int IdVeterinario)
        {
            var sugerenciaEncontrado = _appContext.GSugerencias.Find(IdGSugerencia);
            if ( sugerenciaEncontrado != null)
            {
                var veterinarioEncontrado = _appContext.Veterinarios.Find(IdVeterinario);
                if ( veterinarioEncontrado != null)
                {
                    
                    sugerenciaEncontrado.IdVeterinario = veterinarioEncontrado; 

                    _appContext.SaveChanges();
                   
                }
                return veterinarioEncontrado;
            }
            return null;
        }



    }
}




