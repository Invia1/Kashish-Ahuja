using System;
using inter.Service;
using inter.Interface;
using inter.Model;

namespace inter.UI
{
    public class main
    {

        public  static void Main()
        {
            employee obj = new employee();
            Interface1 obj1 = new service();

            obj1.setDetails();
             employee temp = obj1.getDetails();
            Console.WriteLine("Employee Id : " + temp.EmpId + "Employee Name : "+temp.Name);
        }
    }
}
