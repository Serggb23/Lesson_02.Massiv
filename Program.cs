﻿// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

    int[] array = new int[10];
    Random nums = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = nums.Next(1, 100);
        Console.Write("| " + array[i] + " ");
    }
    Console.WriteLine ("|");
    
    for (int i= 0; i < array.Length; i++)
        if (array[i] >=20 && array[i] <=90)
        {
            Console.Write("| " + array[i] + " ");
        }
    Console.WriteLine("|");
    Console.ReadLine();