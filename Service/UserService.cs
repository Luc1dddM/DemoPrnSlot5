using System;
using AutoMapper;
using DemoPrnSlot5.Data;
using DemoPrnSlot5.Models;
using DemoPrnSlot5.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DemoPrnSlot5.Service;

public class UserService : IUserService
{
    private readonly ApplicationDbContext _context;
    private IMapper _mapper;


    public UserService(ApplicationDbContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }
    public async Task<GetUserResponse> CreateUser(CreateUserRequest request)
    {
        User user = _mapper.Map<User>(request);
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetUserResponse>(user);
    }

    public async Task<bool> DeleteUser(int id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
        if (user == null)
        {
            return false;
        }
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<GetUserResponse> GetUserById(int id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
        return _mapper.Map<GetUserResponse>(user);

    }

    public async Task<List<GetUserResponse>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();
        return _mapper.Map<List<GetUserResponse>>(users);
    }

    public async Task<GetUserResponse> UpdateUser(int id, UpdateUserRequest request)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
        if (user == null)
        {
            return null;
        }
        _mapper.Map(request, user);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetUserResponse>(user);
    }

}
