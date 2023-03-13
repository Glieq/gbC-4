// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Promt("Введите число: ");

int SumOfNumbers(int A)
{
    int count = 0;
    int sum = 0;
    while (A > count)
    {
        sum += A % 10;
        A /= 10;
    }
    return sum;
}

System.Console.WriteLine($"Сумма чисел {number} равна {SumOfNumbers(number)}");