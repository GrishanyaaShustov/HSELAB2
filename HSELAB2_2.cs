namespace HSELAB2_2;

class Program
{
    static void Main(string[] args)
    {
        int K1;
        int K2;
        int currentNumber;
        int result = 0;
        int numPointer = 1;
        bool isNumber;
        bool isGoing = true;
        
        Console.WriteLine("Данная программа считает кол-во чисел, в введенной вами последовательности, кратных K1 и не кратных K2\n");

        do
        {
            Console.Write("Введите число K1: ");
            isNumber = Int32.TryParse(Console.ReadLine(), out K1);

            if (!isNumber || K1 == 0)
            {
                Console.WriteLine("\nОшибка ввода. Введенное значение не явялется целым числом или выходит за пределы типа Int32");
                Console.WriteLine("Попробуйте еще раз\n");
            }
        }
        while (!isNumber || K1 == 0);
        
        do
        {
            Console.Write("Введите число K2: ");
            isNumber = Int32.TryParse(Console.ReadLine(), out K2);

            if (!isNumber || K2 == 0)
            {
                Console.WriteLine("\nОшибка ввода. Введенное значение не явялется целым числом или выходит за пределы типа Int32");
                Console.WriteLine("Попробуйте еще раз\n");
            }
        }
        while (!isNumber || K2 == 0);

        Console.WriteLine($"\nВведены числа K1: {K1}, K2: {K2}");
        Console.WriteLine("Введите последовательность целых чисел. Если хотите закончить, введите цифру 0");

        while (isGoing)
        {
            Console.Write($"Введите число №{numPointer}: ");
            isNumber = Int32.TryParse(Console.ReadLine(), out currentNumber);

            if (!isNumber)
            {
                Console.WriteLine("\nОшибка ввода. Введенное значение не явялется целым числом или выходит за пределы типа Int32");
                Console.WriteLine("Попробуйте еще раз\n");
            }
            else if (isNumber && currentNumber == 0)
            {
                Console.WriteLine("Последовательность завершена.");
                Console.WriteLine($"Кол-во чисел кратных {K1} и не кратных {K2}: {result}");
                isGoing = false;
            }
            else if (isNumber && currentNumber != 0)
            {
                numPointer++;
                if (currentNumber % K1 == 0 && currentNumber % K2 != 0) result++;
            }
        }
    }
}
