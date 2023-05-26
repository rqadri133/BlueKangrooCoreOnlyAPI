using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Internal;
using NStandard.Evaluators;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BlueKangrooCoreOnlyAPI.AuthorizationHandlers
{
	public class AuthorizationService : IAuthorizationService
    {
        private readonly IAuthorizationHandlerContextFactory _contextFactory;
        private readonly IAuthorizationHandlerProvider _handlers;
        private readonly IAuthorizationEvaluator _evaluator;

        public AuthorizationService()
		{
		}

        public async Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user,
              object resource, IEnumerable<IAuthorizationRequirement> requirements)
        {
            // Create a tracking context from the authorization inputs.
            var authContext = _contextFactory.CreateContext(requirements, user, resource);

            // By default this returns an IEnumerable<IAuthorizationHandlers> from DI.
            var handlers = await _handlers.GetHandlersAsync(authContext);

            // Invoke all handlers.
            foreach (var handler in handlers)
            {
                await handler.HandleAsync(authContext);
            }

            // Check the context, by default success is when all requirements have been met.
            return _evaluator.Evaluate(authContext);
        }

        public Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object resource, string policyName)
        {
            throw new NotImplementedException("hey");
        }
    }
}

