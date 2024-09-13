using System;
using DemoPrnSlot5.Models.Dtos;

namespace DemoPrnSlot5.Service;

public interface IUserService
{
    Task<GetUserResponse> CreateUser(CreateUserRequest request);
    Task<List<GetUserResponse>> GetUsers();
    Task<GetUserResponse> UpdateUser(int id, UpdateUserRequest request);
    Task<bool> DeleteUser(int id);
    Task<GetUserResponse> GetUserById(int id);
}
