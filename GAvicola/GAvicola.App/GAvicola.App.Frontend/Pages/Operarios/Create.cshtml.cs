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
    public class CreateModel : PageModel
    {
          private readonly IRepositorioOperario _repoOperario;
        public Operario operario {get; set;}
        public CreateModel(IRepositorioOperario repoOperario)
        {
            _repoOperario=repoOperario;
        }

        public void OnGet()
        {
          operario = new Operario();
        }

        public IActionResult OnPost(Operario operario)
        {
        if (ModelState.IsValid)
        {
            _repoOperario.AddOperario(operario);
            return RedirectToPage("index");

        }else
        {
         return Page();
        }
        }
    }
}
    
     