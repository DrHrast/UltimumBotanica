using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace UltimumBotanica.Api.Models
{
    public class PestModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PestType { get; set; }
        public string? DamageType { get; set; }
        public string? ControlMethod { get; set; }
        public int EffectSeasonId { get; set; }
        public string? PestImgUrl { get; set; }
    }
}