using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateEmployeeManager employee1 = new CreateEmployeeManager
            {
                employeeBaseManager = new EmployeeManager()
            };

            employee1.Create();
            employee1.getInfo();

            CreateEmployeeManager engineer1 = new CreateEmployeeManager
            {
                employeeBaseManager = new EngineerManager()
            };

            engineer1.Create();
            engineer1.getInfo();

            engineer1.DoRaise();
            engineer1.DoRaise(16.2);
        }
    }

}
