using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeniorProject.Models;

namespace Reviews.Data
{
    public class ReviewContext : DbContext
    {
        public ReviewContext (DbContextOptions<ReviewContext> options)
            : base(options)
        {
        }

        public DbSet<SeniorProject.Models.Review> Review { get; set; } = default!;
    }
}
