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
        private readonly RestaurauntDbContext _context;

        public IndexModel(RestaurauntDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Restaurant != null)
            {
                Restaurant = await _context.Restaurant.ToListAsync();
            }
        }
    }
}
