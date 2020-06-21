using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW11.Application;
using CW11.Application.Model;
using CW11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CW11.Controllers
{
    [ApiController]
    [Route("api/doctor")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(DoctorModel model)
        {
            var dto = new DoctorDto()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var result = await _doctorService.AddAsync(dto);

            return CreatedAtAction(nameof(GetAsync), result, null);
        }
        
        [HttpGet("{id}")]
        public async ValueTask<ActionResult<Doctor>> GetAsync(int doctorId)
        {
            return await _doctorService.GetAsync(doctorId);
        }
        
        [HttpPut("{id}")]
        public async ValueTask<IActionResult> ModifyAsync(int doctorId, DoctorModel model)
        {
            var dto = new DoctorDto()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var result = await _doctorService.ModifyAsync(doctorId, dto);
            if (result is false)
                return NotFound();
            
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async ValueTask<IActionResult> DeleteAsync(int doctorId)
        {
            var result = await _doctorService.DeleteAsync(doctorId);
            if (result is false)
                return NotFound();
            
            return NoContent();
        }
    }
}