using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee2 :Employee
    {
      
        public void show()
        {
            Name = Console.ReadLine();
            Id = Convert.ToInt32(Console.ReadLine());
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Employee Name:{Name},Employee Id: {Id},Employee salary:{salary}");

        }
        /*public void show1()
        {
            Name = Console.ReadLine();
            Id = Convert.ToInt32(Console.ReadLine());
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Employee Name:{Name},Employee Id: {Id},Employee salary:{salary}");
        
        }*/
    }
}
