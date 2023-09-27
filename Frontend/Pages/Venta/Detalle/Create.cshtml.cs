using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Venta.Detalle
{
    public class CreateModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public CreateModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DetalleVenta DetalleVenta { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.detalleVenta.Add(DetalleVenta);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
