using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace LINQlab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Console.WriteLine("For Nums!");
            Console.WriteLine("1. Find the Minimum value");
            Console.WriteLine($"Answer: {nums.Min()}");
            Console.WriteLine();
            Console.WriteLine("2. Find the Maximum value");
            Console.WriteLine($"Answer: {nums.Max()}");
            Console.WriteLine();
            Console.WriteLine("3. Find the Maximum Value less than 10000");
            Console.WriteLine($"Answer: {nums.Where(x=>x<10000).Max()}");
            Console.WriteLine();
            Console.WriteLine("4. Find all the values between 10 and 100");
            List<int> numsBetween10and100 = nums.Where(x => x > 10 && x < 100).ToList();
            //This will be empty
            Console.WriteLine("Answer(s): ");
            foreach(int n in numsBetween10and100)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("5. Find all values between 100000 and 999999");
            List<int> numsBetween100kand999999 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            Console.Write("Answer(s): ");
            foreach (int n in numsBetween100kand999999)
            {
                Console.Write(n + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("6. Count all the even numbers");
            Console.WriteLine($"Answer: {nums.Count(x=>x%2==0)}");

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("For Students!");

            Console.WriteLine("1. Find all the students age 21 and over");
            List<Student> canDrinkAlcohol = students.Where(x => x.Age >= 21).ToList();
            Console.WriteLine("Answer: ");
            foreach(Student s in canDrinkAlcohol)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            Console.WriteLine("2. Find the oldest student");
            int oldestAge = students.Max(x => x.Age);
            Student oldie = students.Where(x => x.Age == oldestAge).First();
            Console.WriteLine($"Answer: {oldie.Name}");
            Console.WriteLine();

            Console.WriteLine("3. Find the youngest student");
            int youngestAge = students.Min(x => x.Age);
            Student baby = students.Where(x => x.Age == youngestAge).First();
            Console.WriteLine($"Answer: {baby.Name}");
            Console.WriteLine();

            Console.WriteLine("4. Find the oldest student under the age of 25");
            List<Student> under25 = students.Where(x => x.Age < 25).ToList();
            int oldestUnder25 = under25.Max(x => x.Age);
            Console.WriteLine($"Answer: {(under25.Where(x=>x.Age == oldestUnder25).First()).Name}");
            Console.WriteLine();

            Console.WriteLine("5. Find all the students over 21 and with even ages");
            List<Student> canDrinkEvenAge = canDrinkAlcohol.Where(x => x.Age % 2 == 0).ToList();
            Console.WriteLine("Answer: ");
            foreach(Student s in canDrinkEvenAge)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            Console.WriteLine("6. Find all teenage students (13 to 19 inclusive)");
            List<Student> teenagers = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            Console.WriteLine("Answer:");
            foreach(Student s in teenagers)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            Console.WriteLine("7. Find all students whos name starts with a vowel");
            List<Student> shouldJustBeAbe = students.Where(x => x.Name.ToLower().StartsWith("a") || x.Name.ToLower().StartsWith("e") || x.Name.ToLower().StartsWith("i") || x.Name.ToLower().StartsWith("o") || x.Name.ToLower().StartsWith("u")).ToList();
            foreach(Student s in shouldJustBeAbe)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
