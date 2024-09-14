using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase 
    {
        private readonly IAppUserService _appUserService;

        public AppUserWorkLocationController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult Index() 
        {
             var values = _appUserService.TUsersListWithWorkLocations();
            return Ok (values);
        }
    }
}
