using DotNetEd.CoreAdmin.DemoAppDotNet6.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add the DB Contexts
//builder.Services.AddDbContext<TestDbContext>(options => options.UseInMemoryDatabase("TestDatabase"));

builder.Services.AddSqlServer<ChinookContext>(builder.Configuration.GetConnectionString("Database"));


// add Core Admin
//builder.Services.AddCoreAdmin("Administrator");
builder.Services.AddCoreAdmin();

var app = builder.Build();


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

app.UseCoreAdminCustomTitle("대학내일 관리자 화면");

// Required for Core Admin
app.MapDefaultControllerRoute();

app.Run();
