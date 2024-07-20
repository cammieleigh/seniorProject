using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeniorProject.Models;

namespace seniorProject.Data
{
    public class RequestContext : DbContext
    {
        public RequestContext (DbContextOptions<RequestContext> options)
            : base(options)
        {
        }

        public DbSet<SeniorProject.Models.Request> Request { get; set; } = default!;
    }
}
