using System;
using FosterCareAPI2.Core.Models;
using FosterCareAPI2.Core.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FosterCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;

        public ChildController(IChildService _childService)
        {
            _childService = ChildService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var childModels = _childService
                    .GetAll()
                    .ToApiModels();

                return Ok(childModels);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetChild", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var child = _childService.Get(id);
                var childModels = child.ToApiModel();
                return Ok(childModels);
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("GetChild", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] ChildModel newchild)
        {
            try
            {
                _childService.Add(newchild.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddChild", ex.Message);
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Get", new { Id = newChild.Id }, newchild);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Child child)
        {
            try
            {
                var child = _childService.Update(updatedChild.ToDomainModel());
                if (child == null) return NotFound();
                return Ok(_childService.Update(child).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("UpdateChild", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var children = _childService.Get(id);
            if (children == null) return NotFound();
            _childService.Remove(child);
            return NoContent();
        }
    }
}