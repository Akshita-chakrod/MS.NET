namespace Assignment01_ques03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number1: ");
            int num1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select operation(+,-,*,/)");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"result-{num1}+{num2}={result}");
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"result-{num1}-{num2}={result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"result-{num1}*{num2}={result}");
                    break;

                case '/':
                    result = num1 / num2;
                    Console.WriteLine($"result-{num1}/{num2}={result}");
                    break;


            }
        }
    }
}
