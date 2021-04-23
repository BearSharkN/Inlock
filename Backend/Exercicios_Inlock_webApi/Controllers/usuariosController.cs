using Exercicios_Inlock_webApi.Domains;
using Exercicios_Inlock_webApi.Interfaces;
using Exercicios_Inlock_webApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Exercicios_Inlock_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public usuariosController()
        {
            _usuarioRepository = new usuarioRepository();
        }

        /// <summary>
        /// Realiza o login
        /// </summary>
        /// <param name="user">é usado para chamar as propriedades da requisição</param>
        /// <returns>Retorna um token caso usuario exista</returns>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Logiin(usuarioDomain user)
        {
            usuarioDomain UsuarioLogado = _usuarioRepository.Login(user.email, user.senha);

            if (UsuarioLogado == null)
            {
                return NotFound("E-mail ou senha inválida");
            }

            var Definitionclaims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, UsuarioLogado.email),
                new Claim(JwtRegisteredClaimNames.Jti, UsuarioLogado.idUsuario.ToString()),
                new Claim(ClaimTypes.Role, UsuarioLogado.idTipoUsuario.ToString())
           };

            var chaveSeguranca = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Chave-Seguranca-Api-autenticacao"));

            var credenciais = new SigningCredentials(chaveSeguranca, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer:"Inlock.webApi",
                audience: "Inlock.webApi",
                claims : Definitionclaims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credenciais


            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
    }
}
