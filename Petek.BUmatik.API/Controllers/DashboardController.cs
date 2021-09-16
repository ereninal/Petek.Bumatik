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
    public class DashboardController : ControllerBase
    {
        IDashboardService _IDashboardService;
        ITransactionService _ITransactionService;
        public DashboardController(IDashboardService dashboardService, ITransactionService transactionService)
        {
            _IDashboardService = dashboardService;
            _ITransactionService = transactionService;
        }
        [HttpGet("GetStatisticDashboardData")]
        public IActionResult GetStatisticDashboardData(int parentId)
        {
            var result = _IDashboardService.GetStatisticDashboardData(parentId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetTransactionData")]
        public IActionResult GetTransactionData(int parentId)
        {
            var result = _ITransactionService.GetTransactionData(parentId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
