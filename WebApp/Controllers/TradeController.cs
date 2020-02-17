using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TradeController : ControllerBase
    {
        private readonly ITradeManager _tradeManager;

        public TradeController(ITradeManager tradeManager)
        {
            _tradeManager = tradeManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _tradeManager.GetAllTradesWithLevelsAsync();
            return Ok(data);
        }
    }
}