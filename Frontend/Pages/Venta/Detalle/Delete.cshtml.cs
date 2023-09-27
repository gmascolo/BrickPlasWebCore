using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Venta.Detalle
{
    public class DeleteModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public DeleteModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DetalleVenta DetalleVenta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DetalleVenta = await _context.detalleVenta.FirstOrDefaultAsync(m => m.IdDetalleVenta == id);

            if (DetalleVenta == null)
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

            DetalleVenta = await _context.detalleVenta.FindAsync(id);

            if (DetalleVenta != null)
            {
                _context.detalleVenta.Remove(DetalleVenta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
