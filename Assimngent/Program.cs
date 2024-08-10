using Assimngent.Department;
using Assimngent.Employee;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Employee
        //Employee employee = new Employee("noor", 61, -10);
        //EmployeeLayOffEventArgs layOffArgs = new EmployeeLayOffEventArgs(employee, "negative vacation stock and old age");

        //employee.OnEmployeeLayOff();
        //employee.RequestVacation();
        //employee.EndOfYearOperation(); 
        #endregion

        #region Club
        // Club club = new Club { ClubID = 1, ClubName = "Executive Club" };
        //
        // Employee emp1 = new Employee { Name = "Mohamed", Age = 20, VacationStock = 10 };
        // Employee emp2 = new Employee { Name = "Bassem", Age = 62, VacationStock = 5 };
        // Employee emp3 = new Employee { Name = "ATTA", Age = 40, VacationStock = -5 };

        // club.AddMember(emp1);
        // club.AddMember(emp2);
        // club.AddMember(emp3);

        // club.ListMembers();
        // emp1.CheckVacationStock();
        // emp2.CheckVacationStock();
        // emp3.CheckVacationStock();

        // club.ListMembers();
        #endregion

        #region part04

        ////SalesPerson salesPerson = new SalesPerson();
        ////salesPerson.Name = "Ali Ahmed";
        ////salesPerson.Age = 35;
        ////salesPerson.AchievedTarget = 90;
        ////
        ////int salesQuota = 100;

        ////if (!salesPerson.CheckTarget(salesQuota))
        ////{
        ////    Console.WriteLine($"{salesPerson.Name} has failed to achieve the sales target and will be fired.");
        ////}
        ////else
        ////{
        ////    Console.WriteLine($"{salesPerson.Name} has achieved the sales target and will not be fired.");
        ////}

        ////BoardMember boardMember = new BoardMember();
        ////boardMember.Name = "Mohamed Bassem";
        ////boardMember.Age = 65;

        ////boardMember.Resign();

        ////if (boardMember.Age > 60)
        ////{
        ////    Console.WriteLine($"{boardMember.Name} is over 60 years old but will not be fired due to age.");
        ////}
        //Console.WriteLine($"{boardMember.Name} will remain a member of company clubs forever.");

        #endregion
        
    }
  
}
