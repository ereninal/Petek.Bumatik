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
    public class AutomatController : ControllerBase
    {
        IMenuProcessesService _menuProcessesService;
        public AutomatController(IMenuProcessesService menuProcessesService)
        {
            _menuProcessesService = menuProcessesService;
        }
        
        [HttpGet("GetAutomatItems")]
        public IActionResult GetAutomatItems()
        {
            var result = _menuProcessesService.GetItemsDTO();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
