using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.GSugerencias
{
    public class CreateModel : PageModel
    {
         private readonly IRepositorioGSugerencia _repoSugerencia;
        public GSugerencia sugerencia {get; set;}
        public CreateModel(IRepositorioGSugerencia repoSugerencia)
        {
            _repoSugerencia=repoSugerencia;
        }

        public void OnGet()
        {
          sugerencia = new GSugerencia();
        }

        public IActionResult OnPost(GSugerencia sugerencia)
        {
        if (ModelState.IsValid)
        {
            _repoSugerencia.AddGSugerencia(sugerencia);
            return RedirectToPage("index");

        }else
        {
         return Page();
        }
        }
    }
}
    
       