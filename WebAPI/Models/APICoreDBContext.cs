using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class APICoreDBContext : DbContext
    {
        public DbSet<CUSTOMER> CUSTOMER { get; set; }

        public APICoreDBContext()
        {

        }

        public APICoreDBContext(DbContextOptions<APICoreDBContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }
    }
}
