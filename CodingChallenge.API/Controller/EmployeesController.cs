using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingChallenge.Domain;
using CodingChallenge.Domain.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private IRepository<Employee> _employeeRepository;
        public EmployeesController(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult GetAll( int skip = 0, int count = 100)
        {
            var product = _employeeRepository.GetAll(skip, count);
            return Ok(product);
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var product = _employeeRepository.GetById(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee newEmployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            this._employeeRepository.Insert(newEmployee);
            return CreatedAtAction("get", new { id = newEmployee.Id }, newEmployee);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var entity = this._employeeRepository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            employee.Id = id;
            this._employeeRepository.Update(employee);
            return Ok(employee);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this._employeeRepository.Delete(id);
            return Ok();
        }
    }
}
