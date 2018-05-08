﻿using System;
using Microsoft.OpenApi.Models;

namespace Swashbuckle.AspNetCore.Swagger
{
    public interface ISwaggerProvider
    {
        OpenApiDocument GetSwagger(
            string documentName,
            string host = null,
            string basePath = null,
            string[] schemes = null);
    }

    public class UnknownSwaggerDocument : Exception
    {
        public UnknownSwaggerDocument(string documentName)
            : base(string.Format("Unknown Swagger document - {0}", documentName))
        {}
    }
}