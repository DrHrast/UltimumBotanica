using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UltimumBotanica.Api.Models;
using UltimumBotanica.Api.Services;

namespace UltimumBotanica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PestController
    {
        private readonly PestService _pestService;

        public PestController(PestService pestService)
        {
            _pestService = pestService;
        }

        [HttpPost]
        [Route("GetById")]
        public PestModel GetPest(int id)
        {
            return _pestService.GetPest(id);
        }
    }
}