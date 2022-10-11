using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace catdog_backend_api
{
    public static class GoogleOAuthHelper
    {
        public static void AddSwaggerOAuth2Configuration(SwaggerGenOptions swaggerGenOptions)
        {
            swaggerGenOptions.AddSecurityDefinition("Bearer", GetSecurityScheme());
            swaggerGenOptions.AddSecurityRequirement(GetSecurityRequirements());
        }

        public static OpenApiSecurityRequirement GetSecurityRequirements()
        {
            return new OpenApiSecurityRequirement
            {
                {
                    GetSecurityScheme()
                    , new List<string> {"openid", "email", "profile" }
                }
            };
        }

        public static OpenApiSecurityScheme GetSecurityScheme()
        {
            return new OpenApiSecurityScheme
            {
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.OAuth2,
                Flows = new OpenApiOAuthFlows()
                {
                    Implicit = new OpenApiOAuthFlow()
                    {
                        AuthorizationUrl = new Uri("https://accounts.google.com/o/oauth2/v2/auth"),
                        Scopes = new Dictionary<string, string> { { "openid", "openid" }, { "email", "email" }, { "profile", "profile" } }
                    }
                }
                , Extensions = new Dictionary<string, IOpenApiExtension>
        {
            {"x-tokenName", new OpenApiString("id_token")}
        },
            };
        }
    }
}