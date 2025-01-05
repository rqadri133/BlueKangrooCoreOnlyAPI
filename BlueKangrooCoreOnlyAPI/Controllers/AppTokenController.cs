using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BlueKangrooCoreOnlyAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using BlueKangrooCoreOnlyAPI.Caching;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Google.Api;
using System.IO;
using NStandard;
using IdentityModel.Client;
using System.Threading;
using Microsoft.AspNetCore.Antiforgery;


[Route("api/[controller]")]
[ApiController]
public class AppTokenController : ControllerBase 
{
    private readonly IAntiforgery _antiforgery;

    public AppTokenController(IAntiforgery antiforgery)
    {
        _antiforgery = antiforgery;
    }

    [HttpGet("get-antiforgery-token")]
    public IActionResult GetAntiforgeryToken()
    {
        var tokens = _antiforgery.GetAndStoreTokens(HttpContext);
        return Ok(new { token = tokens.RequestToken });
    }
}
