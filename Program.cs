using System;

namespace Conditional_Statement_ANieves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what grade do you expect to get in ISM 4300");

            try
            {
                string input = Console.ReadLine();

                integral score = int.TryParse(input);
                integer = 0;

                if (score < 60)
                {
                    Console.WriteLine("per Syllabus your letter grade is F");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 60,61)
                {
                    Console.WriteLine("per Syllabus your letter grade is D-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 62 - 67)
                {
                    Console.WriteLine("Per Syllabus your letter grade is D");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 68,69)
                {
                    Console.WriteLine("Per Syllabus your letter grade is D+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 70,71)
                {
                    Console.WriteLine("Per Syllabus your letter grade is C-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 72 - 77)
                {
                    Console.WriteLine("Per Syllabus your letter grade is C");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 78,79)
                {
                    Console.WriteLine("Per Syllabus your letter grade is C+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 80,81)
                {
                    Console.WriteLine("Per Syllabus your letter grade is B-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 82 - 87)
                {
                    Console.WriteLine("Per Syllabus your letter grade is B");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 88,89)
                {
                    Console.WriteLine("Per Syllabus your letter grade is B+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 90,91)
                {
                    Console.WriteLine("Per Syllabus your letter grade is A-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 92 - 97)
                {
                    Console.WriteLine("Per Syllabus your letter grade is A");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score 98 - 100)
                {
                    Console.WriteLine("Per Syllabus your letter grade is A+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }
        }
    } //end of namespace
}
