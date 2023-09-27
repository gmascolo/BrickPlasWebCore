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

namespace Frontend.Pages.Familia
{
    public class EditModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public EditModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BrickplasWebCore.Model.Familia Familia { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Familia = await _context.Familia.FirstOrDefaultAsync(m => m.idFamilia == id);

            if (Familia == null)
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

            _context.Attach(Familia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamiliaExists(Familia.idFamilia))
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

        private bool FamiliaExists(int id)
        {
            return _context.Familia.Any(e => e.idFamilia == id);
        }
    }
}
