using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Models.BaseModels;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories;
public class UserRepository : IUserRepository {
    private readonly IMapper mapper;
    private readonly SigmaDbContext context;

    public UserRepository(IMapper mapper, SigmaDbContext context) {
        this.mapper = mapper;
        this.context = context;
    }
    public async Task<bool> Create(User user) {
        if (context.Users.Any(u => u.Email == user.Email)) {
            return false;
        }
        var userEntity = mapper.Map<UserEntity>(user);
        userEntity.Roles = context.Roles.Where(r => user.Roles.Contains(r.Name)).ToList();
        context.Users.Add(userEntity);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(int id) {
        var user = await context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null) {
            return false;
        }
        context.Users.Remove(user);
        await context.SaveChangesAsync();
        return true;

    }

    public async Task<User> GetUserByEmail(string email) {
        var userEntity = await context.Users
            .Include(u => u.Roles)
            .FirstOrDefaultAsync(u => u.Email == email);
        var user = mapper.Map<User>(userEntity);
        return user;
    }

    public async Task<User> GetUserById(int id) {
        var userEntity = await context.Users
            .Include(u => u.Roles)
            .FirstOrDefaultAsync(u => u.Id == id);
        var user = mapper.Map<User>(userEntity);
        return user;
    }

    public async Task<List<User>> GetUsers() {
        var userEntities = await context.Users
            .Include(u => u.Roles)
            .ToListAsync();
        var users = mapper.Map<List<User>>(userEntities);
        return users;

    }

    public async Task<bool> Update(User user) {
        var userEntity = await context.Users
            .Include(u=>u.Roles)
            .FirstOrDefaultAsync(u => u.Id == user.Id);
        
        if (userEntity == null) 
            return false;
        
        userEntity.Name = user.Name ?? userEntity.Name;
        userEntity.Email = user.Email ?? userEntity.Email;
        userEntity.PasswordHash = user.PasswordHash ?? userEntity.PasswordHash;
        
        if (user.Roles != null && user.Roles.Length != 0)
            userEntity.Roles = context.Roles.Where(r=>user.Roles.Contains(r.Name)).ToList();
        await context.SaveChangesAsync();
        return true;
    }
}
