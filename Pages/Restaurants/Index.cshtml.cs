using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantASP.Models;

namespace mgonzales_3312Final_2_1.Pages.Restaurants
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantASP.Models.RestaurantDbContext _context;

        public IndexModel(RestaurantASP.Models.RestaurantDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1; //Current page number

        public int PageSize {get; set;} = 10; //Display 10 records at a time

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty; //Sorting variable

        [BindProperty(SupportsGet = true)]
        public string? SearchString {get; set;}

        

        public async Task OnGetAsync()
        {
            var restaurants = from r in _context.Restaurants
                                select r;
            if (!string.IsNullOrEmpty(SearchString))
            {
                restaurants = restaurants.Where(r => r.RestaurantName.Contains(SearchString));
            }

            Restaurant = await restaurants.ToListAsync();


            var query = _context.Restaurants.Select(r => r); //query for sorting ascending and descending

            

                switch (CurrentSort)
                {
                    case "name_asc":
                        query = query.OrderBy(r => r.RestaurantName);
                        break;
                    case "name_desc":
                        query = query.OrderByDescending(r => r.RestaurantName);
                        break;    
                }


            if (_context.Restaurants != null)
            {
                Restaurant = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync(); //Paging
            }
        }
    }
}
