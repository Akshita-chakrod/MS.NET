using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Assignment01_Question02
{
    internal class Program
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        //static int menu()
        //{
        //    Console.WriteLine("Enter your choice:");
        //    Console.WriteLine("0.Exit");
        //    Console.WriteLine("1.Addition");
        //    Console.WriteLine("2.Subtraction");
        //    Console.WriteLine("3.multiplication");
        //    Console.WriteLine("4.Division");
        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    return choice;
        //}
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int choice;
            do
            {
                Program program = new Program();
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                // choice = menu();
                double result=0;
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting the program.");
                        break;
                    case 1:
                       // result = Addition(num1, num2);
                        result = program.Addition(num1, num2);
                        Console.WriteLine("addition:" + (num1 + num2));
                        break;
                    case 2:
                        result = program.Subtraction(num1, num2);
                        Console.WriteLine("subtraction:" + (num1 - num2));
                        break;
                    case 3:
                        result = program.Multiplication(num1, num2);
                        Console.WriteLine("Multiplication:" + (num1 * num2));
                        break;
                    case 4:
                        result = program.Division(num1, num2);
                        Console.WriteLine("Division:" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid operation.");
                        break;

                }
            } while (choice != 0);
        }
    }
}

