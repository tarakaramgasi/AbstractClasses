using Employees;
namespace Trainers
{
    public class Trainer:Employee
    {
        public Trainer(int empId, string empName, double empAge, double empSalary) :base(empId,empName,empAge,empSalary)
        {
            
        }
        public override double TotalSalary(int hrs)
        {
            return empSalary + (empSalary * 30 / 100) + (hrs * 2000);
        }
    }
}
