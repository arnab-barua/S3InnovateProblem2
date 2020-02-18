using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Repositories;
using Business.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SyllebusController : ControllerBase
    {
        private readonly ISyllebusManager _syllebusManager;

        public SyllebusController(ISyllebusManager syllebusManager)
        {
            _syllebusManager = syllebusManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _syllebusManager.GetAllSyllebusAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody]SyllebusDto syllebusDto)
        {
            var result = await _syllebusManager.CreateAsync(syllebusDto);
            return Ok(result);
        }


        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null)
                return BadRequest("No file selected");
            if (file.Length == 0)
                return BadRequest("Invalid file");
            if (file.Length > 5 * 1024 * 1024)
                return BadRequest("File size is too large. Max file size is 5 MB");


            var status = await _syllebusManager.UploadFile(file);

            
            return Ok(new { status = status });
        }
    }
}