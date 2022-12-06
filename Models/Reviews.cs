namespace RestaurantASP.Models
{
    public class Review
    {
        public int ReviewID {get; set;}

        public double Price {get; set;}

        public bool Tossed {get; set;}

        public double Rating {get; set;}

        public int RestaurantID {get; set;}
        public Restaurant Restaurant {get; set;} = null!;

    }
    
}

