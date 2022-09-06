using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Copenhagen.Zoo.Foods;
using Copenhagen.Zoo.Foods.FoodDispensers;

namespace Copenhagen.Zoo.Employees.Production
{
    internal class ZooWorker
    {
        private int id;
        private string name;
        private readonly FoodDispenser foodDispenser = FoodDispenser.Instance;

        public ZooWorker(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int Id { get => id; }
        public string Name { get => name; set => name = value; }

        internal Food? FeedNextAnimal()
        {
            Food? f = foodDispenser.ReleaseNextFood();
            if(f == null)
            {
                //empty food dispenser - handle?
                throw new ArgumentNullException("Food dispenser is empty!");
            }
            return f;
        }

        internal void AddFoodToDispenser(Food food)
        {
            foodDispenser.AddFood(food);
        }
    }
}
