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
    public class AddOperariosModel : PageModel
    {
        private readonly IRepositorioGalpon _repoGalpon;
        private readonly IRepositorioOperario _repoOperario;

        public Galpon galpon { get; set; }
        public IEnumerable<Operario> operarios { get; set; }

        public AddOperariosModel(IRepositorioGalpon repoGalpon, IRepositorioOperario repoOperario)
        {
            _repoGalpon=repoGalpon;
            _repoOperario=repoOperario;
        }


        public void OnGet(int id)
        {
            galpon=_repoGalpon.GetGalpon(id);
            operarios=_repoOperario.GetAllOperarios();
        }
        public IActionResult OnPost(int IdGalpon, int IdOperario )
        {
            _repoGalpon.AsignarOperario(IdGalpon, IdOperario);
            return RedirectToPage("Details1", new {Id=IdGalpon});
        }
    }
}

