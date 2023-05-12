using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Layout;
using ProniaApp.ViewModels.Account;

namespace ProniaApp.ViewComponents
{
    public class RegisterViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            RegisterVM model = new();
            return await Task.FromResult(View(model));
        }
    }
}
