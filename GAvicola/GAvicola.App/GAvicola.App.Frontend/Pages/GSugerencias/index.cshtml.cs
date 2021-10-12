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
    public class indexModel : PageModel
    {
        private readonly IRepositorioGSugerencia _repoSugerencia;
        public IEnumerable<GSugerencia> GSugerencia {get; set;}
        public indexModel(IRepositorioGSugerencia repoSugerencia)
        {
            _repoSugerencia=repoSugerencia;
        }

        public void OnGet()
        {
             GSugerencia=_repoSugerencia.GetAllGSugerencias();
        }
    }
}

        