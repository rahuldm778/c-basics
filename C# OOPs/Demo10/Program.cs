using System;

namespace Demo10
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpDetails empDetails = new EmpDetails();
            var emplyee1 = empDetails;
            var emplyee2 = empDetails;
            var emplyee3 = empDetails;
            
            emplyee1.Name="Rahul";
            emplyee1.GrossSalary=15000;
            emplyee1.addres="Sadashiv Peth, Pune";
            emplyee1.PIN=424310;
            emplyee1.phone=9999999999;
            emplyee1.PF=3000;

            Console.WriteLine($"Net Salary is {emplyee1.NetSalary}");
            Console.WriteLine($"Salary grade is {emplyee1.grade}");
        }
    }
}
