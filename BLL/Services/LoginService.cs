﻿using Application.Helpers;
using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Core.Models.BaseModels;
using Core.Models.Query.Requests.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class LoginService : ILoginService {
        private readonly IUserRepository repos;
        private readonly IMapper mapper;

        public LoginService(IUserRepository repos, IMapper mapper) {
            this.repos = repos;
            this.mapper = mapper;
        }
        public async Task<(bool, string)> Login(UserLoginRequest request) {

            var user = await repos.GetUserByEmail(request.Email);
            if (user == null)
                return (false, "Пользователя с таким email не существует");
            if (HashHelper.Check(request.Password, user.PasswordHash)){
                return (true, null!);
            }
            return (false, "Пароль не совпадает");
        }

        public async Task<(bool, string)> Register(UserRegisterRequest request) {
            var user = mapper.Map<User>(request);
            user.PasswordHash = HashHelper.Generate(request.Password);
            user.Roles = ["User"];
            var success = await repos.Create(user);
            return (success, "Не удалось создать пользователя");
        }
    }
}
