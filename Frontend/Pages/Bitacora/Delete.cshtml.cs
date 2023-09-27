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
    public class DeleteModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public DeleteModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BrickplasWebCore.Model.Bitacora Bitacora { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bitacora = await _context.Bitacora.FirstOrDefaultAsync(m => m.idBitacora == id);

            if (Bitacora == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bitacora = await _context.Bitacora.FindAsync(id);

            if (Bitacora != null)
            {
                _context.Bitacora.Remove(Bitacora);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
