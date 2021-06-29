using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary
{
    public interface MonthlyReportData
    {
        public int EmployeeId { get; set; }
        public int Year { get; set; }
        public short Month { get; set; }
        public decimal Salary { get; set; }
    }
}
