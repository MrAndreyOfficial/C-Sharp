using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Persons.Data;
using Persons.Models;

namespace Persons.Pages
{
    public class IndexModel(PersonsContext context) : PageModel
    {
        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync() => Person = await context.Person.ToListAsync();
    }
}
