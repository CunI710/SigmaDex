using Application.Authorization;
using BLL.Options;
using Core.Enums.OptionEnums;
using DataAccess.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace SigmaDex.Extentions
{
    public static class ApiExtentions
    {
        public static void AddApiAuthentication(this IServiceCollection services, JwtOptions jwtOptions)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options => {
                    options.TokenValidationParameters = new() {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecretKey))
                    };
                });
            services.AddAuthorization(o => {
                foreach (Permission p in Enum.GetValues(typeof(Permission))) {
                    o.AddPolicy(p.ToString(), builder => builder.Requirements
                    .Add(new PermissionRequirement(
                        [p]
                        )
                    ));
                }
            });
        }
    }
}
