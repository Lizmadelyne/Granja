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
    public class createModel : PageModel
    {  private readonly IRepositorioVeterinario _repoVeterinario;
        public Veterinario  veterinario {get; set;}
        public createModel(IRepositorioVeterinario repoVeterinario)
        {
            _repoVeterinario=repoVeterinario;
        }

        public void OnGet()
        {
          veterinario = new Veterinario();
        }

        public IActionResult OnPost(Veterinario veterinario)
        {
        if (ModelState.IsValid)
        {
            _repoVeterinario.AddVeterinario(veterinario);
            return RedirectToPage("index");

        }else
        {
         return Page();
        }
        }
    }
}
    
       