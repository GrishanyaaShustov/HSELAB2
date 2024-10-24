
namespace HSELAB2_1;

class Program
{
    static void Main(string[] args)
    {
        int sumEven = 0;
        int numPointer = 0;
        int n;
        int currentNumber = 0;
        long checkValue = 0;
        bool isNumber;
        bool isEvenIn = false;
        
        Console.WriteLine("Данная программа считает сумму четных чисел в веденной вами последовательности.");
        do
        {
            Console.Write("Введите длину последовательности: ");
            isNumber = Int32.TryParse(Console.ReadLine(), out n);

            if (!isNumber || n < 0)
            {
                Console.WriteLine("\nОшибка ввода. Введенное значение не явялется целым неотрицательным числом или выходит за пределы типа Int32");
                Console.WriteLine("Попробуйте еще раз\n");
            }
        }
        while (!isNumber || n < 0);

        while (numPointer != n) 
        {
            Console.Write($"\nВведите целое число №{numPointer+1}: ");
            isNumber = Int32.TryParse(Console.ReadLine(), out currentNumber);
            
            if (!isNumber)
            {
                Console.WriteLine("\nОшибка ввода. Введенное значение не явялется целым числом или выходит за пределы типа Int32");
                Console.WriteLine("Попробуйте еще раз.\n");
            }
            else
            {
                numPointer++;
                if (currentNumber % 2 == 0)
                {
                    checkValue += currentNumber;
                    if (checkValue <= Int32.MaxValue)
                    {
                        sumEven += currentNumber;
                        isEvenIn = true;
                    }
                    else
                    {
                        numPointer--;
                        Console.WriteLine("\nРезультат, полученный при сложении введенных чисел выходит за пределы Int32.\nВведите другое число.\n");
                        checkValue -= currentNumber;
                    }
                }
            }
        }
        Console.WriteLine((isEvenIn) ? $"\nСумма четных чисел в последовательности: {sumEven}" : "\nЧетных чисел в последовательности нет."); 
        Console.WriteLine("Программа завершена.");
    }
}
