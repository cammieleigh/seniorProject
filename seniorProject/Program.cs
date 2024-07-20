using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Auth0.AspNetCore.Authentication;
using Carts.Data;
using Reviews.Data;
using seniorProject.Data;
// using Reviews.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RequestContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RequestContext") ?? throw new InvalidOperationException("Connection string 'RequestContext' not found.")));
builder.Services.AddDbContext<ReviewContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ReviewContext") ?? throw new InvalidOperationException("Connection string 'ReviewContext' not found.")));
// builder.Services.AddDbContext<ReviewContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("ReviewContext") ?? throw new InvalidOperationException("Connection string 'ReviewContext' not found.")));

builder.Services.AddDbContext<CartContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CartContext") ?? throw new InvalidOperationException("Connection string 'CartContext' not found.")));


builder.Services.AddDbContext<ProductContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductContext") ?? throw new InvalidOperationException("Connection string 'ProductContext' not found.")));

builder.Services.AddDbContext<ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjectContext") ?? throw new InvalidOperationException("Connection string 'ProjectContext' not found.")));

    builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = builder.Configuration["Auth0:Domain"];
    options.ClientId = builder.Configuration["Auth0:ClientId"];
});

builder.Services.AddControllersWithViews();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
