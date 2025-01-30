using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Core.Enums.OptionEnums;

namespace Application.Services;
    

public class PermissionService : IPermissionService
{
    private readonly IUserRepository repos;

    public PermissionService(IUserRepository userRepos)
    {
        this.repos = userRepos;
    }
    public Task<HashSet<Permission>> GetPermissionsAsync(int id)
    {
        return repos.GetUserPermissions(id);
    }
}
