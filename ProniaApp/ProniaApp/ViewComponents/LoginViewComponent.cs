using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProniaApp.Models;
using ProniaApp.ViewModels.Account;

namespace ProniaApp.ViewComponents
{
    public class LoginViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            LoginVM model = new();
            return await Task.FromResult(View(model));
        }
    }
}
