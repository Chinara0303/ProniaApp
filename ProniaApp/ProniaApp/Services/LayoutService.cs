using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public  Setting GetByValue(int? id)
        {
            return _context.Settings.Where(s => s.Id == id).FirstOrDefault(); 
        }


        public  Dictionary<string, string> GetSettingDatas()
        {
            Dictionary<string, string> settings =  _context.Settings
                .AsEnumerable()
                .ToDictionary(s => s.Key, s => s.Value);

            return settings;
        }
    }
}
