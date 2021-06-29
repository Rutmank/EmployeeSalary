using EmployeeSalary;
using System;

namespace EmployeeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee janis = new Employee();

            janis.Id = 1;
            janis.FullName = "Janis Statis";
            janis.HourlySalary = 4.02M;

            Employee alnis = new Employee();
            alnis.Id = 2;
            alnis.FullName = "Alnis Balodis";
            alnis.HourlySalary = 4.00M;

            Company sampo = new Company();

            EmployeeTime time = new EmployeeTime();

            sampo.AddHours(janis.Id.ToString(), DateTime.Now, 2, 50);
            sampo.AddHours(alnis.Id.ToString(), DateTime.Now, 3, 50);

            
            time.AddId(1);
            time.AddHour(2);
            time.AddMinute(70);

            Console.WriteLine(time.Hour);

            
        }
    }
}
