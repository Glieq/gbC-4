// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33-> [6, 1, 33]

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int lengthOfArr = Promt("Введите длинну массива: ");
int minValue = Promt("Введите минимальное значение диапазона чисел: ");
int maxValue = Promt("Введите максимальное значение диапазона чисел: ");

int[] generateArray(int length, int minRandValue, int maxRandValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minRandValue, maxRandValue + 1);
    }
    return array;
}

int[] array = generateArray(lengthOfArr + 1, minValue, maxValue);
System.Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
    System.Console.Write($"{array[i]},");
}
System.Console.Write("];");