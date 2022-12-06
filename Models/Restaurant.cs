namespace RestaurantASP.Models
{
    public class Restaurant
    {
        public int RestaurantID {get; set;}

        public string RestaurantName {get; set;} = string.Empty;

        public string Location {get; set;} = string.Empty;

        public double Price {get; set;}

        public bool Tossed {get; set;}

        public double Rating {get; set;}


        public List<Review> Reviews {get; set;} = null!;

    }
    
}

