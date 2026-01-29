using System.Data;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Academic & Personal Readiness Evaluator ===");
            Console.WriteLine();

            //Behavior 1

            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Current Year: " + currentYear);

            Console.WriteLine("Enter your birth year: ");
            string birthYearInput = Console.ReadLine();
            int birthYear = int.Parse(birthYearInput);

            int age = currentYear - birthYear;
            Console.WriteLine();
            Console.WriteLine("Calculated Age: " + age);

            string readinessCategory;

            if (age < 18)
            {
                readinessCategory = "Minor";
            }
            else if (age <= 64)
            {
                readinessCategory = "Adult";
            }
            else
            {
                readinessCategory = "Senior";
            }

            Console.WriteLine("Readiness Category: " + readinessCategory);
            Console.WriteLine();

            // Behavior 2

            Console.Write("Do you have a valid ID? (yes/no): ");
            string hasIdInput = Console.ReadLine();

            Console.Write("Have you completed orientation? (yes/no): ");
            string orientationInput = Console.ReadLine();

            bool hasId = (hasIdInput == "yes");
            bool completedOrientation = (orientationInput == "yes");

            string readinessStatus;

            if (readinessCategory == "Minor")
            {
                readinessStatus = "Not Ready";
            }
            else if (!hasId)
            {
                readinessStatus = "Not Ready";
            }
            else if (hasId && !completedOrientation)
            {
                readinessStatus = "Conditionally Ready";
            }
            else
            {
                readinessStatus = "Ready";
            }

            Console.WriteLine();
            Console.WriteLine("Readiness Status: " + readinessStatus);
            Console.WriteLine();
        }
    }
}
