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
    public class indexModel : PageModel
    {

        private readonly IRepositorioOperario _repoOperario;

        public IEnumerable<Operario> operario {get; set; }

        public indexModel(IRepositorioOperario repoOperario)
        {
            _repoOperario=repoOperario;
        }

        public void OnGet()
        {
            operario=_repoOperario.GetAllOperarios();
        }
    }
}
