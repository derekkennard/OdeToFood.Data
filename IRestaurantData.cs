// Created by Derek Kennard
// Solution: OdeToFood
// Project Name: OdeToFood.Data
// File Name: IRestaurantData.cs
// Created on: 05/25/2021 at 12:36 AM
// Edited on: 06/05/2021 at 2:10 PM
// Developed and Copyrighted by Derek "Doctork" Kennard

#region imports

using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

#endregion

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant
                    {Id = 1, Name = "Elizabeth's Pizza", Location = "Georgia", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Derek's Curry", Location = "Arizona", Cuisine = CuisineType.Indian},
                new Restaurant {Id = 3, Name = "Jerry's Burro's", Location = "Florida", Cuisine = CuisineType.Mexican}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                orderby r.Name
                select r;
        }
    }
}