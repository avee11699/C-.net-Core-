using System;

namespace Day5
{
    class Student
    {
        int Sid;
        String Name;
        double M1,M2;
        String Contact;

        public Student()
        {
            Console.WriteLine("This is a default constructor");
        }

        public Student(int Sid, String Name)
        {
            this.Sid = Sid;
            this.Name = Name;
        }

        public Student(int Sid, String Name, String Contact)
        {
            this.Sid = Sid;
            this.Name = Name;
            this.Contact = Contact;
        }

        public void SetMArks(double M1, double M2)
        {
            this.M1 = M1;
            this.M2 = M2;
        } 

        public void GetDetails()
        {
            Console.WriteLine("Student Id:{0}  Name:{1}  Contact:{2}",Sid,Name,Contact);
        }

        public void Result()
        {
            double avg = (M1 + M2) / 2;
            if (avg >= 35)
            {
                Console.WriteLine("Pass!");
            }
            if (avg < 35)
            {
                Console.WriteLine("Fail!");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var S = new Student(100, "Avneesh", "1234567");
            S.GetDetails();
            S.SetMArks(63, 73);
            S.Result();
           


            Console.ReadLine();

        }
    }
}
