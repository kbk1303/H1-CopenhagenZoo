using Copenhagen.Zoo.Employees.HR;
using Copenhagen.Zoo.Employees.Production;
using Copenhagen.Zoo.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_CopenhagenZoo
{
    internal class CopenhagenZoo
    {
        public CopenhagenZoo()
        {
            HREmployee.AddEmployee(0, "Anderson1");
            if(HREmployee.GetEmployees() != null)
            {
                ZooWorker? worker = HREmployee.GetEmployee(0);
                if(worker != null)
                {
                    try
                    {
                        worker.FeedNextAnimal();
                    }
                    catch(ArgumentNullException ex)
                    {
                        Console.WriteLine(ex.Message);
                        worker.AddFoodToDispenser(new Food("Grass"));
                    }
                    

                }
            }
        }
        

    }
}
