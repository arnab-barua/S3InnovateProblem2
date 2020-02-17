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
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageManager _languageManager;

        public LanguageController(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var languages = await _languageManager.GetAllAsync();
            return Ok(languages);
        }
    }
}