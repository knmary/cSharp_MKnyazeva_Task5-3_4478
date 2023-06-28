//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArr = new double[a];

void massive(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArr[i] = rand.NextDouble();
        Console.Write(Math.Round(randomArr[i], 2) + "  ");
    }
}

double func(double [] randomArr)
{
    double min = randomArr[0];
    double max = randomArr[0];
    for (int i = 0; i < randomArr.Length; i++)
    {
        if (max < randomArr[i])
        max = randomArr[i];
        if (min > randomArr[i])
        min = randomArr[i];
    }
    Console.Write(" => " + Math.Round(max, 2) + " - " + Math.Round(min, 2)+ " = ");
    return max - min;
}

massive(a);
double result = func(randomArr);
Console.Write(Math.Round(result, 2));