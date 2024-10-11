using Microsoft.AspNetCore.Mvc;
using UltimumBotanica.Api.Models;
using UltimumBotanica.Api.Services;

namespace UltimumBotanica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CultureController
    {
        private readonly CultureService _cultureService;

        public CultureController(CultureService cultureService)
        {
            _cultureService = cultureService;
        }

        [HttpPost]
        [Route("GetById")]
        public CultureModel GetCulture(int id)
        {
            return _cultureService.GetCulture(id);
        }

        [HttpPost]
        [Route("GetNameById")]
        public string GetCultureName(int id)
        {
            return _cultureService.GetCultureName(id);
        }

        [HttpPost]
        [Route("GetGroupById")]
        public string GetCultureGroup(int id)
        {
            return _cultureService.GetCultureGroup(id);
        }
    }
}