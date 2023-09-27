using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend.Pages.Usuario
{
    public class LoginModel : PageModel
    {
        private readonly Frontend.Data.CasaContext _context;

        public LoginModel(Frontend.Data.CasaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BrickplasWebCore.Model.Usuario Usuario { get; set; }

        public async Task<IActionResult> OnPostAsync(String? nombreUsuario, String? contrasena)
        {
            if (nombreUsuario == null)
            {
                return NotFound();
            }

            Usuario = await _context.Usuario.FindAsync(nombreUsuario);

            if (Usuario == null)
            {
                return NotFound();
            }
            if (Usuario.contrasena == contrasena )
            {
                Response.Redirect("LoginOK.cshtml");
            }
            return Page();
        }
    }
}
