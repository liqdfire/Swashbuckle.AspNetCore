﻿using System;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Basic.Swagger
{
    public class ExamplesSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            var type = context.SystemType;
            schema.Example = null;//TOFIX GetExampleOrNullFor(context.SystemType);
        }

        private object GetExampleOrNullFor(Type systemType)
        {
            switch (systemType.Name)
            {
                case "Product":
                    return new
                    {
                        Id = "123",
                        Description = "foobar"
                    };
                default:
                    return null;
            }
        }
    }
}
