using Microsoft.AspNetCore.Mvc;
using ProtobufFormatter.WebApi.Test.Models;

namespace ProtobufFormatter.WebApi.Test.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var model = new ProtobufModelDto
            {
                Id = id,
                Name = "HelloWorld",
                StringValue = "My first MVC Core Protobuf service"
            };
            
            return new OkObjectResult(model);
        }

        [HttpPost]
        public void Post([FromBody] ProtobufModelDto value)
        {
            // Yes the value can be sent as a protobuf item.
            var myValue = value;
        }
    }
}
