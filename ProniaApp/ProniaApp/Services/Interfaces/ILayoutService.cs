using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface ILayoutService
    {
        Dictionary<string, string> GetSettingDatas();
        Setting GetByValue(int? id);

    }
}
