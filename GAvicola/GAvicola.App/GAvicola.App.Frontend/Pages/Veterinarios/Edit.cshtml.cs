using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.Veterinarios
{
    public class EditModel : PageModel
    {
         private readonly IRepositorioVeterinario _repoVeterinario;
        public Veterinario veterinario {get; set;}
        public EditModel(IRepositorioVeterinario repoVeterinario)
        {
            _repoVeterinario =repoVeterinario;
        }
        public IActionResult OnGet(int Id)
        {
          veterinario=_repoVeterinario.GetVeterinario(Id); 
          if(veterinario==null) 
          {
              return NotFound();
          }else
          return Page();
        }

        public IActionResult OnPost(Veterinario veterinario)
        {
           _repoVeterinario.UpdateVeterinario(veterinario);
            return RedirectToPage("index");

        }
    
        
    } 
}


        

