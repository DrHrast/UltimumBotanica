using System;
using UltimumBotanica.Api.Models;

namespace UltimumBotanica.Api.Services
{
    public class IrrigationService
    {
        private readonly AppDbContext _context;

        public IrrigationService(AppDbContext context)
        {
            _context = context;
        }

        public IrrigationModel GetIrrigation(int id)
        {
            return _context.Irrigation.FirstOrDefault(q => q.Id == id)!;
        }
    }
}