using System.Reflection;
using BlazorSampleCrud.Core.Services.ConcreateClass;
using BlazorSampleCrud.Core.Services.Interfaces;
using BlazorSampleCrud.DataAccessLayer.ContextSample;
using BlazorSampleCrud.DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.FileProviders;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddFluentValidation(fv =>fv.RegisterValidatorsFromAssembly(Assembly.Load("BlazorSampleCrud.App.Shread")) );
var connectionString = builder.Configuration.GetConnectionString("BlazorCrudConnectionString");
builder.Services.AddDbContext<BlazorSampleContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped(typeof(ICustomerRepository<>) , typeof(CustomerRepository<>));
builder.Services.AddScoped<ICustomerService, CustomerService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseRouting();
app.MapFallbackToFile("index.html");
app.Run();
