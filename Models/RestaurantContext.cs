using Microsoft.EntityFrameworkCore;
namespace RestaurantASP.Models
{
	public class RestaurantDbContext : DbContext
	{
		public RestaurantDbContext (DbContextOptions<RestaurantDbContext> options)
			: base(options)
		{
		}
		public DbSet<Restaurant> Restaurants {get; set;} = default!;
	}
}
