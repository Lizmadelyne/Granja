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
    public class Edit1Model : PageModel
    {     private readonly IRepositorioGalpon _repoGalpon;
        public Galpon galpon {get; set;}
        public Edit1Model(IRepositorioGalpon repoGalpon)
        {
            _repoGalpon =repoGalpon;
        }
        public IActionResult OnGet(int Id)
        {
          galpon=_repoGalpon.GetGalpon(Id); 
          if(galpon==null) 
          {
              return NotFound();
          }else
          return Page();
        }

        public IActionResult OnPost(Galpon galpon)
        {
           _repoGalpon.UpdateGalpon(galpon);
            return RedirectToPage("Index1");

        }
    
        
    } 
}
