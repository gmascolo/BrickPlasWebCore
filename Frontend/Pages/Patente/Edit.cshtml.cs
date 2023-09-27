using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Patente
{
    public class EditModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public EditModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Patente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatenteExists(Patente.idPatente))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PatenteExists(int id)
        {
            return _context.Patente.Any(e => e.idPatente == id);
        }
    }
}
