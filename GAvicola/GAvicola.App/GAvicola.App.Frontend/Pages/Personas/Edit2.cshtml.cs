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
    public class Edit2Model : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;
        public Persona persona {get; set;}
        public Edit2Model(IRepositorioPersona repoPersona)
        {
            _repoPersona =repoPersona;
        }
        public IActionResult OnGet(int Id)
        {
          persona=_repoPersona.GetPersona(Id); 
          if(persona==null) 
          {
              return NotFound();
          }else
          return Page();
        }

        public IActionResult OnPost(Persona persona)
        {
           _repoPersona.UpdatePersona(persona);
            return RedirectToPage("Index2");

        }
    
        
    } 
}

