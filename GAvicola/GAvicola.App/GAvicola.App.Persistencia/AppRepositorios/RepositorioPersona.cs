using System.Collections.Generic;
using System.Linq;
using GAvicola.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace GAvicola.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext = new AppContext();

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionado = _appContext.Persona.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }

        void IRepositorioPersona.DeletePersona(int IdPersona)
        {
            var personaEncontrado = _appContext.Personas.Find(IdPersona);
            if (personaEncontrado == null)
                return;
            _appContext.Persona.Remove(personaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.GetPersona(int IdPersona)
        {
            return _appContext.Personas.Find(IdPersona);
            /*
            var per = _appContext.Personas
                       .Where(p => p.Id == IdPersona)
                       .Include(p => p.Medico)
                       .FirstOrDefault();
            return pac;
            */
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrado = _appContext.Personas.Find(persona.Id);
            if (pacienteEncontrado != null)
            {
                personaEncontrado.IdRol = persona.IdRol;
                personaEncontrado.Usuario = persona.Usuario;
                personaEncontrado.Clave = persona.Clave;
                personaEncontrado.Nombre = persona.Nombre;
                personaEncontrado.Documento = persona.Documento;
                personaEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                personaEncontrado.Direccion = persona.Direccion;
                personaEncontrado.Correo = persona.Correo;
                personaEncontrado.IdVeterinario = persona.IdVeterinario;
                personaEncontrado.IdOperario = persona.IdOperario;
                personaEncontrado.IdAuxiliar = persona.IdAuxiliar;
                personaEncontrado.Tipo = persona.Tipo;
                personaEncontrado.Activo = persona.Activo;
                _appContext.SaveChanges();
            }
            return paersonaEncontrado;
        }
        Galpon IRepositorioPersona.AsignarGalponl(int IdPersona, int idGalpon)
        {
            var personaEncontrado = _appContext.Personas
            .Where(p => p.Id == IdPersona)
            .Include(p => p.Galpon)
            .SingleOrDefault();
            if (personaEncontrado != null)
            {
                var galponEncontrado = _appContext.Galpon.Find(IdGalpon);
                if (galponEncontrado != null)
                {
                    personaEncontrado.Galpon.Add(Galpon);
                    _appContext.SaveChanges();
                }
                return galponEncontrado;
            }
            return null;
        }
    }
}
