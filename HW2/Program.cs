namespace HW2;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Ex. 1\n");
        Ex1();
        Console.WriteLine("\nEx. 2\n");
        Ex2();
        Console.WriteLine("\nEx. 3\n");
        Ex3();
        Console.WriteLine("\nEx. 4\n");
        Ex4();
    }

    private static void Ex1()
    {
        Console.Write("Input number 1: ");
        int num1 = ReadInt();
        Console.Write("Input number 2: ");
        int num2 = ReadInt();

        Console.Write("Input operation: ");
        char symbol = ReadSymbol();

        switch (symbol)
        {
            case '+':
                Console.WriteLine($"The sum of {num1} and {num2} is {Calculator.Sum(num1, num2)}.");
                break;
            case '-':
                Console.WriteLine($"The difference between {num1} and {num2} is {Calculator.Subtract(num1, num2)}.");
                break;
            case '*':
                Console.WriteLine($"The product of {num1} and {num2} is {Calculator.Multiply(num1, num2)}.");
                break;
            case '/':
                try
                {
                    Console.WriteLine($"The quotient of {num1} and {num2} is {Calculator.Divide(num1, num2)}.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                break;
            default:
                Console.WriteLine("Invalid operator. Please use either +, -, *, or /.");
                break;
        }
    }

    private static void Ex2()
    {
        Console.Write("Input temperature in Celsius: ");
        float temperatureInC = float.Parse(Console.ReadLine()!);

        float temperatureInF = temperatureInC * 9 / 5 + 32;

        Console.WriteLine($"The temperature in Fahrenheit is {temperatureInF}.");
    }

    private static void Ex3()
    {
        Console.Write("Input weight in kg: ");
        float weight = ReadFloat();

        Console.Write("Input height in m: ");
        float height = ReadFloat();

        float bmi = weight / (height * height);

        Console.WriteLine($"Your BMI is {bmi}.");
    }

    private static void Ex4()
    {
        const double mdlToUsd = 0.055;

        Console.Write("Input name: ");
        string name = Console.ReadLine()!;

        Console.Write("Input brute salary in MDL: ");
        float bruteSalary = ReadFloat();

        Console.Write("Input category of tax: ");
        int category = ReadInt();

        double netSalaryInMdl = 0;

        switch (category)
        {
            case 0:
                Console.WriteLine($"Tax rate: 0%");
                netSalaryInMdl = bruteSalary;
                break;
            case 1:
                Console.WriteLine($"Tax rate: 10%");
                netSalaryInMdl = bruteSalary - bruteSalary / 10;
                break;
            case 2:
                Console.WriteLine($"Tax rate: 20%");
                netSalaryInMdl = bruteSalary - bruteSalary / 20;
                break;
            case 3:
                Console.WriteLine($"Tax rate: 30%");
                netSalaryInMdl = bruteSalary - bruteSalary / 30;
                break;
            default:
                Console.WriteLine("Invalid category");
                break;
        }

        double netSalaryInUsd = netSalaryInMdl * mdlToUsd;
        Console.WriteLine($"{name}, your net salary in USD is {netSalaryInUsd}.");

        if (netSalaryInUsd > 2000)
        {
            Console.WriteLine($"{name}, your salary is over average");
        }
        else
        {
            Console.WriteLine($"{name}, your salary is over average");
        }
    }

    private static char ReadSymbol()
    {
        return Console.ReadKey().KeyChar;
    }

    private static int ReadInt()
    {
        return int.Parse(Console.ReadLine()!);
    }

    private static float ReadFloat()
    {
        return float.Parse(Console.ReadLine()!);
    }


    private static class Calculator
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return (double)num1 / num2;
        }
    }
}
