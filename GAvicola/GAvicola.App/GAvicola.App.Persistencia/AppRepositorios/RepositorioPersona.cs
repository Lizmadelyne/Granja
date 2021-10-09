using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;
using Microsoft.EntityFrameworkCore;

 namespace GAvicola.App.Persistencia
   {
    public class RepositorioPersona : IRepositorioPersona
    {

        private readonly AppContext _appContext; 
        public RepositorioPersona(){

        _appContext = new AppContext();
        }



        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionado= _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;

        }

        void IRepositorioPersona.DeletePersona(int IdPersona)
        {
            var personaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id==IdPersona);
            if (personaEncontrado==null)
            {
                return;
            }
            _appContext.Personas.Remove(personaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }
         Persona IRepositorioPersona.GetPersona(int IdPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id==IdPersona);

        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrado=_appContext.Personas.Find(persona.Id);
            if (personaEncontrado != null)
                        {
                personaEncontrado.IdRol=persona.IdRol;
                personaEncontrado.Usuario=persona.Usuario;
                personaEncontrado.Clave=persona.Clave;
                personaEncontrado.Documento=persona.Documento;
                personaEncontrado.Telefono=persona.Telefono;
                personaEncontrado.Direccion=persona.Direccion;
                personaEncontrado.Correo=persona.Correo;
                personaEncontrado.IdVeterinario=persona.IdVeterinario;
                personaEncontrado.IdOperario=persona.IdOperario;
                personaEncontrado.IdAuxiliar=persona.IdAuxiliar;
                personaEncontrado.Tipo=persona.Tipo;
                personaEncontrado.Activo=persona.Activo;

                _appContext.SaveChanges();
                
            }
            return personaEncontrado;

        
        
        }
       

    }

}



