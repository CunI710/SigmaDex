using Core.Models.Query.Requests.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstractions.Services {
    public interface ILoginService {
        Task<(bool,string)> Login(UserLoginRequest request);
        Task<(bool,string)> Register(UserRegisterRequest request);
    }
}
