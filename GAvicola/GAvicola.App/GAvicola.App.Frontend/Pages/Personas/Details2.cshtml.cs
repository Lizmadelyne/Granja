using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.FRrontend.Pages.Personas
{
    public class Details2Model : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;
        public Persona persona {get; set;}
        public Details2Model(IRepositorioPersona repoPersona)
        {
            _repoPersona =repoPersona;
        }
        public IActionResult OnGet(int Id)
        {
            persona=_repoPersona.GetPersona(Id);
            if (persona ==null)
            {
                return NotFound();

            }else
            {
                return Page();

            }
        }
    }
}

