using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Bitacora
{
    public class IndexModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public IndexModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        public IList<BrickplasWebCore.Model.Bitacora> Bitacora { get;set; }

        public async Task OnGetAsync()
        {
            Bitacora = await _context.Bitacora.ToListAsync();
        }
    }
}
