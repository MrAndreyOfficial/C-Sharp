using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Persons.Data;
using Persons.Models;

namespace Persons.Pages
{
    public class EditModel(PersonsContext context) : PageModel
    {
        [BindProperty]
        public Person Person { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            var person =  await context.Person.FirstOrDefaultAsync(m => m.Id == id);

            if (person == null)
                return NotFound();

            Person = person;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            context.Attach(Person).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(Person.Id))
                    return NotFound();

                throw;
            }

            return RedirectToPage("./Index");
        }

        private bool PersonExists(int id) => context.Person.Any(e => e.Id == id);
    }
}
