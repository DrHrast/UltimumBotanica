using System;
using UltimumBotanica.Api.Models;

namespace UltimumBotanica.Api.Services
{
    public class SeasonService
    {
        private readonly AppDbContext _context;

        public SeasonService(AppDbContext context)
        {
            _context = context;
        }

        public SeasonModel GetSeason(int id)
        {
            return _context.Season.FirstOrDefault(q => q.Id == id)!;
        }
    }
}