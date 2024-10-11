using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace UltimumBotanica.Api.Models
{
    public class CultureInformationModel
    {
        [Key]
        public int Id { get; set; }
        public int CultureId { get; set; }
        public int PestId { get; set; }
        public int PlantingSeasonId { get; set; }
        public int IrrigationId { get; set; }
    }
}