using Microsoft.AspNet.Mvc;
using ProtobufFormatter.WebApi.Test.Models;

namespace ProtobufFormatter.WebApi.Test.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController
    {
        [HttpGet("{id}")]
        public ProtobufModelDto Get(int id)
        {
            return new ProtobufModelDto
            {
                Id = 1,
                Name = "HelloWorld",
                StringValue = "My first MVC 6 Protobuf service"
            };
        }

        [HttpPost]
        [Route("")]
        public void Post([FromBody]ProtobufModelDto value)
        {
            // Yes the value can be sent as a protobuf item.
            var myValue = value;
        }
    }
}
