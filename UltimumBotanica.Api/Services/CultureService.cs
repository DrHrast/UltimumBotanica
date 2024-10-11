using System;
using UltimumBotanica.Api.Models;

namespace UltimumBotanica.Api.Services
{
    public class CultureService
    {
        public readonly AppDbContext _context;

        public CultureService(AppDbContext context)
        {
            _context = context;
        }

        public CultureModel GetCulture(int id)
        {
            return _context.Culture.FirstOrDefault(q => q.Id == id)!;
        }

        public string GetCultureName(int id)
        {
            return _context.Culture.FirstOrDefault(q => q.Id == id)?.Name!;
        }

        public string GetCultureGroup(int id)
        {
            return _context.Culture.FirstOrDefault(q => q.Id == id)?.Group!;
        }
    }
}