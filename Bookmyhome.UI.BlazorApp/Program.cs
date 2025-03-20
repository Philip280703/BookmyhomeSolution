using Bookmyhome.UI.BlazorApp.Components;
using Bookmyhome.UI.BlazorApp.Controller;
using Bookmyhome.Application.RepositoryInterfaces;
using Bookmyhome.Application.Command;
using Bookmyhome.Application.Command.Interfaces;
using Bookmyhome.Command.Services;
using Bookmyhome.Persistence.Repository;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

// Commands
builder.Services.AddScoped<IBoligCommand, BoligCommand>();
builder.Services.AddScoped<IAdresseCommand, AdresseCommand>();
builder.Services.AddScoped<IAnmeldelseCommand, AnmeldelseCommand>();
builder.Services.AddScoped<IBookingCommand, BookingCommand>();
builder.Services.AddScoped<IBrugerCommand, BrugerCommand>();
builder.Services.AddScoped<IPostnummerOgByCommand, PostnummerOgByCommand>();

// Repositories
builder.Services.AddScoped<IAdresseRepository, AdresseRepository>();
builder.Services.AddScoped<IAnmeldelseRepository, AnmeldelseRepository>();
builder.Services.AddScoped<IBoligRepository, BoligRepository>(); 
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IBrugerRepository, BrugerRepository>();
builder.Services.AddScoped<IPostnummerOgByRepository, PostnummerOgByRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();
