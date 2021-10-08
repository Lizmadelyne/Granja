using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;


namespace GAvicola.App.Frontend.Pages.Personas
{
    public class Index2Model : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;
        public IEnumerable<Persona> Personas {get; set;}
        public Index2Model(IRepositorioPersona repoPersona)
        {
            _repoPersona=repoPersona;
        }

        public void OnGet()
        {
             Personas=_repoPersona.GetAllPersonas();
        }
    }
}
