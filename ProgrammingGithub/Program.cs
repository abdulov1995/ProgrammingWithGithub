using System;

namespace ProgrammingGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            int password = 1234;
            int maxAttempts = 3;

            Console.WriteLine("Enter PIN: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (password != userInput)
            {
                for (int attempt = 1; attempt <= maxAttempts; attempt++)
                {
                    Console.WriteLine(maxAttempts - attempt + " chances left");
                    Console.WriteLine("Enter PIN: ");
                    int pin2 = Convert.ToInt32(Console.ReadLine());
                    if (maxAttempts - attempt == 0)
                    {
                        Console.WriteLine("No more chances. Access denied!");
                        Console.ReadLine();
                        break;
                    }

                }


            }
            else
            {
                Console.WriteLine("Correct PIN. Access granted!");
            }
        }
         /// deyisiklik etdim
    }
    
}
