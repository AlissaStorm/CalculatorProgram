namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                double num1;
                double num2;
                double result;

                Console.WriteLine("------------------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option:");
                Console.WriteLine("+ : Add ");
                Console.WriteLine("- : substrat ");
                Console.WriteLine("* : multiply ");
                Console.WriteLine("/ : Divide ");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result:  {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result:  {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result:  {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result:  {num1} / {num2} = " + result);
                        break;
                }
                


              Console.WriteLine("Would you like to continue? ");
            } while (Console.ReadLine() == "yes");
            Console.WriteLine("Bye!");

        }
    }
}