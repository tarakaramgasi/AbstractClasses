namespace Employees
{
    public abstract class Employee
    {
        int empId;
        string empName;
        protected double empAge, empSalary;

        public Employee(int id, string name, double age,double salary)
        {
            this.empId = id;
            this.empName = name;
            this.empAge = age;
            this.empSalary = salary;
        }
        public abstract double TotalSalary(int hrs);

        public virtual void Greet(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        public void Display()
        {
            Console.WriteLine($"Employee Name: {empName}, Total Salary:{TotalSalary(8)}");
        }

    }
}
