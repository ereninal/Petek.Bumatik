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
        IAutomatService _automatService;
        public AutomatController(IAutomatService automatService)
        {
            _automatService = automatService;
        }
        
        [HttpGet("GetAutomatItems")]
        public IActionResult GetAutomatItems()
        {
            var result = _automatService.GetItemsDTO();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetMenuTypes")]
        public IActionResult GetMenuType()
        {
            var result = _automatService.GetMenuTypeDTO();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetMenuItemsByStudent")]
        public IActionResult GetAutomatItems(string bandNumber,DateTime useDate,int menuTypeId)
        {
            var result = _automatService.GetMenuItemsByStudent(bandNumber, useDate,menuTypeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
