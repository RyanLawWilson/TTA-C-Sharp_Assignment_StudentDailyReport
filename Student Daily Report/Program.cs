using System;

namespace Student_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            System.Threading.Thread.Sleep(1000);

            Console.Write("What Course are you on?: ");
            string course = Console.ReadLine();

            Console.Write("What page number?: ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you need help with anything (true or false)?: ");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string otherFeedback = Console.ReadLine();

            Console.Write("How many hours did you study today?: ");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
