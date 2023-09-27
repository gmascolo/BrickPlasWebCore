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
    public class IndexModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public IndexModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        public IList<DetalleVenta> DetalleVenta { get;set; }

        public async Task OnGetAsync()
        {
            DetalleVenta = await _context.detalleVenta.ToListAsync();
        }
    }
}
