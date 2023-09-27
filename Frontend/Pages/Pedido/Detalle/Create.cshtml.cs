using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Pedido.Detalle
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
        public DetallePedido DetallePedido { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DetallePedido.Add(DetallePedido);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
