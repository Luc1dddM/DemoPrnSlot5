using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoPrnSlot5.Models;

public class Order
{
    [Key]
    public int OrderId { get; set; }
    public DateTime CreatedDate { get; set; }
    public double Total { get; set; }
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User UserNavigation { get; set; }
}
