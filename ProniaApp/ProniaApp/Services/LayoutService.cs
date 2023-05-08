using Microsoft.EntityFrameworkCore;
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

        public  Setting GetById(int? id)
        {
            return _context.Settings.Where(s => s.Id == id).FirstOrDefault(); 
        }

        public async Task<SectionHeader> GetSectionAsync(int? id)
        {
            return await _context.SectionHeaders.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<SectionBackgroundImage> GetSectionBackgroundImageByIdAsync(int? id)
        {
            return  await _context.SectionBackgroundImages.FirstOrDefaultAsync(sb=>sb.Id==id);
        }

        public async Task<IEnumerable<SectionBackgroundImage>> GetSectionBackgroundImageDatasAsync()
        {
            return await _context.SectionBackgroundImages.ToListAsync();
        }

        public async Task<IEnumerable<SectionHeader>> GetSectionsDatasAsync()
        {
            return await _context.SectionHeaders.ToListAsync();
        }

        public  async Task<List<Setting>> GetSettingDatas()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();

            return settings;
        }
    }
}
