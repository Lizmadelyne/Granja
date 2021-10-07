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
    public class create2Model : PageModel
    {
         private readonly IRepositorioPersona _repoPersona;
        public Persona persona {get; set;}
        public create2Model(IRepositorioPersona repoPersona)
        {
            _repoPersona=repoPersona;
        }

        public void OnGet()
        {
          persona = new Persona();
        }

        public IActionResult OnPost(Persona persona)
        {
        if (ModelState.IsValid)
        {
            _repoPersona.AddPersona(persona);
            return RedirectToPage("Index2");

        }else
        {
         return Page();
        }
        }
    }
}
    