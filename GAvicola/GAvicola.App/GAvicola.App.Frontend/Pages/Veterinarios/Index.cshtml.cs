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
    public class indexModel : PageModel
    {

        private readonly IRepositorioVeterinario _repoVeterinario;

        public IEnumerable<Veterinario> veterinarios {get; set; }

        public indexModel(IRepositorioVeterinario repoVeterinario)
        {
            _repoVeterinario=repoVeterinario;
        }

        public void OnGet()
        {
            veterinarios=_repoVeterinario.GetAllVeterinarios();
        }
    }
}
