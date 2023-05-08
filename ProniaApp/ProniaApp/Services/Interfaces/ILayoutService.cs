using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface ILayoutService
    {
        Task<List<Setting>> GetSettingDatas();
        Setting GetById(int? id);
        Task<IEnumerable<SectionHeader>> GetSectionsDatasAsync();
        Task<SectionHeader> GetSectionAsync(int? id);
        Task<IEnumerable<SectionBackgroundImage>> GetSectionBackgroundImageDatasAsync();
        Task<SectionBackgroundImage> GetSectionBackgroundImageByIdAsync(int? id);




    }
}
