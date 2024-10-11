using Microsoft.EntityFrameworkCore;
using UltimumBotanica.Api.Models;

namespace UltimumBotanica.Api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CultureModel> Culture { get; set; }
        public DbSet<PestModel> Pest { get; set; }
        public DbSet<SeasonModel> Season { get; set; }
        public DbSet<IrrigationModel> Irrigation { get; set; }
        public DbSet<CultureComapatibilityModel> CultureComapatibility { get; set; }
        public DbSet<CultureInformationModel> CultureInformation { get; set; }
    }
}