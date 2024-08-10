using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimngent.Employee
{
    #region Enums
    public enum LayOffCause
    {
        ZeroVactionStock,
        SixtyAge
    }
    #endregion

    public class EmployeeLayOffEventArgs : Employee
    {
        public EmployeeLayOffEventArgs(Employee employee, string layOffCause) : base(employee.Name, employee.Age, employee.VacationStock)
        {
            LayOffCause = layOffCause;
        }

        public string LayOffCause { get; private set; }
    }

    public class Employee
    {
        public Employee(string name, int age, int vacationStock)
        {
            Name = name;
            Age = age;
            VacationStock = vacationStock;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public int VacationStock { get; private set; }

        public void OnEmployeeLayOff()
        {
            if (VacationStock < 0 || Age > 60)
            {

            }
        }

        public void LayOff(LayOffCause layOffCause)
        {
            Console.WriteLine($"Employee {Name} has been laid off due to {layOffCause}.");
        }

        public void RequestVacation()
        {
            Console.WriteLine("Vacation request has been submitted.");
        }

        public void EndOfYearOperation()
        {
            Console.WriteLine("End-of-year operation has been completed.");
        }
    }
}


