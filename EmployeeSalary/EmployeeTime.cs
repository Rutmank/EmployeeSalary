using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary
{
   public class EmployeeTime
    {
        public int Minute { get; set; }
        public int Hour { get; set; }
        public int Id { get; set; }

        public void AddId(int id)
        {
            Id = id;
        }

        public void AddMinute(int minute)
        {
            Minute += minute;
            if (Minute >= 60)
            {
                AddHour(Minute / 60);
                Minute %= 60;
            }
        }

        public void AddHour(int hour)
        {
            if (hour == 0)
            {
                throw new ArgumentNullException(nameof(hour), "hour can not be null");
            }
            Hour += hour;
        }
    }
}
