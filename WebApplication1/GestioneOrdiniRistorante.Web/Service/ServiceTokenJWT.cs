using GestioneOrdiniRistorante.Models.Models.Request;
using GestioneOrdiniRistorante.Application.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneOrdiniRistorante.Application.Service.Interface;
using GestioneOrdiniRistorante.Infrastructure.Repositories.Abstractions;

namespace GestioneOrdiniRistorante.Application.Service
{
    public class ServiceTokenJWT : ServiceTokenJWTInt
    {
        private readonly JWTAuthenticationOption jwtAuthenticationOption;
        private readonly TokenJWTRepo _tokenJWTRepository;

        public ServiceTokenJWT(IOptions<JWTAuthenticationOption> options, TokenJWTRepo tokenJWTRepository)
        {
            jwtAuthenticationOption = options.Value;
            _tokenJWTRepository = tokenJWTRepository;
        }

        public string CreaToken(CreaTokenJWTReq request)
        {
            var utente = _tokenJWTRepository.GetUtente(request.Email, request.Password);

            var chiaveDiSicurezza = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtAuthenticationOption.Key));
            var credenziali = new SigningCredentials(chiaveDiSicurezza, SecurityAlgorithms.HmacSha256);
            var securityToken = new JwtSecurityToken(jwtAuthenticationOption.Issuer
                , null
                , expires: DateTime.Now.AddMinutes(30)
                , signingCredentials: credenziali
                );

            var token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return token;

        }
    }
}
