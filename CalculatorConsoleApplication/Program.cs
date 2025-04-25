using System;

namespace CalculatorConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************** CALCULATOR ****************");
            Console.WriteLine("|                                          |");
            Console.WriteLine("------ Enter the number with Operator ------");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Want to view the final Result press = to get the result");
            Console.WriteLine("Want to exit, Enter 'e' ");

            int result = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                string operators = Console.ReadLine();

                if (operators == "=")
                {
                    Console.WriteLine("--------------- Result: " + result + "---------------");
                    continue; 
                }

                if (operators == "e")
                {
                    Console.WriteLine("--------------- Final Result: " + result + "---------------");
                    break;
                }
                int num = Convert.ToInt32(Console.ReadLine());
                switch (operators)
                {
                    case "+":
                        result += num;
                        break;
                    case "-":
                        result -= num;
                        break;
                    case "*":
                        result *= num;
                        break;
                    case "/":
                        result /= num;
                        break;
                    case "%":
                        result %= num;
                        break;
                }
            }
        }
    }
}
