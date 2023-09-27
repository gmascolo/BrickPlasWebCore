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

namespace Frontend.Pages.Venta.Detalle
{
    public class EditModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public EditModel(Frontend.Data.CasaContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DetalleVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleVentaExists(DetalleVenta.IdDetalleVenta))
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

        private bool DetalleVentaExists(int id)
        {
            return _context.detalleVenta.Any(e => e.IdDetalleVenta == id);
        }
    }
}
