using System;
using AutoMapper;
using DemoPrnSlot5.Models;
using DemoPrnSlot5.Models.Dtos;

namespace DemoPrnSlot5;

public class MapperConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mapperConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<CreateUserRequest, User>().ReverseMap();
            config.CreateMap<UpdateUserRequest, User>().ReverseMap();
            config.CreateMap<GetUserResponse, User>().ReverseMap();
        });
        return mapperConfig;
    }
}
