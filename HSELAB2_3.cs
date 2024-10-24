namespace HSELAB2_3;

class Program
{
    static void Main(string[] args)
    {
        int n;
        int result = 0;
        long checkValue = 0;
        bool isNumber;
        
        Console.WriteLine("Данная программа считает сумму последовательности n нечетных чисел: 1 + 3 + 5 + 7...\n");

        do
        {
            Console.Write("Введите целое, положительное число n: ");
            isNumber = Int32.TryParse(Console.ReadLine(), out n);
            if (!isNumber || n <= 0)
            {
                Console.WriteLine("\nПроизошел неверный ввод.");
                Console.WriteLine("Убедитесь, что число n положительное, целое, содержит только числа, не больше 2^31 - 1, и  попробуйте еще раз.\n");
            }
        }
        while (!isNumber || n <= 0);

        for (int i = 0; i < n; i++)
        {
            checkValue += 2 * i + 1;
            if (checkValue <= Int32.MaxValue) result += 2 * i + 1;
            else
            {
                Console.WriteLine("\nИз-за большого количества элементов последовательности при следующем прибавлении результат превысит тип Int32");
                Console.WriteLine("Поэтому будет выведена последняя корректная сумма\n");
                break;
            }
        }
        
        Console.WriteLine($"Сумма последовательности нечетных чисел равна: {result}");
    }
}
