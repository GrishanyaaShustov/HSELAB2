namespace HSELAB2_1;

class Program
{
    static void Main(string[] args)
    {
        string currentEnter;
        int sumEven = 0;
        int numPointer = 0;
        int n;
        int currentNumber;
        bool isNumber; 
        
        Console.WriteLine("Данная программа считает сумму четных чисел в веденной вами последовательности.");
        
        do
        {
            Console.Write("Введите длину последовательности: ");
            currentEnter = Console.ReadLine();
            isNumber = Int32.TryParse(currentEnter, out n);

            if (!isNumber || n < 0)
            {
                Console.WriteLine("\nОшибка ввода. Введенное значение не явялется целым неотрицательным числом или выходит за пределы типа Int32");
                Console.WriteLine("Попробуйте еще раз\n");
            }
        }
        while (!isNumber || n < 0);

        while (numPointer != n) 
        {
            Console.Write($"Введите целое число №{numPointer+1}: ");
            currentEnter = Console.ReadLine();
            isNumber = Int32.TryParse(currentEnter, out currentNumber);
            
            if (!isNumber)
            {
                Console.WriteLine("\nОшибка ввода. Введенное значение не явялется целым числом или выходит за пределы типа Int32");
                Console.WriteLine("Попробуйте еще раз.\n");
            }
            else
            {
                numPointer++;
                if (currentNumber % 2 == 0) sumEven += currentNumber;  
            }
        }
        Console.WriteLine($"\nСумма четных чисел в последовательности: {sumEven}"); 
        Console.WriteLine("Программа завершена.");
    }
}
