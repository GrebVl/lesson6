/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int[] FillArray(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число №" + (i + 1));
        arr[i] = int.Parse(Console.ReadLine());

    }
    return arr;
}

Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
int[] UserArray = FillArray(size);
Console.WriteLine();
Console.WriteLine("Массив : {0}", String.Join(" ", UserArray));

int count = 0;

for(int i=0; i < UserArray.Length; i++)
{
    if (UserArray[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество положительных чисел: " + count);
