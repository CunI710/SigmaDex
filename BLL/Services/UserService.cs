using Application.Helpers;
using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Core.Models.BaseModels;
using Core.Models.Query.Requests.User;
using Core.Models.Query.Responses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class UserService : IUserService {
        private readonly IUserRepository repos;
        private readonly IMapper mapper;

        public UserService(IUserRepository repos, IMapper mapper) {
            this.repos = repos;
            this.mapper = mapper;
        }

        public async Task<(bool, string)> CreateUser(UserCreateRequest request) {
            var user = mapper.Map<User>(request);
            user.PasswordHash = HashHelper.Generate(request.Password);
            var success = await repos.Create(user);
            return (success, "Не удалось создать пользователя");
        }

        public async Task<(bool, string)> DeleteUser(int id) {
            var success = await repos.Delete(id);
            return (success, "Не удалось создать пользователя");
        }

        public async Task<(UserResponse, string)> GetUserById(int id) {
            var user = await repos.GetUserById(id);
            var response = mapper.Map<UserResponse>(user);
            return (response, "Нет такого пользователя");
        }

        public async Task<(List<UserResponse>, string)> GetUsers() {
            var users = await repos.GetUsers();
            var response = mapper.Map<List<UserResponse>>(users);
            return (response, "Нет пользователей");
        }

        public async Task<(bool, string)> UpdatePassword(UserUpdatePasswordRequest request) {
            var user = await repos.GetUserByEmail(request.Email);
            var success = false;
            if (HashHelper.Check(request.Password, user.PasswordHash)) {
                user.PasswordHash = HashHelper.Generate(request.NewPassword);
                success = await repos.Update(user);
            }
            return (success, "Введены некорректные данные");
        }

        public async Task<(bool, string)> UpdateUser(UserUpdateRequest request) {

            var user = mapper.Map<User>(request);
            if(request.Password != null) 
                user.PasswordHash = HashHelper.Generate(request.Password);
            bool success = await repos.Update(user);
            return (success, "Введены некорректные данные");
        }
    }
}
