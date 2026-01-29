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

            // Behavior 3

            Console.WriteLine("Select a guidance option: ");
            Console.WriteLine("1 - Academic Planning");
            Console.WriteLine("2 - Personal Planning");
            Console.WriteLine("3 - Career Planning");
            Console.WriteLine("Enter choice: ");

            string choiceInput = Console.ReadLine();
            int choice = int.Parse(choiceInput);

            Console.WriteLine();
            Console.WriteLine("Guidance: ");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Meet with an academic advisor to plan your next term.");
                    break;
                case 2:
                    Console.WriteLine("Set a schedule and make small weekly goals to sray on track");
                    break;
                case 3:
                    Console.WriteLine("Explore careers, build a resume, and look for interships or entry-level jobs");
                    break; 
                default:
                    Console.WriteLine("Invalid selection. Please chose 1, 2, or 3 next time.");
                    break;
            }
        }
    }
}
