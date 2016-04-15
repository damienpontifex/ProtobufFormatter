using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using Microsoft.Net.Http.Headers;

namespace ProtobufFormatter
{
    public class MvcProtobufMvcOptionsSetup : ConfigureOptions<MvcOptions>
    {
        public MvcProtobufMvcOptionsSetup()
            : base((options) => ConfigureMvc(options))
        {
        }

        public static void ConfigureMvc(MvcOptions options)
        {
            options.OutputFormatters.Add(new ProtobufOutputFormatter());
            options.InputFormatters.Add(new ProtobufInputFormatter());

            options.FormatterMappings.SetMediaTypeMappingForFormat("protobuf", MediaTypeHeaderValue.Parse("application/x-protobuf"));
        }
    }
}
