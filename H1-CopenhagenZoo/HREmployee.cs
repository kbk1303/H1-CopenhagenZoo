using Copenhagen.Zoo.Employees.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen.Zoo.Employees.HR
{
    internal class HREmployee
    {
        private static List<ZooWorker>? workers;


        internal static void AddEmployee(int id, string name)
        {
            workers ??= new List<ZooWorker>();
            workers.Add(new ZooWorker(id, name));
        }

        internal static List<ZooWorker>? GetEmployees()
        {
            return workers ?? null;
        }

        internal static ZooWorker? GetEmployee(int id)
        {
            if(workers != null)
            {
                return workers[id];
            }
            return null;
        }
    }
}
