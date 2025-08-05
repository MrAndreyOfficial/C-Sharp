using Microsoft.EntityFrameworkCore;
using Persons.Models;

namespace Persons.Data
{
    public class PersonsContext(DbContextOptions<PersonsContext> options) : DbContext(options)
    {
        public DbSet<Person> Person { get; set; } = default!;
    }
}
