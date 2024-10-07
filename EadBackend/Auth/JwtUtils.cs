/*******************************************************************************
 * File: JwtUtils.cs
 * Author: KT Navodya (IT21057106)
 * Date: 2024-10-07
 * Description: This file contains the IJwtUtils interface and its implementation,
 *              which provide JWT (JSON Web Token) generation and validation
 *              functionality for the EAD Backend application.
 ******************************************************************************/

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using EadBackend.Models;

namespace EadBackend.Auth
{
    /// <summary>
    /// Interface for JWT utility operations
    /// </summary>
    public interface IJwtUtils
    {
        /// <summary>
        /// Generates a JWT token for a given user
        /// </summary>
        /// <param name="user">The user for whom to generate the token</param>
        /// <returns>A JWT token string</returns>
        string GenerateToken(User user);

        /// <summary>
        /// Validates a JWT token and returns the user ID if valid
        /// </summary>
        /// <param name="token">The JWT token to validate</param>
        /// <returns>The user ID if the token is valid, otherwise null</returns>
        string? ValidateToken(string token);
    }

    /// <summary>
    /// Implementation of IJwtUtils interface
    /// </summary>
    public class JwtUtils : IJwtUtils
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Constructor for JwtUtils
        /// </summary>
        /// <param name="configuration">The application configuration</param>
        public JwtUtils(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Generates a JWT token for a given user
        /// </summary>
        /// <param name="user">The user for whom to generate the token</param>
        /// <returns>A JWT token string</returns>
        public string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddMinutes(double.Parse("60")),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = "EadProject",
                Audience = "EadProjectUsers"
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        /// <summary>
        /// Validates a JWT token and returns the user ID if valid
        /// </summary>
        /// <param name="token">The JWT token to validate</param>
        /// <returns>The user ID if the token is valid, otherwise null</returns>
        public string? ValidateToken(string token)
        {
            if (token == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890");
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = "EadProject",
                    ValidAudience = "EadProjectUsers",
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = jwtToken.Claims.First(x => x.Type == ClaimTypes.Name).Value;

                return userId;
            }
            catch
            {
                return null;
            }
        }
    }
}