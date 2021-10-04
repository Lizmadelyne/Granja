using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;

 namespace GAvicola.App.Persistencia
   {
    public class RepositorioGalpon : IRepositorioGalpon
    {

        private readonly AppContext _appContext = new AppContext();



        Galpon IRepositorioGalpon.AddGalpon(Galpon galpon)
        {
            var galponAdicionado= _appContext.Galpones.Add(galpon);
            _appContext.SaveChanges();
            return galponAdicionado.Entity;

        }

        void IRepositorioGalpon.DeleteGalpon(int IdGalpon)
        {
            var galponEncontrado=_appContext.Galpones.FirstOrDefault(p => p.Id==IdGalpon);
            if (galponEncontrado==null)
            {
                return;
            }
            _appContext.Galpones.Remove(galponEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Galpon> IRepositorioGalpon.GetAllGalpones()
        {
            return _appContext.Galpones;
        }

        Galpon IRepositorioGalpon.GetGalpon(int IdGalpon)
        {
            return _appContext.Galpones.FirstOrDefault(p => p.Id==IdGalpon);

        }

        Galpon IRepositorioGalpon.UpdateGalpon(Galpon galpon)
        {
            var galponEncontrado=_appContext.Galpones.Find(galpon.Id);
            if (galponEncontrado != null)
                        {
                galponEncontrado.Nombre=galpon.Nombre;
                galponEncontrado.Latitud=galpon.Latitud;
                galponEncontrado.Longitud=galpon.Longitud;

                _appContext.SaveChanges();
                
            }
            return galponEncontrado;

        }

    }

}



