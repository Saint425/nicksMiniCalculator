using System;

namespace nicksMiniCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nick's Mini-Calc\n");
            bool UserContinue = true; // Does user want to continue if yes return here
            do
            {
                int x, y;
                Console.Write("First Number: "); // Our First Number
                x = int.Parse(Console.ReadLine());
                Console.Write("Second Number: "); // Our Second Number
                y = int.Parse(Console.ReadLine());
                Console.Write("Please Pick The Operation You Wish to Use?: (+,-,*,/,%) "); // Picking an Operation from one of the five options
                string ops = Console.ReadLine();

                calcFunction(x, y, ops); // Calls for the second function to calculate

                Console.ReadLine();
                Console.Write("Would You Like To Continue (y or n)?"); // calling the bool to ask the user do you want to continue t is yes and n is false
                string yesorno = Console.ReadLine();

                if (yesorno == "y")
                {
                    UserContinue = true; // continue the program
                }
                else if (yesorno == "n")
                {
                    UserContinue = false; // closes the program
                    Console.WriteLine("Thank you & Come Back Soon! ^_^"); 
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error Invalid Input Please Try Again"); // Should an error occur in the process of continue or not this will pop-up
                }
            } while (UserContinue == true);

        }

        static int calcFunction(int xparum, int yparum, string optparum) // This does the calculations for us
        {
            int x = xparum;
            int y = yparum;
            string ops = optparum;
            int result;
            switch (ops)
            {
                case "+":
                    result = x + y;
                    Console.WriteLine("{0} + {1} = {2}", x, y, result);
                    return result;
                case "-":
                    result = x - y;
                    Console.WriteLine("{0} - {1} = {2}", x, y, result);
                    return result;
                case "*":
                    result = x * y;
                    Console.WriteLine("{0} * {1} = {2}", x, y, result);
                    return result;
                case "/":
                    result = x / y;
                    Console.WriteLine("{0} / {1} = {2}", x, y, result);
                    return result;
                case "%":
                    result = x % y;
                    Console.WriteLine("{0} % {1} = {2}", x, y, result);
                    return result;
                default:
                    Console.WriteLine("Error Invalid Operation Please Try Again");
                    result = 0;
                    return result;
            }
        }
    }
}
