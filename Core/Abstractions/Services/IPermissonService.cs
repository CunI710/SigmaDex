using Core.Enums.OptionEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstractions.Services
{
    public interface IPermissionService
    {
        Task<HashSet<Permission>> GetPermissionsAsync(int id);
    }
}
