using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Patente
{
    public class DetailsModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public DetailsModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        public BrickplasWebCore.Model.Patente Patente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patente = await _context.Patente.FirstOrDefaultAsync(m => m.idPatente == id);

            if (Patente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
