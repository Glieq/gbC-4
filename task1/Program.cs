// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int numerator = Promt("Введите числитель A: ");
int index = Promt("Введите показатель B: ");

if (index < 0)
{
    System.Console.WriteLine("Показатель не должен быть меньше нуля");
    return;
}

int MathOperation(int A, int B)
{
    int proizv = 1;
    for (int i = 0; i < B; i++)
    {
        proizv *= A;
    }
    return proizv;
}

System.Console.WriteLine($"Число {numerator} в степени {index} равно {MathOperation(numerator, index)}");