using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebApplicationDevelopingSam.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController: Controller
    {
        
        //GET: api/<controller>
        [HttpGet]
        [Produces("application/json")]//The verb Get() will now onl work with json from server
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        

        //GET: api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, string query)
        {
            return Ok(new Value {Id = id, Text = "value" + id});
        }

        //POST: api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] Value value)
        {
            if(!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }

            return CreatedAtAction("Get", new { id = value.Id }, value);

        }

        //PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        //DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] string value)
        {

        }
    }

    public class Value
    {
        public int Id { get; set; }

        [MinLength(3)]
        public string Text { get; set; }
    }
}