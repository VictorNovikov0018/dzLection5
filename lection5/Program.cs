// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] FillArray(int size, int min, int max)
// {
    // int[]arr = new int[size];
    // Random rand =new Random();
    // for (int i = 0; i< size; i++)
    // {
        
        // arr[i] = rand.Next(min,max + 1);
    // }

    // return arr;
// }

// int SumTo(int[] arr)
// {
    // int sum = 0;
    // for (int i = 0; i < arr.Length; i++)
    // {
        // if(arr[i] % 2 == 0)
        // {
            // sum ++;
        // }
    // }
    // return sum;
// }

// void PrintArray( int [] arr){

    // for (int i = 0; i < arr.Length; i++)
    // {
    //    Console.Write($" {arr[i]} "); 
    // }
// }

// int[] arr = FillArray(6, 100, 1000);
// PrintArray(arr);
// Console.WriteLine();
// int sumTo = SumTo(arr);
// Console.WriteLine($"Сумма отрицательных элементов массива = {sumTo}");

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] FillArray(int size, int min, int max)
// {
    // int[]arr = new int[size];
    // Random rand =new Random();
    // for (int i = 0; i< size; i++)
    // {
        
        // arr[i] = rand.Next(min,max + 1);
    // }

    // return arr;
// }

// int SumPosition(int [] arr)
// {
    // int sum = 0;
    // for (int i = 1; i < arr.Length; i+=2)
    // {
        // sum += arr[i];
    // }
    // return sum;
// }

// void PrintArray( int [] arr){

    // for (int i = 0; i < arr.Length; i++)
    // {
    //    Console.Write($" {arr[i]} "); 
    // }
// }

// int[] arr = FillArray(8,-20,20);
// PrintArray(arr);
// Console.WriteLine();
// int SumPos = SumPosition(arr);
// Console.WriteLine($"Сумма отрицательных элементов массива = {SumPos}");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// int size = 10;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int max = numbers[0];
// int min = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
    // if (numbers[i] > max)
    // {
        // max = numbers[i];
    // }
    // else if (numbers[i] < min)
    // {
        // min = numbers[i];
    // }
// }

// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



// void FillArrayRandomNumbers(int[] array)
// {
    // for (int i = 0; i < array.Length; i++)
    // {
        // array[i] = new Random().Next(1, 555);
    // }
// }


// void PrintArray(int[] array)
// {
    // for (int i = 0; i < array.Length; i++)
    // {
        // Console.Write(array[i] + " ");
    // }
    // Console.WriteLine();
// }
