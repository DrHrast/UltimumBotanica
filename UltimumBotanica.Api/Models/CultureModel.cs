using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace UltimumBotanica.Api.Models
{
    public class CultureModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Group { get; set; }
    }
}