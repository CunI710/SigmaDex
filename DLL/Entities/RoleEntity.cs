using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities;
public class RoleEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<UserEntity> Users { get; set; } = [];
    public List<PermissionEntity> Permissions { get; set; } = [];
}

