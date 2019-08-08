using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractApp.Models.People;
using ContractApp.Services.Consultants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContractApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsulentsController : ControllerBase
    {
        private readonly IConsultantsService consulentsService;

        public ConsulentsController(IConsultantsService consulentsService)
        {
            this.consulentsService = consulentsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var consultants = this.consulentsService.GetAllConsultants();
            return Ok(consultants);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var consultants = this.consulentsService.GetConsultantById(id);
            if (consultants == null)
            {
                return NotFound();
            }
            else return Ok(consultants);
        }

        [HttpPost]
        public IActionResult Post(Consultant consultant)
        {
            var NewConsultant = this.consulentsService.AddConsultant(consultant);
            return CreatedAtAction("get", NewConsultant);
        }

         [HttpDelete]
        public IActionResult Delete(Consultant consultant)
        {
            this.consulentsService.DeleteConsultant(consultant)
            return NoContent();

        }
    }
}