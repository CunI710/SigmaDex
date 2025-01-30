using Core.Enums.OptionEnums;
using Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstractions.Repositories {
    public interface IUserRepository {
        public Task<List<User>> GetUsers();
        public Task<User> GetUserById(int id);
        public Task<User> GetUserByEmail(string name);
        public Task<bool> Create(User user);
        public Task<bool> Update(User user);
        public Task<bool> Delete(int id);
        Task<HashSet<Permission>> GetUserPermissions(int id);
    }
}
