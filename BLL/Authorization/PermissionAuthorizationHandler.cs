using Core.Abstractions.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Authorization
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly IServiceScopeFactory serviceScopeFactory;

        public PermissionAuthorizationHandler(IServiceScopeFactory serviceScopeFactory)
        {
            this.serviceScopeFactory = serviceScopeFactory;
        }
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            var userId = context.User.Claims
                .FirstOrDefault(c => c.Type == "userId");

            if (userId is null || !int.TryParse(userId.Value, out var id)) {
                return;
            }

            using var scope = serviceScopeFactory.CreateScope();

            var permissionService = scope.ServiceProvider.GetRequiredService<IPermissionService>();

            var permission = await permissionService.GetPermissionsAsync(id);

            if (permission.Intersect(requirement.Permissions).Any()) {
                context.Succeed(requirement);
            }
        }
    }
}
