using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcceptOrders.Models;

namespace AccOrd.Data
{
    public class AccOrdContext : DbContext
    {
        public AccOrdContext (DbContextOptions<AccOrdContext> options)
            : base(options)
        {
        }

        public DbSet<AcceptOrders.Models.Orders> Orders { get; set; } = default!;
    }
}
