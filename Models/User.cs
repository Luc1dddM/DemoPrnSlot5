using System;
using System.ComponentModel.DataAnnotations;

namespace DemoPrnSlot5.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    public string UserName { get; set; }
    public DateTime JoinedDate { get; set; }
    public virtual IEnumerable<Order> Orders { get; set; }
}
