void Zadacha25()
{
    /*Задача 25: Используя определение степени числа, напишите цикл, 
    который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    */

    Console.Write("Введите число от 1 до 10: ");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите второе число от 1 до 10: ");
    int numB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result *= numA;
    }
    Console.WriteLine($"{numA} в {numB} степени = {result}");
}

void Zadacha27()
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    Console.Write("Введите любое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int ost = 10;
    int summ = 0;
    Console.Write($"Суммва цифр числа {num} = ");
    while (num > 0)
    {
        summ += num % ost;
        num /= 10;
    }
    Console.WriteLine($"{summ}");
}

void ArrPtint(int[] array)
{
    Console.Write("Массив: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine($"]");
}


void Zadacha29()
{
    int size = 8;
    int[] arr = new int[size];
    Random digit = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = digit.Next(-99, 100);
    } 
    ArrPtint(arr);

    for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (Math.Abs(arr[j]) > Math.Abs(arr[j + 1]))
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    ArrPtint(arr);
}


//Zadacha25();
//Zadacha27();
//Zadacha29();
