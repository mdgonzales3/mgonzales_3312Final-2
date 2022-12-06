using Microsoft.EntityFrameworkCore;
namespace RestaurantASP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RestaurantDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<RestaurantDbContext>>()))
            {
                // Look for any proffesors.
                if (context.Restaurants.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Restaurants.AddRange(
                    new Restaurant
                    {
                        RestaurantName = "Beef O Brady's",
                        Location = "Lubbock",
                        Price = 12.50,
                        Tossed = true,
                        Rating = 5.5,
                    },
                   new Restaurant
                    {
                        RestaurantName = "50th Street Caboose",
                        Location = "Lubbock",
                        Price = 11.99,
                        Tossed = true,
                        Rating = 3.5,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Keith's Wings",
                        Location = "Lubbock", 
                        Price = 13.99,
                        Tossed = true,
                        Rating = 4.3,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Wing King",
                        Location = "Brownfield",
                        Price = 12.99,
                        Tossed = true,
                        Rating = 8.9,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Brooklyn Pizzeria",
                        Location = "Lubbock",
                        Price = 13.99,
                        Tossed = true,
                        Rating = 6.5,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Papa V Pizza",
                        Location = "Lubbock",
                        Price = 11.99,
                        Tossed = false,
                        Rating = 3.3,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Drylands",
                        Location = "Hobbs",
                        Price = 12.99,
                        Tossed = false,
                        Rating = 2.1,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Silver Bullet Saloon",
                        Location = "Lubbock",
                        Price = 12.99,
                        Tossed = true,
                        Rating = 6.5,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Pepe's Pizza and Ice Cream",
                        Location = "Lubbock",
                        Price = 12.99,
                        Tossed = false,
                        Rating = 4.3,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Lubbock Breakfast House",
                        Location = "Lubbock",
                        Price = 9.99,
                        Tossed = true,
                        Rating = 5.7,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Teddy Jacks",
                        Location = "Lubbock",
                        Price = 13.99,
                        Tossed = true,
                        Rating = 3.2,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Urban Bricks",
                        Location = "Lubbock",
                        Price = 11.99,
                        Tossed = false,
                        Rating = 1.5,
                    },
                    new Restaurant
                    {
                        RestaurantName = "The Spoon",
                        Location = "Lubbock",
                        Price = 11.99,
                        Tossed = true,
                        Rating = 4.5,
                    },
                    new Restaurant
                    {
                        RestaurantName = "King Louie's",
                        Location = "Lubbock",
                        Price = 12.99,
                        Tossed = true,
                        Rating = 6.9,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Shotzy's",
                        Location = "Lubbock",
                        Price = 10.99,
                        Tossed = true,
                        Rating = 5.3,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Buffalo Bros",
                        Location = "Fort Worth",
                        Price = 16.99,
                        Tossed = true,
                        Rating = 3.2,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Kelly's Craft Tavern",
                        Location = "Allen",
                        Price = 12.99,
                        Tossed = true,
                        Rating = 8.1,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Wingstop",
                        Location = "Lubbock",
                        Price = 14.99,
                        Tossed = true,
                        Rating = 6.2,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Longhorn Steakhouse",
                        Location = "Lubbock",
                        Price = 12.99,
                        Tossed = false,
                        Rating = 7.1,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Wayne's Wings",
                        Location = "San Antonio",
                        Price = 9.99,
                        Tossed = true,
                        Rating = 6.2,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Track One",
                        Location = "El Paso",
                        Price = 7.99,
                        Tossed = true,
                        Rating = 4.8,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Duff's Famous Wings",
                        Location = "Southlake",
                        Price = 15.99,
                        Tossed = true,
                        Rating = 4.5,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Mike's Chicken",
                        Location = "Dallas",
                        Price = 12.50,
                        Tossed = true,
                        Rating = 36.5,
                    },
                    new Restaurant
                    {
                        RestaurantName = "Wings 'n More",
                        Location = "College Station",
                        Price = 11.00,
                        Tossed = true,
                        Rating = 5.8,
                    },
                    new Restaurant
                    {
                        RestaurantName = "WingIT",
                        Location = "San Antonio",
                        Price = 10.99,
                        Tossed = true,
                        Rating = 4.5,
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
