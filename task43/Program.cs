/*
программа найдёт точку пересечения двух прямых,
 заданных уравнениями 
 y = k1 * x + b1, 
 y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

double[] FillArray(int num)
{
    double[] arr = new double[num];

    for (int index = 0, count = 0; index < arr.Length; index++)
    {
        if (index % 2 == 0)
        {
            Console.WriteLine("Введите число b" + (count + 1));
            arr[index] = double.Parse(Console.ReadLine());
            count++;
        }
        else
        {
            Console.WriteLine("Введите число k" + (count));
            arr[index] = double.Parse(Console.ReadLine());
        }

    }
    return arr;
}

int size = 4;

double[] Array = FillArray(size);
Console.WriteLine("Массив {0}", String.Join(" ", Array));



double x= (Array[2]-Array[0])/(Array[1]-Array[3]);
double y = Array[1] * x + Array[0];


Console.WriteLine("(" + x + ", " + y + " )");
