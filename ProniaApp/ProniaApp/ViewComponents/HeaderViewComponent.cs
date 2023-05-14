using Microsoft.AspNetCore.Mvc;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Layout;
using System.ComponentModel;

namespace ProniaApp.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly ILayoutService _layoutService;
        private readonly ICartService _cartService;
        public HeaderViewComponent(ILayoutService layoutService, 
                                ICartService cartService)
        {
            _layoutService = layoutService;
            _cartService = cartService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            LayoutVM model = new()
            {
                GetSettingDatas =  _layoutService.GetSettings(),
                BasketCount = _cartService.GetDatasFromCookie().Count
            };
            return await Task.FromResult(View(model));
        }
    }
}
