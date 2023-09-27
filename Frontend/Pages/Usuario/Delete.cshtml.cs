using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Usuario
{
    public class DeleteModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public DeleteModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BrickplasWebCore.Model.Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.idUsuario == id);

            if (Usuario == null)
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

            Usuario = await _context.Usuario.FindAsync(id);

            if (Usuario != null)
            {
                _context.Usuario.Remove(Usuario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
