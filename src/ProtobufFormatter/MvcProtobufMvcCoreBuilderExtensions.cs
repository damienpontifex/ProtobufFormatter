using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.OptionsModel;
using System;

namespace ProtobufFormatter
{
    public static class MvcProtobufMvcCoreBuilderExtensions
    {
        public static IMvcCoreBuilder AddProtobufFormatters(this IMvcCoreBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            AddProtobufFormatterServices(builder.Services);
            return builder;
        }

        internal static void AddProtobufFormatterServices(IServiceCollection services)
        {
            services.TryAddEnumerable(
                ServiceDescriptor.Transient<IConfigureOptions<MvcOptions>, MvcProtobufMvcOptionsSetup>());
        }
    }
}
