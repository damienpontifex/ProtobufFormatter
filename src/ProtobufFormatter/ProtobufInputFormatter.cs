﻿using Microsoft.AspNet.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using ProtoBuf.Meta;
using System;
using System.Threading.Tasks;

namespace ProtobufFormatter
{
    public class ProtobufInputFormatter : InputFormatter
    {
        private static Lazy<RuntimeTypeModel> model = new Lazy<RuntimeTypeModel>(CreateTypeModel);

        public static RuntimeTypeModel Model => model.Value;

        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            var type = context.ModelType;
            var request = context.HttpContext.Request;
            MediaTypeHeaderValue requestContentType = null;
            MediaTypeHeaderValue.TryParse(request.ContentType, out requestContentType);

            object result = Model.Deserialize(context.HttpContext.Request.Body, null, type);
            return InputFormatterResult.SuccessAsync(result);
        }

        public override bool CanRead(InputFormatterContext context) => true;

        private static RuntimeTypeModel CreateTypeModel()
        {
            var typeModel = TypeModel.Create();
            typeModel.UseImplicitZeroDefaults = false;
            return typeModel;
        }
    }
}
