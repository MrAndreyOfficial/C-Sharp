using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persons.Data;
using Persons.Models;

namespace Persons.Pages
{
    public class CreateModel(PersonsContext context) : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Person Person { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            context.Person.Add(Person);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
