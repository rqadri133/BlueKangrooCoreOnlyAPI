﻿using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using BlueKangrooCoreOnlyAPI.Repository;

namespace BlueKangrooCoreOnlyAPI.AuthenticationHandlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {

        private readonly IBlueKangrooRepository _repository;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock ,
            IBlueKangrooRepository repository
            )
            : base(options, logger, encoder, clock)
        {
            _repository = repository;


           }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            string _token = string.Empty;

            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["blueAuthorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                var username = credentials[0];
                var password = credentials[1];
                _token = await _repository.LoginUser(new Models.AppUser() { AppUserName = username, AppUserPwd = password });
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (_token == null)


                return AuthenticateResult.Fail("Invalid Username or Password");

            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, _token),
                new Claim(ClaimTypes.Name, _token),
            };
            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
