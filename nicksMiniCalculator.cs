using System;

namespace nicksMiniCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nick's Mini-Calc\n");
            bool UserContinue = true;
            do
            {
                int x, y;
                Console.Write("First Number: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Second Number: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Please Pick The Operation You Wish to Use?: (+,-,*,/,%) ");
                string ops = Console.ReadLine();

                calcFunction(x, y, ops); // Calls for the second function

                Console.ReadLine();
                Console.Write("Would You Like To Continue (y or n)?");
                string yesorno = Console.ReadLine();

                if (yesorno == "y")
                {
                    UserContinue = true;
                }
                else if (yesorno == "n")
                {
                    UserContinue = false;
                    Console.WriteLine("Thank you & Come Back Soon! ^_^");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error Invalid Input Please Try Again");
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
