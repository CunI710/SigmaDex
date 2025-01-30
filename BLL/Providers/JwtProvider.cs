using Application.Authorization;
using BLL.Options;
using Core.Models.BaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Providers;
public class JwtProvider(IOptions<JwtOptions> jwtOptionsCase)
{
    private readonly JwtOptions jwtOptions = jwtOptionsCase.Value; 
    
    public string GenerateToken(User user)
    {
        Claim[] claims = [new("userId", user.Id.ToString())];

        var singingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecretKey)),
            SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            claims: claims,
            signingCredentials: singingCredentials,
            expires: DateTime.UtcNow.AddHours(jwtOptions.ExpiresHours));
        string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
        return tokenValue;


    }

}
