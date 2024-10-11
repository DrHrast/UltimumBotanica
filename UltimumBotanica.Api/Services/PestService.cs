using System;
using UltimumBotanica.Api.Models;

namespace UltimumBotanica.Api.Services
{
    public class PestService
    {
        private readonly AppDbContext _context;

        public PestService(AppDbContext context)
        {
            _context = context;
        }

        public PestModel GetPest(int id)
        {
            return _context.Pest.FirstOrDefault(q => q.Id == id)!;
        }
    }
}