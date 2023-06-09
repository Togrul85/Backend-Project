﻿using BackendProject.Constans;
using BackendProject.DAL;
using BackendProject.Services.Interface;
using BackendProject.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using BackendProject.Models;
using BackendProject.Constans;

using System.Security.Authentication;
using MailKit.Net.Smtp;
using BackendProject.Services.Email;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString, x => x.MigrationsAssembly("DataAccess")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=account}/{action=login}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();

using (var scope = scopeFactory.CreateScope())
{
    var userManager = scope.ServiceProvider.GetService<UserManager<AppUser>>();
    var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

    var _configuration = scope.ServiceProvider.GetService<IConfiguration>();

    await Dbİnitializer.SeedAsync(userManager, roleManager, _configuration);
}



app.Run(); 