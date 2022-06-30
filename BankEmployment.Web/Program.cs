using BankEmployment.Domain.Interfaces;
using BankEmployment.Infrastructure.DataContext;
using BankEmployment.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BankEmploymentDBContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("BankEmploymentConnectionString")));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkRepository>();



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    if (scope != null)
    {
        var context = scope.ServiceProvider.GetService<BankEmploymentDBContext>();
        context.Database.Migrate();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
