using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the header
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Ask for and save student data
            Console.Write("What is your name? ");
            string name = Console.ReadLine();  // Get the student's name as a string

            Console.Write("What course are you on? ");
            string course = Console.ReadLine();  // Get the course name as a string

            Console.Write("What page number? ");
            int page_number = Convert.ToInt32(Console.ReadLine());  // Get and convert page number to an integer

            Console.Write("Do you need help with anything? Please answer “true” or “false.” ");
            bool need_help = Convert.ToBoolean(Console.ReadLine());  // Get and convert help status to a boolean

            Console.Write("Were there any positive experiences you’d like to share? Please give specifics. ");
            string positive_experiences = Console.ReadLine();

            Console.Write("Is there any other feedback you’d like to provide? Please be specific. ");
            string feedback = Console.ReadLine();

            Console.Write("How many hours did you study today? ");
            float study_hours = Convert.ToSingle(Console.ReadLine());  // Get and convert study hours to a float

            // Print a thank you message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            string thank_you = Console.ReadLine();
        }
    }
}
