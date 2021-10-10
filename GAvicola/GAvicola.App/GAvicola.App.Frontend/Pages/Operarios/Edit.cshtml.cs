using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Operarios
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioOperario _repoOperario;
        public Operario operario {get; set;}
        public EditModel(IRepositorioOperario repoOperario)
        {
            _repoOperario =repoOperario;
        }
        public IActionResult OnGet(int Id)
        {
          operario=_repoOperario.GetOperario(Id); 
          if(operario==null) 
          {
              return NotFound();
          }else
          return Page();
        }

        public IActionResult OnPost(Operario operario)
        {
           _repoOperario.UpdateOperario(operario);
            return RedirectToPage("index");

        }
    
        
    } 
}


        