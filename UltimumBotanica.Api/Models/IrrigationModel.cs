using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace UltimumBotanica.Api.Models
{
    public class IrrigationModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? WaterConsumption { get; set; }
        public string? IrrigationFrequency { get; set; }
    }
}