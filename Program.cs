//    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//    Напишите программу, которая покажет количество чётных чисел в массиве.
//    [345, 897, 568, 234] -> 2

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];

// void FindArrayNum(int[] num)
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray(int[] num)
// {    
//     for(int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }    
//     Console.WriteLine();
// }

// FindArrayNum(num);
// PrintArray(num);
// int count = 0;
// for (int k = 0; k < num.Length; k++)
// if (num[k] % 2 == 0) count++;
// Console.WriteLine($"Количество четных чисел в массиве: {count} ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];

// void FindArrayNum(int[] num)
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(1, 9);
//     }
// }

// void PrintArray(int[] num)
// {    
//     for(int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }    
//     Console.WriteLine();
// }


// FindArrayNum(num);
// PrintArray(num);
// int sum = 0;
// for (int k = 0; k < num.Length; k+=2)
//     sum = sum + num[k];
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum} ");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] num = new double[length];

double min_value = Int32.MaxValue;
double max_value = Int32.MinValue;
FindArrayNum(num);
PrintArray(num);

for (int k = 0; k < num.Length; k++)
{
    if (num[k] > max_value)
        {
            max_value = num[k];
        }
    if (num[k] < min_value)
        {
            min_value = num[k];
        }
}

void FindArrayNum(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,10000))/100;
        }
}

void PrintArray(double[] num)
{    
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }    
    Console.WriteLine();
}

Console.WriteLine($"max элемент массива: {max_value}");
Console.WriteLine($"min элемент массива: {min_value}");
Console.WriteLine($"Разница составляет: {Convert.ToDouble((max_value - min_value))}");