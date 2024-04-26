using Trainers;
using Employees;
using Admins;
namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer(101,"Tarakaram",30,10000);
            trainer.Display();
        }
    }
}
