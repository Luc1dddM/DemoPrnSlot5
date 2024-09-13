using System;
using DemoPrnSlot5.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoPrnSlot5.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>(entity =>
          {
              entity.HasData(
                  new User { UserId = 1, UserName = "SonLam", JoinedDate = DateTime.Now },
                  new User { UserId = 2, UserName = "VuThai", JoinedDate = DateTime.Now }
              );
          });

        base.OnModelCreating(modelBuilder);
    }

}
