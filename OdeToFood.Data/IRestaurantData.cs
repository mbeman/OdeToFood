using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Matt's Pizza", Location = "Missouri", Cuisine = CuisineType.Italian },
                new Restaurant{Id = 2, Name = "Matt's Burritos", Location = "Missouri", Cuisine = CuisineType.Mexican },
                new Restaurant{Id = 3, Name = "Matt's Curry Palace", Location = "Missouri", Cuisine = CuisineType.Indian }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from Restaurant r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
