using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaiwaySysterm.Models;
namespace RaiwaySysterm.Models
{
    public class RaiwayContext : DbContext
    {

        public RaiwayContext(DbContextOptions options) : base(options) { }
        public DbSet<UserDetail> UserDetail { get; set; }
        public DbSet<RegisterDetail> RegisterDetail { get; set; }
    }
}
