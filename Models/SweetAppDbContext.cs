using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MAADISWEETS.Models
{
    public class SweetAppDbContext : DbContext
    {
        public SweetAppDbContext (DbContextOptions<SweetAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sweets> Sweets { get; set; }
    }
}