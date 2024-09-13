using System;
using System.ComponentModel.DataAnnotations;

namespace DemoPrnSlot5.Models.Dtos;

public class UpdateUserRequest
{
    [Required(ErrorMessage = "Name of user is required")]
    public string UserName { get; set; }
}
