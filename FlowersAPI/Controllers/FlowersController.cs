using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FlowersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlowersController : ControllerBase
    {
        private readonly IFlowerService _flowerService;

        // Constructor
        public FlowersController(IFlowerService flowerService )
        {
            _flowerService = flowerService;
        }
        [HttpGet("information")]
        public async Task<IActionResult> GetAsync()
        {
            var serviceResult = await _flowerService.GetFlowerInformationAsync();
            return StatusCode((int)serviceResult.HttpStatusCode, serviceResult);
        }
    }
}