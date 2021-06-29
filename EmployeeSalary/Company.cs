using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary
{
    public class Company : ICompany
    {
        public string Name { get;}

        public Employee[] Employees { get;}

        public List<Employee> employees = new List<Employee>();


        public void AddEmployee(Employee employee, DateTime contractStartDate)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "employee can not be null");
            }

            employees.Add(employee);
        }

        public void AddHours(string employeeId, DateTime dateAndTime, int hours, int minutes)
        {
            int id = int.Parse(employeeId);

            EmployeeTime time = new EmployeeTime();
            time.AddId(id);
            time.AddMinute(minutes);
            time.AddHour(hours);
        }

        public MonthlyReportData[] GetMonthlyReport(DateTime periodStartDate, DateTime periodEndDate)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(Employee employee, DateTime contractEndDate)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "employee can not be null");
            }

            employees.Remove(employee);
        }
    }
}
