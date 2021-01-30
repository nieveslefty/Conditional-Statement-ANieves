using System;

namespace Conditional_Statement_ANieves
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt for the grade
            Console.WriteLine("Hello, what grade do you expect to get in ISM 4300");
            string input = Console.ReadLine();

            int score; //input score

            //parse to integer
            if (int.TryParse(input, out score))
            {
                if (score < 60)
                {
                    Console.WriteLine("Per Syllabus your letter grade is F");
                }
                else if (score >= 60 && score <= 61)
                {
                    Console.WriteLine("Per Syllabus your letter grade is D-");
                }
                else if (score >= 62 && score <= 67)
                {
                    Console.WriteLine("Per Syllabus your letter grade is D");
                }
                else if (score >= 68 && score <= 69)
                {
                    Console.WriteLine("Per Syllabus your letter grade is D+");
                }
                else if (score >= 70 && score <= 71)
                {
                    Console.WriteLine("Per Syllabus your letter grade is C-");
                }
                else if (score >= 72 && score <= 77)
                {
                    Console.WriteLine("Per Syllabus your letter grade is C");
                }
                else if (score >= 78 && score <= 79)
                {
                    Console.WriteLine("Per Syllabus your letter grade is C+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (score >= 80 && score <= 81)
                {
                    Console.WriteLine("Per Syllabus your letter grade is B-");
                }
                else if (score >= 82 && score <= 87)
                {
                    Console.WriteLine("Per Syllabus your letter grade is B");
                }
                else if (score >= 88 && score <= 89)
                {
                    Console.WriteLine("Per Syllabus your letter grade is B+");
                }
                else if (score >= 90 && score <= 91)
                {
                    Console.WriteLine("Per Syllabus your letter grade is A-");
                }
                else if (score >= 92 && score <= 97)
                {
                    Console.WriteLine("Per Syllabus your letter grade is A");
                }
                else if (score >= 98 && score <= 100)
                {
                    Console.WriteLine("Per Syllabus your letter grade is A+");
                }
                else
                {
                    Console.WriteLine("Invalid score. It must be between 0 and 100");
                }
            }
            else
            {
                Console.WriteLine("Invalid score. It must be an integer number");
            }

            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);

        } //end main
    } //end of class
}//end namespace
