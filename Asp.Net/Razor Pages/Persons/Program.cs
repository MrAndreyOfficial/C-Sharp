using Microsoft.EntityFrameworkCore;
using Persons.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<PersonsContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PersonsContext") ?? throw new InvalidOperationException("Connection string 'PersonsContext' not found.")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
