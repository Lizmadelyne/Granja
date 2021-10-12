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
    public class DetailsModel : PageModel
    {
       
        private readonly IRepositorioGSugerencia _repoSugerencia;
        public GSugerencia sugerencia {get; set;}
        public DetailsModel(IRepositorioGSugerencia repoSugerencia)
        {
            _repoSugerencia =repoSugerencia;
        }
        public IActionResult OnGet(int Id)
        {
            sugerencia=_repoSugerencia.GetGSugerencia(Id);
            if (sugerencia ==null)
            {
                return NotFound();

            }else
            {
                return Page();

            }
        }
    }
}
