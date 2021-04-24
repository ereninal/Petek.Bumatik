using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petek.BUmatik.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petek.BUmatik.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        IUserService _userService;
        public ParentController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("GetParents")]
        public IActionResult GetSchools()
        {
            var result = _userService.GetParentDTOs();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
