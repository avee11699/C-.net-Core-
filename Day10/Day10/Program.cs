using System;

#region AbstractEg
//abstract class A
//{
//    public void Show()
//    {
//        Console.WriteLine("This is show of A");
//    }

//    public abstract void Display();
//}

//class B:A
//{
//    public override void Display()
//    {
//        Console.WriteLine("This Is display Of B");
//    }
//}

//namespace AbstractEg
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //A a;// = new A();

//            //a = new B();

//            //a.Show();
//            //a.Display();

//            Console.ReadLine();
//        }
//    }
//} 
#endregion

abstract class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public double SalPerHour { get; set; }

    public virtual void Details()
    {
        Console.WriteLine("EmpId :" + EmpId);
        Console.WriteLine("Emp Name :" + Name);
        Console.WriteLine("Salary Per Hour :" + SalPerHour);
    }

    public abstract void CalculateSalary(int NoOfWorkingHours);
    public abstract void CalculateLeaves();
}

class SoftwareEngg : Employee
{
    public string Technology { get; set; }
    public override void Details()
    {
        base.Details();
        Console.WriteLine("Technology :" + Technology);
    }
    public override void CalculateSalary(int NoOfWorkingHours)
    {
        //HRA 15%
        double BS = (SalPerHour * NoOfWorkingHours);
        double HRA = BS * 15 / 100;
        double GS = BS + HRA;
        Console.WriteLine("Gross Salary Of SE is :" + GS);
    }

    public override void CalculateLeaves()
    {
        Console.WriteLine("This is calculating Leaves of SE");
    }
}

class TeamLead : Employee
{
    public int Size { get; set; }
    public override void Details()
    {
        base.Details();
        Console.WriteLine("Size :" + Size);
    }
    public override void CalculateSalary(int NoOfWorkingHours)
    {
        //HRA 30.5%
        double BS = (SalPerHour * NoOfWorkingHours);
        double HRA = BS * 30.5 / 100;
        double GS = BS + HRA;
        Console.WriteLine("Gross Salary Of TeamLead is :" + GS);
    }

    public override void CalculateLeaves()
    {
        Console.WriteLine("This is calculating Leaves of TL");
    }
}

namespace AbstractEg
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E;
            Console.WriteLine("1.SE 2.TL 3.HR");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    E = new SoftwareEngg() { EmpId = 100, Name = "Peter", SalPerHour = 45, Technology = ".Net Core" };
                    break;
                case 2:
                    E = new TeamLead() { EmpId = 200, Name = "Jack", SalPerHour = 46, Size = 12 };
                    break;
                default:
                    E = new SoftwareEngg() { EmpId = 100, Name = "Peter", SalPerHour = 45, Technology = ".Net Core" };
                    break;
            }

            E.Details();
            E.CalculateSalary(36);
            E.CalculateLeaves();
            Console.ReadLine();
        }
    }
}

