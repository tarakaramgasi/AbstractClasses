using Employees;
namespace Admins
{
    public class Admin : Employee
    {
        public Admin(int empId, string empName, double empAge, double empSalary):base(empId, empName, empAge, empSalary)
        {
            
        }
        public override double TotalSalary(int hrs)
        {
            return empSalary + (empSalary * 20 / 100) + (hrs * 1000);
        }
    }
}
