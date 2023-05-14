using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Common;
using ProniaApp.Data;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Account;
using ProniaApp.ViewModels.Cart;

namespace ProniaApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IEmailService _emailService;
        private readonly ICartService _cartService ;
        private readonly ICrudService<Cart> _crudService;

        public AccountController(UserManager<AppUser> userManager,
                                    SignInManager<AppUser> signInManager,
                                    IEmailService emailService,
                                    ICartService cartService,
                                    ICrudService<Cart> crudService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
            _cartService = cartService;
            _crudService = crudService;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            try
            {
                if (!ModelState.IsValid) return RedirectToAction("Index",model);
                Random random = new();
                AppUser newUser = new()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.FirstName.Substring(0,2) + "_" + model.LastName.Substring(0, 2) + "_" + random.Next(100,1000)
                };

                IdentityResult result = await _userManager.CreateAsync(newUser, model.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return RedirectToAction("Index",model);
                }

                string token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                string link = Url.Action(nameof(ConfirmEmail), "Account", new { userId = newUser.Id, token },
                                            Request.Scheme, Request.Host.ToString());


                string subject = "Register Confirmation";
                string html = string.Empty;

                using (StreamReader reader = new("wwwroot/templates/verify.html"))
                {
                    html = reader.ReadToEnd();
                }

                html = html.Replace("{{link}}", link);

                _emailService.Send(newUser.Email, subject, html);



                return RedirectToAction(nameof(VerifyEmail));

            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return RedirectToAction("Index", model);
            }

        }
        public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {
            if (userId is null || token is null) return BadRequest();
            AppUser user = await _userManager.FindByIdAsync(userId);
            if (user is null) return NotFound();

            await _userManager.ConfirmEmailAsync(user, token);

            await _signInManager.SignInAsync(user, user.IsRemember);

            Cart dbCart = await _cartService.GetByUserIdAsync(userId);

            if(dbCart is null)
            {
                dbCart = new()
                {
                    AppUserId = userId,
                    CartProducts = new List<CartProduct>()
                };
            }

            List<CartProduct> carts = await _cartService.GetAllByCartIdAsync(dbCart.Id);

            List<CartVM> cartVMs = new();
            CartVM cart = new CartVM()
            {
                ProductId = carts.FirstOrDefault().ProductId,
                Count = carts.Count
            };
            cartVMs.Add(cart);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(cartVMs));

            return RedirectToAction("Index", "Home");
        }
        public IActionResult VerifyEmail()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model)
        {
            try
            {
                if (!ModelState.IsValid) return RedirectToAction("Index",model);

                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Email or password is wrong");
                    RedirectToAction("Index", model);
                }

                var res = await _signInManager.PasswordSignInAsync(user, model.Password, model.IsRemember, false);

                if (!res.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Email or password is wrong");
                    RedirectToAction("Index", model);
                }

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(string userId)
        {
            await _signInManager.SignOutAsync();

            List<CartVM> carts = _cartService.GetDatasFromCookie();
            Cart dbCart = await _cartService.GetByUserIdAsync(userId);

            if (dbCart == null)
            {
                dbCart = new()
                {
                    AppUserId = userId,
                    CartProducts = new List<CartProduct>()
                };
            }
            foreach (var cart in carts)
            {
                dbCart.CartProducts.Add(new CartProduct()
                {
                    ProductId = cart.ProductId,
                    CartId = dbCart.Id,
                    Count = cart.Count
                });
            }

            await _crudService.CreateAsync(dbCart);
            Response.Cookies.Delete("basket");

            return RedirectToAction("Index", "Home");
        }
    }
}
