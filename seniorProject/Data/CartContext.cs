using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeniorProject.Models;

namespace Carts.Data
{
    public class CartContext : DbContext
    {
        public CartContext (DbContextOptions<CartContext> options)
            : base(options)
        {
        }

        public DbSet<SeniorProject.Models.Cart> Cart { get; set; } = default!;
    }
}
