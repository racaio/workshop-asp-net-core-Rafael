using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RafaelAppication3.Models
{
    public class RafaelAppication3Context : DbContext
    {
        public RafaelAppication3Context (DbContextOptions<RafaelAppication3Context> options)
            : base(options)
        {
        }

        public DbSet<RafaelAppication3.Models.Department> Department { get; set; }
    }
}
