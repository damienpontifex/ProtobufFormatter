using Microsoft.AspNetCore.Mvc;
using ProtobufFormatter.WebApi.Test.Models;

namespace ProtobufFormatter.WebApi.Test.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var model = new ProtobufModelDto
            {
                Id = 1,
                Name = "HelloWorld",
                StringValue = "My first MVC 6 Protobuf service"
            };
            
            return new OkObjectResult(model);
        }

        [HttpPost]
        [Route("")]
        public void Post([FromBody] ProtobufModelDto value)
        {
            // Yes the value can be sent as a protobuf item.
            var myValue = value;
        }
    }
}
