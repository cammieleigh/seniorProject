using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Auth0.AspNetCore.Authentication;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using seniorProject.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using SeniorProject.Models;



namespace seniorProject.Controllers;

public class AccountController : Controller
{
  public async Task Login(string returnUrl = "/")
  {
    var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
      // Indicate here where Auth0 should redirect the user after a login.
      // Note that the resulting absolute Uri must be added to the
      // **Allowed Callback URLs** settings for the app.
      .WithRedirectUri("http://localhost:3000/")
      .Build();

    await HttpContext.ChallengeAsync(
      Auth0Constants.AuthenticationScheme,
      authenticationProperties
    );
  }

public string checkLoginStatus()
{
  ViewBag.Check = "Login";
  
  string check = User.Identity.GetUserId();

  if (check != null){
    ViewBag.Check = "Logout";
    return ViewBag.Check;
  }
  else{
   ViewBag.Check = "Login";
    return ViewBag.Check;
  }
}  
[Authorize]
  public IActionResult AddToCart(int Id, string Img, float Price, string Name)
  {
    var c = new Cart{
      ProductId = Id,
      UserId = User.Identity.GetUserId(),
      ProductImg = Img,
      ProductPrice = Price,
      ProductName = Name};

    return RedirectToAction(
    
    "Create","Cart", c
    
  );
  }

  [Authorize]
  public IActionResult ViewCart()
  {
  

    return RedirectToAction(
    
    "UserCart","Cart",new {UserId = User.Identity.GetUserId()} 
    
  );
  }

  [Authorize]
  public async Task Logout()
  {
    var authenticationProperties = new LogoutAuthenticationPropertiesBuilder()
      // Indicate here where Auth0 should redirect the user after a logout.
      // Note that the resulting absolute Uri must be added to the
      // **Allowed Logout URLs** settings for the app.
      .WithRedirectUri(Url.Action("Index", "Home"))
      .Build();

    // Logout from Auth0
    await HttpContext.SignOutAsync(
      Auth0Constants.AuthenticationScheme,
      authenticationProperties
    );
    // Logout from the application
    await HttpContext.SignOutAsync(
      CookieAuthenticationDefaults.AuthenticationScheme
    );
  }}