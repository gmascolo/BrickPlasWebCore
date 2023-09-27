using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Pedido.Detalle
{
    public class DeleteModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public DeleteModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DetallePedido DetallePedido { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DetallePedido = await _context.DetallePedido.FirstOrDefaultAsync(m => m.IdDetallePedido == id);

            if (DetallePedido == null)
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

            DetallePedido = await _context.DetallePedido.FindAsync(id);

            if (DetallePedido != null)
            {
                _context.DetallePedido.Remove(DetallePedido);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
