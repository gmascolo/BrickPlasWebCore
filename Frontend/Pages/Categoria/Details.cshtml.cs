using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;
using Frontend.Data;

namespace Frontend.Pages.Categoria
{
    public class DetailsModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public DetailsModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        public BrickplasWebCore.Model.Categoria Categoria { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Categoria = await _context.Categoria.FirstOrDefaultAsync(m => m.Idcategoria == id);

            if (Categoria == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
