namespace HSELAB2_3;

class Program
{
    static void Main(string[] args)
    {
        int n;
        int result = 0;
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
            result += 2 * i + 1;
        }
        
        Console.WriteLine($"Сумма последовательности нечетных чисел длиной n = {n} равна: {result}");
    }
}
