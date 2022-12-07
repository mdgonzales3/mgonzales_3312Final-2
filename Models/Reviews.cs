using System.ComponentModel.DataAnnotations;

namespace RestaurantASP.Models
{
    public class Review
    {
         public int ReviewID {get; set;}
         
        [Required]
        [Range(0.1, 10)]
        public double Rating {get; set;}

        public int RestaurantID {get; set;} //Foreign Key
        public Restaurant? Restaurant {get; set;} //Navigation Property

    }
    
}
