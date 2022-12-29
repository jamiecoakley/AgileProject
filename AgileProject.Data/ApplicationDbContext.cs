using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgileProject.Data.Entities;

namespace AgileProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<GameEntity> Games { get; set; }

        public DbSet<GameSystemEntity> GameSystems { get; set; }
    }
}