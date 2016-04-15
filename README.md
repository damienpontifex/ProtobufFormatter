# ProtobufFormatters

ASP.NET MVC Core 1.0 Protocol Buffer formatters inspired by https://github.com/damienbod/AspNetMvc6ProtobufFormatters

## Web API Usage

Startup.cs add the protocol buffer formatters exactly like you add the built in Json Formatters.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvcCore()
        .AddProtobufFormatters();
}

public void Configure(IApplicationBuilder app)
{
    app.UseMvc();
}
```

## Sample Usage

ASP.NET Mvc Core API sample project under test/ProtobufFormatter.WebApi.Test