
using System;

class Task {
    
  static void Main() 
  {
    Task36();
  }
  
  public static void FillArray(int[] array, int min, int max){
    for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
    }
  }

  public static void PrintArray(int[] coll){
    int index = 0;
    Console.Write("[");
    while(index < coll.Length){
        Console.Write(coll[index]);
        index++;
        if (index < coll.Length){
            Console.Write(", ");
        }
    }
    Console.Write("]");
  }
 
  public static void PrintArray(double[] coll){
    int index = 0;
    Console.Write("[");
    while(index < coll.Length){
        Console.Write(coll[index]);
        index++;
        if (index < coll.Length){
            Console.Write(", ");
        }
    }
    Console.Write("]");
  } 

  public static int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
  }
  
  public static void Task34() 
  {
    Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
       
    int[] numbers = new int[10];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    Console.WriteLine();
    
    Console.WriteLine($"Количество чётных чисел в массиве: {QuantityPositive(numbers)}");

  }
  
  public static void Task35() 
  {
    Console.WriteLine("Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. ");
    
    int[] numbers = new int[123];
    FillArray(numbers, -100, 101);
    PrintArray(numbers);
    
    int num_10_99 = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] >= 10 && numbers[i] <= 99) num_10_99 = num_10_99 + 1;
    }
    
    Console.WriteLine($"Количество чисел в интервале [10; 99] в массиве: {num_10_99}");
    
  }
  
  public static int sum_elem_odd_pos(int [] numbers)
  {
    int sumElements = 0;

    for (int i = 0; i < numbers.Length; i++ ){
      if (i % 2 != 0)
      {
        sumElements = sumElements + numbers[i];
      }
    }
    return sumElements;
  }
  
  public static void Task36() 
  {
    Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    
    Console.Write($"Введи количество элементов массива: ");
    int numberElements = Convert.ToInt32(Console.ReadLine()); 
    int[] numbers = new int[numberElements];
    FillArray(numbers, 1, 11);
    PrintArray(numbers);
    
    int randomNumbers =  sum_elem_odd_pos(numbers);
    Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях(нумерация элементов массива идет с 0): {randomNumbers}");
  }
  
  public static void Task38() 
  {
    Console.WriteLine("Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    
    Console.Write($"Введи количество элементов массива: ");
    int numberElements = Convert.ToInt32(Console.ReadLine()); 
    double[] numbers = new double[numberElements];
    
    for(int i = 0; i < numberElements; i ++){
        Console.WriteLine($"Введите {i+1}-ое число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        numbers[i] = number;
    }
    
    PrintArray(numbers);
    
    double maxNumber = numbers[0];
    double minNumber = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (maxNumber < numbers[i])
        {
            maxNumber = numbers[i];
        }
        if (minNumber > numbers[i])
        {
            minNumber = numbers[i];
        }
    }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
  }
}
