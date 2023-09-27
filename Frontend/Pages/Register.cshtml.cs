using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend.Pages.Usuario
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
        public BrickplasWebCore.Model.Usuario Usuario { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (Usuario != null) {

                Usuario.habilitado = true;
                _context.Usuario.Add(Usuario);
                await _context.SaveChangesAsync();

            }



            return RedirectToPage("./Index");
        }
    }
}
