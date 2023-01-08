public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            var firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Выберите команду: \n" +
                              $"1. Сложить числа \n" +
                              $"2. Вычесть числа \n");

            var choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            var secondNumber = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    var sum = firstNumber + secondNumber;
                    Console.WriteLine("Результат сложения " + sum);
                    break;
                }
                case 2:
                {
                    var difference = firstNumber - secondNumber;
                    Console.WriteLine("Результат вычитания " + difference);
                    break;
                }
            }
        }
    }
}