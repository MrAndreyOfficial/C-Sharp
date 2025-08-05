using System.ComponentModel.DataAnnotations;

namespace Persons.Models;

public class Person
{
    private const int MaxNameLength = 20;

    public int Id { get; set; }

    [Required, MaxLength(MaxNameLength)]
    public string? FirstName { get; set; }

    [Required, MaxLength(MaxNameLength)]
    public string? LastName { get; set; }

    [DataType(DataType.Date), Display(Name = "Birthday")]
    public DateTime BirthDay { get; set; }
}
