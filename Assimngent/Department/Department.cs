﻿using Assimngent.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimngent.Department
{
    internal class Department
    {
        //public int DeptID { get; set; }
        //public string? DeptName { get; set; }

        //private readonly List<Employee> Staff = new List<Employee>();

        //public void AddStaff(Employee E)
        //{
        //    if (E is not null)
        //    {
        //        Staff.Add(E);
        //        E.EmployeeLayOff += RemoveStaff;
        //    }
        //}

        //public void RemoveStaff(object? sender, EmployeeLayOffEventArgs e)
        //{
        //    if (sender is EmployeeLayOffEventArgs employee)
        //    {

        //        Console.WriteLine($"Removing employee {employee.EmployeeID} due to layoff cause: {e.Cause}");

        //        employee.EmployeeLayOff -= RemoveStaff;

        //        Staff.Remove(employee);
        //    }
        //}

        //public void DisplayStaff()
        //{
        //    Console.WriteLine($"Department \"{DeptName}\" Staff List:\n");
        //    foreach (Employee employee in Staff)
        //    {
        //        Console.WriteLine($"Employee ID: {employee.EmployeeID}, Birth Date: {employee.BirthDate.ToShortDateString()}, Vacation Stock: {employee.VacationStock}");
        //    }
        //}
    }
}

