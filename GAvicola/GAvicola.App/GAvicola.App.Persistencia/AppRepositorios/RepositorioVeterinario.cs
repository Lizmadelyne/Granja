using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace GAvicola.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext; 
        public RepositorioVeterinario(){

        _appContext = new AppContext();
        }


        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado= _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;

        }

        void IRepositorioVeterinario.DeleteVeterinario(int Id_Veterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id==Id_Veterinario);
            if (veterinarioEncontrado==null)
            {
                return;
            }
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }
         Veterinario IRepositorioVeterinario.GetVeterinario(int Id_Veterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.Id==Id_Veterinario);

        }

        

        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v => v.Id==veterinario.Id);
            if (veterinarioEncontrado != null)
            {
                
                veterinarioEncontrado.IdRol=veterinario.IdRol;
                veterinarioEncontrado.Usuario=veterinario.Usuario;
                veterinarioEncontrado.Clave=veterinario.Clave;
                veterinarioEncontrado.Documento=veterinario.Documento;
                veterinarioEncontrado.Telefono=veterinario.Telefono;
                veterinarioEncontrado.Direccion=veterinario.Direccion;
                veterinarioEncontrado.Correo=veterinario.Correo;
                veterinarioEncontrado.Tipo=veterinario.Tipo;
                veterinarioEncontrado.Activo=veterinario.Activo;
                

                _appContext.SaveChanges();
                
            }
            return veterinarioEncontrado;

        }



    }

}