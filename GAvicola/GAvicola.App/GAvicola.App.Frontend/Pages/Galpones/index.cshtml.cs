using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GAvicola.App.Frontend;
using GAvicola.App.Persistencia;
using GAvicola.Dominio;


namespace GAvicola.App.Frontend.Pages.Galpones
{
    public class IndexModel : PageModel
    {
        private readonly _repoGalpon;
        public IEnumerable<Galpon> galpones { get; set; }
        public IndexModel(IRepositorioGalpon repoGalpon)
        {
            _repoGalpon = repoGalpon;
        }
        public void OnGet()
        {
            galpones = _repoGalpon.GetAllGalpones();
        }

        public override bool Equals(object obj)
        {
            return obj is indexModel model &&
                   EqualityComparer<IRepositorioGalpon>.Default.Equals(_repoGalpon, model._repoGalpon);
        }
    }
}
