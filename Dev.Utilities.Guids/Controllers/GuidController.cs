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
        [Route(nameof(GetSingle))]
        public async Task<IActionResult> GetSingle()
            => Ok(await this.guidsService.GenerateSingle());

        [HttpPost]
        [Route(nameof(GetBulk))]
        public async Task<IActionResult> GetBulk([FromBody] int amount)
            => Ok(await this.guidsService.GenerateBulk(amount));
    }
}
