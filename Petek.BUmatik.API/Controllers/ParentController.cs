using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
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
        IParentService _userService;
        public ParentController(IParentService userService)
        {
            _userService = userService;
        }
        [HttpGet("GetParents")]
        public IActionResult GetParents()
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
        [HttpGet("GetAutomatItems")]
        public IActionResult GetAutomatItems(int? id)
        {
            var result = _userService.GetStudentsByParent(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetSelectedMenuDetailsByStudent")]
        public IActionResult GetSelectedMenuDetailsByStudent(int id,int menuTypeId,DateTime useDate)
        {
            var result = _userService.GetStudentMenuDetails(id,menuTypeId,useDate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetSelectedMenusByStudent")]
        public IActionResult GetSelectedMenusByStudent(int id)
        {
            var result = _userService.GetSelectedMenusByStudent(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("AddSelectedMenuByStudent")]
        public IActionResult AddSelectedMenuByStudent(SelectedMenuItemDTO selectedMenuItems)
        {
            var result = _userService.AddSelectedMenuByStudent(selectedMenuItems);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("AddSelectedPackageMenuByStudent")]
        public IActionResult AddSelectedPackageMenuByStudent(SelectMenuPackageDTO selectMenuPackageDTO)
        {
            var result = _userService.AddSelectedMenuPackageByStudent(selectMenuPackageDTO);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAllSelectedMenusByStudent")]
        public IActionResult GetAllSelectedMenusByStudent(int id)
        {
            var result = _userService.GetAllSelectedMenusByStudent(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("test")]
        public IActionResult Test(string bandNumber)
        {
            var result = new List<String>(){"14","53","18","81" };
            
            return Ok(result);
            
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
