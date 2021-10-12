using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

namespace GAvicola.App.Persistencia
{
    public class RepositorioGAmbiente : IRepositorioGAmbiente
    {

        private readonly AppContext _appContext;
       
        public RepositorioGAmbiente(){
            _appContext = new AppContext();
        }



        GAmbiente IRepositorioGAmbiente.AddGAmbiente(GAmbiente gAmbiente)
        {
            var gAmbienteAdicionado = _appContext.GAmbientes.Add(gAmbiente);
            _appContext.SaveChanges();
            return gAmbienteAdicionado.Entity;

        }

        void IRepositorioGAmbiente.DeleteGAmbiente(int IdGAmbiente)
        {
            var galponEncontrado = _appContext.Galpones.FirstOrDefault(p => p.Id == IdGAmbiente);
            if (galponEncontrado == null)
            {
                return;
            }
            _appContext.Galpones.Remove(galponEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<GAmbiente> IRepositorioGAmbiente.GetAllGAmbientes()
        {
            return _appContext.GAmbientes;
        }

        GAmbiente IRepositorioGAmbiente.GetGAmbiente(int IdGAmbiente)
        {
            return _appContext.GAmbientes.FirstOrDefault(g => g.Id == IdGAmbiente);

        }

        GAmbiente IRepositorioGAmbiente.UpdateGAmbiente(GAmbiente ambiente)
        {
            var gAmbienteEncontrado = _appContext.GAmbientes.Find(ambiente.Id);
            if (gAmbienteEncontrado != null)
            {
                gAmbienteEncontrado.Temperatura = ambiente.Temperatura;
                gAmbienteEncontrado.Agua = ambiente.Agua;
                gAmbienteEncontrado.Alimento = ambiente.Alimento;

                _appContext.SaveChanges();

            }
            return gAmbienteEncontrado;


        }

       
        Galpon IRepositorioGAmbiente.AsignarGalpon(int IdGAmbiente, int IdGalpon)
        {
            var gAmbienteEncontrado = _appContext.GAmbientes.Find(IdGAmbiente);
            if ( gAmbienteEncontrado != null)
            {
                var galponEncontrado = _appContext.Galpones.Find(IdGalpon);
                if ( galponEncontrado != null)
                {
                    
                    gAmbienteEncontrado.IdGalpon = galponEncontrado; 

                    _appContext.SaveChanges();
                   
                }
                return galponEncontrado;
            }
            return null;
        }

        
       Operario IRepositorioGAmbiente.AsignarOperario(int IdGAmbiente, int IdOperario)
        {
            var gAmbienteEncontrado = _appContext.Galpones.Find(IdGAmbiente);
            if ( gAmbienteEncontrado != null)
            {
                var operarioEncontrado = _appContext.Operarios.Find(IdOperario);
                if ( operarioEncontrado != null)
                {
                    
                    gAmbienteEncontrado.Operario = operarioEncontrado; 
                    _appContext.SaveChanges();
                }
                return operarioEncontrado;
            }
           
            return null;
        }



    }
}




