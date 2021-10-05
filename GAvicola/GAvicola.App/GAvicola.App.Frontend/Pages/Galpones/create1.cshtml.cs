using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Galpones
{
    public class create1Model : PageModel
    {
        private readonly IRepositorioGalpon _repoGalpon;
        public Galpon galpon {get; set;}
        public create1Model(IRepositorioGalpon repoGalpon)
        {
            _repoGalpon=repoGalpon;
        }

        public void OnGet()
        {
          galpon = new Galpon();
        }

        public IActionResult OnPost(Galpon galpon)
        {
        if (ModelState.IsValid)
        {
            _repoGalpon.AddGalpon(galpon);
            return RedirectToPage("Index1");

        }else
        {
         return Page();
        }
        }
    }
}
    
    
            