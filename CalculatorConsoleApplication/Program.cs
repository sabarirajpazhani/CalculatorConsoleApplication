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
            
            int result = Convert.ToInt32(Console.ReadLine());
            
            while (true)
            {
                string operators = Console.ReadLine();

                if (operators == "=")
                {
                    Console.WriteLine("----------- Result: " + result + "----------");
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
                        result/= num;
                        break;
                    case "%":
                        result %= num;
                        break;
                        
                }

            }
        }
    }
}
