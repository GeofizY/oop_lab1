using Microsoft.EntityFrameworkCore;
using mUsic.Database;
using mUsic.Services.Interfaces;
using mUsic.Services.Realizations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MusicDbContext>(x => x.UseNpgsql(builder.Configuration.GetConnectionString("Postgres")));

builder.Services.AddScoped<ISongService, SongService>();
builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
// builder.Services.AddScoped<IAuthorService, AuthorService>();
// builder.Services.AddScoped<IAlbumService, AlbumService>();
// builder.Services.AddScoped<ICollectionervice, CollectionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();