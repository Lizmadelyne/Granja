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
    public class AddVeterinariosModel : PageModel
    {
        private readonly IRepositorioGalpon _repoGalpon;
        private readonly IRepositorioVeterinario _repoVeterinario;

        public Galpon galpon { get; set; }
        public IEnumerable<Veterinario> veterinarios { get; set; }

        public AddVeterinariosModel(IRepositorioGalpon repoGalpon, IRepositorioVeterinario repoVeterinario)
        {
            _repoGalpon=repoGalpon;
            _repoVeterinario=repoVeterinario;
        }


        public void OnGet(int Id)
        {
            galpon=_repoGalpon.GetGalpon(Id);
            veterinarios=_repoVeterinario.GetAllVeterinarios();
        }
        public IActionResult OnPost(int IdGalpon, int IdVeterinario )
        {
            _repoGalpon.AsignarVeterinario(IdGalpon, IdVeterinario);
            return RedirectToPage("Details", new {Id=IdGalpon});
        }
    }
}

