using Microsoft.EntityFrameworkCore;
using Roganiser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rorganiser.Data
{
    public  class RogDbContext : DbContext
    {
        public DbSet<TaskList> TaskList { get; set; }
        public DbSet<RogTask> Task { get; set; }
        public RogDbContext() 
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=rog.db");            
        }        
    }
}
