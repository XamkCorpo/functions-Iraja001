namespace FunctionAssigment
{
    internal class Program
    {
        static string kysynimi()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();
                Console.WriteLine("Name cannot be empty.");


            }
        }

        static int Kysyika()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("Please enter a positive integer.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void Tulostanimiika(string name, int age)
        {

            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        
        static bool tarkistataysiIkainen(int age)
        {
            return age >= 18;
        }

        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this

            string name = kysynimi();
            int age = Kysyika();

            bool isAdult = tarkistataysiIkainen(age);

            if (isAdult == true)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");

            // Compare the name to another string (e.g., "Matti")
            string compareName = "Matti";

            bool namesMatch = Vertaanimea(name, compareName);

        }

        static bool Vertaanimea(string name, string compareTo)
        {
            bool isMatch = false;
            // Comparison ignoring case
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");
                isMatch = true;

            }
            // Exact match comparison (case-sensitive)
            if (name.Equals(compareTo))
                Console.WriteLine($"your name matches '{compareTo}' (case-sensitive).");

            return isMatch;
        }
    }
}
