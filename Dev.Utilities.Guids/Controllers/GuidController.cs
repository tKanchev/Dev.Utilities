using Dev.Utilities.Controllers;
using Dev.Utilities.Guids.Services.Guids;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dev.Utilities.Guids.Controllers
{
    public class GuidController : BaseController
    {
        private readonly IGuidService guidsService;

        public GuidController(IGuidService guidsService)
        {
            this.guidsService = guidsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await this.guidsService.GenerateSingle());

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] int amount)
            => Ok(await this.guidsService.GenerateBulk(amount));
    }
}
