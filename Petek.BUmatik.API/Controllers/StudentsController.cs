using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.Concrete;
using Petek.BUmatik.DataAccess.Concrete.EntitiyFramework;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petek.BUmatik.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
         [HttpGet]
        public List<Student> Get()
        {
            IStudentService studentService = new StudentManager(new EfStudentDal());
            var result = studentService.GetAllStudents();
            return result.Data;
        }
    }
}
