using System;
using System.ComponentModel.DataAnnotations;

namespace DemoPrnSlot5.Models.Dtos;

public class CreateUserRequest
{
    [Required(ErrorMessage = "Name of user is required")]
    public string UserName { get; set; }
    public DateTime JoinedDate { get; set; }
}
