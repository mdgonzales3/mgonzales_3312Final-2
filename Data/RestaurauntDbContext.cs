using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantASP.Models;

    public class RestaurauntDbContext : DbContext
    {
        public RestaurauntDbContext (DbContextOptions<RestaurauntDbContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantASP.Models.Restaurant> Restaurant { get; set; } = default!;
    }
