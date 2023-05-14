using Microsoft.AspNetCore.Mvc;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Layout;

namespace ProniaApp.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly ILayoutService _layoutService;
        public FooterViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            LayoutVM model = new()
            {
                GetSettingDatas = _layoutService.GetSettings()
            };
            return await Task.FromResult(View(model));
        }
    }
}
