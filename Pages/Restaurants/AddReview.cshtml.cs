using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantASP.Models;

namespace mgonzales_3312Final_2_1.Pages;

public class AddReviewModel : PageModel
{
    private readonly ILogger<AddReviewModel> _logger;

     private readonly RestaurantASP.Models.RestaurantDbContext _context;

    [BindProperty]
     public Review Review {get; set;} = default!;
     public SelectList RestaurantDropDown {get; set;} = default!;

    public AddReviewModel(RestaurantASP.Models.RestaurantDbContext context,ILogger<AddReviewModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        RestaurantDropDown = new SelectList(_context.Restaurants.ToList(),"RestaurantID","RestaurantName");
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reviews.Add(Review);
            _context.SaveChanges();

            return RedirectToPage("./Index");


    }
}
