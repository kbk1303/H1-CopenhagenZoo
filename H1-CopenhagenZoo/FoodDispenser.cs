using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen.Zoo.Foods.FoodDispensers
{
    internal sealed class FoodDispenser
    {
        private static FoodDispenser? instance = null;
        private readonly List<Food> foods = new();
        
        private FoodDispenser() { }

        internal static FoodDispenser Instance
        {
            get { return instance ??= new FoodDispenser(); }

        }
        internal void AddFood(Food food)
        {
            foods.Add(food);
        }

        internal Food? ReleaseNextFood()
        {
            if(foods.Count == 0 || foods == null)
            {
                return null;
            }
            Food retv = foods[0];
            foods.RemoveAt(0);
            return retv;
        }
    }
}
