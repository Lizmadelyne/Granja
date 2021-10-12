using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Dominio;
using GAvicola.App.Persistencia;

namespace GAvicola.App.Frontend.Pages.GAmbientes
{
    public class DetailsModel : PageModel
    {
     private readonly IRepositorioGAmbiente _repoGAmbiente;
        public GAmbiente gambiente{get; set;}
        public DetailsModel(IRepositorioGAmbiente repoGAmbiente)
        {
            _repoGAmbiente =repoGAmbiente;
        }
        public IActionResult OnGet(int Id)
        {
            gambiente=_repoGAmbiente.GetGAmbiente(Id);
            if (gambiente ==null)
            {
                return NotFound();

            }else
            {
                return Page();

            }
        }
    }
}


