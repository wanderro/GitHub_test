public class Program
{
    static void Main(string[] args)
    {
        int userResponse;
        do
        {
            Console.WriteLine("Первое число.");
            var firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Математическая операция:\n +\n -\n *\n /\n");
            var operation = Console.ReadLine();

            Console.WriteLine("Второе число.");
            var secondNumber = Convert.ToDouble(Console.ReadLine());

            CalculateOperation(operation, firstNumber, secondNumber);

            Console.WriteLine("Совершить еще одну операцию?\n" +
                              "1. Да\n" +
                              "2. Нет");
            userResponse = Convert.ToInt32(Console.ReadLine());
        } while (userResponse == 1);
    }

    private static void CalculateOperation(string operation, double firstNumber, double secondNumber)
    {
        double result;
        switch (operation)
        {
            case "+":
                result = firstNumber + secondNumber;
                Console.WriteLine("Результат: " + result);
                break;
            case "-":
                result = firstNumber - secondNumber;
                Console.WriteLine("Результат: " + result);
                break;
            case "*":
                result = firstNumber * secondNumber;
                Console.WriteLine("Результат: " + result);
                break;
            case "/":
                result = firstNumber / secondNumber;
                Console.WriteLine("Результат: " + result);
                break;
            default:
                Console.WriteLine("Выбрана неверная операция.");
                break;
        }
    }
}