using ProniaApp.ViewModels.Cart;

namespace ProniaApp.ViewModels.Layout
{
    public class LayoutVM
    {
        public Dictionary<string, string> GetSettingDatas { get; set; }
        public IEnumerable<CartVM> CartVMs { get; set; }
        public int BasketCount { get; set; }
    }
}
