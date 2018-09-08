using System;

namespace CsharpM1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //This is a program using the comparison operator to compare a two different salary amounts
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            int hourlyRate = 12;
            int hoursWorkedWeekly = 25;
            Console.WriteLine("Person 1 hourly pay rate is equal to ? " + " " + "$"+ hourlyRate );
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?" + " " + hoursWorkedWeekly);
            Console.ReadLine();
            int hourlyRate2 = 25;
            int hoursWorkedWeekly2 = 40;
            // Lines 25 and 28 demonstrate the multiplication operator so that we can return the product of hours worked and hourly salary
            Console.WriteLine("Person 2 hourly pay rate is equal to ? " + " " + "$"+ hourlyRate2);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?" + " " + hoursWorkedWeekly2);
            Console.ReadLine();
            int salaryPerson1 = 25 * 12;
            Console.Write("Weekly salary of Person 1 :" + " " + "$" + salaryPerson1);
            Console.ReadLine();
            int salaryPerson2 = 40 * 25;
            Console.ReadLine();
            Console.Write("Weekly salary of Person 1 :" + " " + "$" + salaryPerson2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            // An if statment is used to compare the salaries of Person 1 to Person 2
            if (salaryPerson1 > salaryPerson2)
            {

                Console.WriteLine("True");
            }

            else {
                    Console.WriteLine("False");
                
            }
            Console.ReadLine();




        }
    }
}
