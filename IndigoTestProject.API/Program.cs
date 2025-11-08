using IndigoTestProject.API.Data;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<IndigoTestDBContext>(opts =>
    opts.UseSqlite(builder.Configuration.GetConnectionString("ConnectionString")));

var app = builder.Build();


Batteries_V2.Init();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<IndigoTestDBContext>();
    db.Database.EnsureCreated();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllers();

app.UseAuthorization();

app.Run();
