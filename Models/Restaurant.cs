using System.ComponentModel.DataAnnotations;

namespace RestaurantASP.Models

{
    public class Restaurant
    {
        public int RestaurantID {get; set;}


        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string RestaurantName {get; set;} = string.Empty;

        [Required]
        public string Location {get; set;} = string.Empty;
        
        [Required]
        public double Price {get; set;}

        [Required]
        public bool Tossed {get; set;}
        
        [Required]
        [Range(0.1, 10)]
        public double Rating {get; set;}


        public List<Review> Reviews {get; set;} = new List<Review>(); //One to Many relationship

    }
    
}

