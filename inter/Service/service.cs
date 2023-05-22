using inter.Interface;
using inter.Model;
using System;


namespace inter.Service
{
    public class service : Interface1
    {
        employee emp1 = new employee();

        public void setDetails()
        {
            Console.WriteLine("Enter Employee Id : ");
            emp1.EmpId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            emp1.Name = Console.ReadLine();
        }
       
        public employee getDetails()
        {
            return emp1;
        }

    }
}
