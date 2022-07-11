/* Решение задачи №29

int[] Array (int size, int minRan, int maxRan)
{

    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minRan, maxRan);

    return newArray;    
}

void ShowArray (int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int CountNum (int [] array)
{   
    int c = 0;
    for(int i=0; i<array.Length; i++)
        if (array[i]%2==0)
            c++;
return c;
}


Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение числа для массива (положительное трёхзначное): ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение числа для массива (положительное трёхзначное): ");
int max = Convert.ToInt32(Console.ReadLine());

int[] ArrayRand = Array(size, min, max);
Console.Write("массив, заполненный случайными положительными трёхзначными числами: ");
ShowArray(ArrayRand);

int count = CountNum(ArrayRand);
Console.WriteLine("Количество четных чисел в массиве: " + count); */