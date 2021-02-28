using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VenderConvention.ApplicationServices;
using VenderConvention.DTOs;
using VenderConvention.Inferastructurs;
using VenderConvention.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace VenderConvention.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _service;

        public VendorController(IVendorService service)
        {
            _service = service;

        }

        [HttpGet]
        public async Task<IActionResult> getallById(int id)
        {

            return Ok(await _service.GetAllById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(InsertVendorDTO dTO)
        {
            var result=(await _service.Insert(dTO));
            return Created(nameof(getallById), result);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, UpdateDTO dTO)
        {
            return Ok(await _service.Update(dTO, id));

        }

        [HttpDelete]
        public async Task<IActionResult>  Delete(int id)
        {
            return Ok(await _service.Delete(id));
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdatePatch(JsonPatchDocument<UpdatePatchDTO> state,[FromRoute] int id)
        {
           
            return Ok(await _service.UpdatePatch(state, id));
           
        }
       
    }

}

