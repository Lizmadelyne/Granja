using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages
{
    public class createModel : PageModel
    {
         private readonly IRepositorioGAmbiente _repoGAmbiente;
        public GAmbiente gAmbiente {get; set;}
        public createModel(IRepositorioGAmbiente repoGAmbiente)
        {
            _repoGAmbiente=repoGAmbiente;
        }

        public void OnGet()
        {
          gAmbiente = new GAmbiente();
        }

        public IActionResult OnPost(GAmbiente gAmbiente)
        {
        if (ModelState.IsValid)
        {
            _repoGAmbiente.AddGAmbiente(gAmbiente);
            return RedirectToPage("index");

        }else
        {
         return Page();
        }
        }
    }
}
    
     
        
