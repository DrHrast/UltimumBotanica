using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace UltimumBotanica.Api.Models
{
    public class CultureComapatibilityModel
    {
        [Key]
        public int Id { get; set; }
        public int SpeciesId { get; set; }
        public int NeighbourId { get; set; }
        public double CompatibilityGrade { get; set; }
    }
}