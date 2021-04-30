using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Entities.Concrete;
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
        [HttpGet("GetStudentByParent")]
        public IActionResult GetStudentByParent(int? id)
        {
            var result = _userService.GetStudentsByParent(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("AddStudentByParent")]
        public IActionResult AddStudentByParent(Student student)
        {
            var result = _userService.AddStudentByParent(student);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        //[HttpPost("SetMenuByNumber")]
        //public IActionResult GetStudentByParent()
        //{
        //    var result = _userService.SetMenuByNumber(bandNumber);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}
