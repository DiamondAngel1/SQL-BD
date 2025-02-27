using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.SimpleSQL.Data.Entitis;
using Microsoft.EntityFrameworkCore;

namespace _2.SimpleSQL.Data
{
    public class Context : DbContext{
        public DbSet<UserEntity> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Cool.bomb");
        }
    }
}
