using System;

class Task {
    
  static void Main() 
  {
    Task52();
  }
  
  public static void FillArrayRandomNumbers(double[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
  }  
  
  public static void PrintArray(double[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "; ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
  }
  
  public static void FillArrayRandomNumbers(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(-100, 100);
        }
    }
  }  
  
  public static void PrintArray(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "; ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
  }
  
  public static void Task47() 
  {
    Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
       
    Console.WriteLine("введите количество строк");
    int linesVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columnsVol = Convert.ToInt32(Console.ReadLine());
    
    double[,] numbers = new double[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

  }
  
  public static void Task50() 
  {
    Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
       
    Console.WriteLine("Введите номер строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int n_true = new Random().Next(1, 11);
    int m_true = new Random().Next(1, 11);
    int [,] numbers = new int [n_true, m_true];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    
    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
    }
  }
  
  public static void Task52() 
  {
    Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
       
    Console.WriteLine("Введите количество строк");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[n, m];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine();
    PrintArray(numbers);
    
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            avarage = (avarage + numbers[i, j]);
        }
        avarage = avarage / n;
        Console.Write(avarage + "; ");
    }
    Console.WriteLine();
  }
}
