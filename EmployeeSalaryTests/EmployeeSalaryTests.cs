using EmployeeSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EmployeeSalaryTests
{
    public class EmployeeSalaryTests
    {

        [Fact]
        public void When_a_class_object_is_created_then_info_outputs_information()
        {
            // Setup
            Employee janis = new Employee();  

            // Act
            janis.Id = 1;
            janis.FullName = "Janis Statis";
            janis.HourlySalary = 4.02M;
            string info = $"Id: {janis.Id}, Name: {janis.FullName}, Salary: {janis.HourlySalary}"; 

            // Assert
            Assert.Equal($"Id: 1, Name: Janis Statis, Salary: 4.02", info);

        }

        [Fact]
        public void When_a_class_object_is_added_in_EmployeesList_then_info_outputs_information()
        {
            // Setup
            Employee employee = new Employee();
            Company sampo = new Company();
            DateTime contractStartDate = DateTime.Now;

            // Act
            employee.Id = 1;
            employee.FullName = "Janis Statis";
            employee.HourlySalary = 4.02M;

            sampo.AddEmployee(employee, contractStartDate);

            string info = $"Id: {sampo.employees[0].Id}, Name: {sampo.employees[0].FullName}, Salary: {sampo.employees[0].HourlySalary}";

            // Assert
            Assert.Equal($"Id: 1, Name: Janis Statis, Salary: 4.02", info);
        }

        [Fact]
        public void When_null_is_given_as_employee_in_Added_Time_Then_ArgumentNullException_is_thrown()
        {
            // Setup
            var employee =  new Company();
            DateTime contractStartDate = DateTime.Now;


            // Act


            // Assert
            Assert.Throws<ArgumentNullException>(() => employee.AddEmployee(null, contractStartDate));
        }

        [Fact]
        public void When_a_employee_is_removed_from_EmployeesList_then_result_is_true()
        {
            // Setup
            Employee employee = new Employee();
            Company sampo = new Company();
            DateTime contractStartDate = DateTime.Now;
            DateTime contractEndDate = DateTime.Now;

            // Act
            employee.Id = 1;
            employee.FullName = "Janis Statis";
            employee.HourlySalary = 4.02M;

            sampo.AddEmployee(employee, contractStartDate);

            sampo.RemoveEmployee(employee, contractEndDate);

            bool result;

            if (sampo.employees.Contains(employee))
            {
                result = false;
            }
            else
            {
                result = true;
            }

            // Assert
            Assert.Equal(true, result);
        }

        [Fact]
        public void When_null_is_given_as_employee_in_Removed_Time_Then_ArgumentNullException_is_thrown()
        {
            // Setup
            var employee = new Company();
            DateTime contractEndDate = DateTime.Now;


            // Act


            // Assert
            Assert.Throws<ArgumentNullException>(() => employee.RemoveEmployee(null, contractEndDate));
        }

        [Fact]
        public void When_the_number_of_minutes_is_more_than_59_then_minutes_turn_into_hours()
        {
            // Setup
            Employee employee = new Employee();
            EmployeeTime time = new EmployeeTime();

            // Act
            employee.Id = 1;
            employee.FullName = "Janis Statis";
            employee.HourlySalary = 4.02M;

            //sampo.AddHours(employee.Id.ToString(), DateTime.Now, 2, 70);

            time.AddId(employee.Id);
            time.AddHour(2);
            time.AddMinute(70);

           // Assert
            Assert.Equal(3, time.Hour);
        }

        [Fact]
        public void When_0_is_given_as_Hour_in_Removed_Time_Then_ArgumentNullException_is_thrown()
        {
            // Setup
            EmployeeTime time = new EmployeeTime();
            


            // Act


            // Assert
            Assert.Throws<ArgumentNullException>(() => time.AddHour(0));
        }

    }
}
