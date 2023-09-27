using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Producto
{
    public class DeleteModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public DeleteModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BrickplasWebCore.Model.Producto Producto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Producto = await _context.Producto.FirstOrDefaultAsync(m => m.IdProducto == id);

            if (Producto == null)
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

            Producto = await _context.Producto.FindAsync(id);

            if (Producto != null)
            {
                _context.Producto.Remove(Producto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
