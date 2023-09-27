using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend.Pages
{
    public class TiendaModel : PageModel
    {
        private readonly ILogger<TiendaModel> _logger;

        public TiendaModel(ILogger<TiendaModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
