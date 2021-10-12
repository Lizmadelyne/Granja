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
    public class indexModel : PageModel
    {
        private readonly IRepositorioGAmbiente _repoGAmbiente;

        public IEnumerable<GAmbiente> GAmbientes {get; set;}
        public indexModel(IRepositorioGAmbiente repoGAmbiente)
        {
            _repoGAmbiente=repoGAmbiente;
        }

        public void OnGet()
        {
             GAmbientes=_repoGAmbiente.GetAllGAmbientes();
        }
    }
}
