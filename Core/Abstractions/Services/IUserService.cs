using Core.Models.Query.Requests.User;
using Core.Models.Query.Responses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstractions.Services {
    public interface IUserService {
        Task<(bool,string)> CreateUser(UserCreateRequest request);
        Task<(UserResponse,string)> GetUserById(int id);
        Task<(List<UserResponse>,string)> GetUsers();
        Task<(bool,string)> UpdateUser(UserUpdateRequest request);
        Task<(bool,string)> UpdatePassword(UserUpdatePasswordRequest request);
        Task<(bool,string)> DeleteUser(int id);
    }
}
