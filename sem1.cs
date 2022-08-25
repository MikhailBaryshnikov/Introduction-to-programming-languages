using System;
using System.Collections.Generic;
class Task {
    
  static void Main() 
  {
    Task5();
  }
  
  public static void Task1() 
  {
    Console.WriteLine("Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго");
    Console.Write("Введите 1-ое число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Введите 2-ое число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    if (num1*num1 == num2)
        Console.WriteLine($"1-ое число {num1} в квадрате равно 2-ому числу {num2}");
    else
    {
        Console.WriteLine($"1-ое число {num1} в квадрате не равно 2-ому числу {num2}");
    } 
  }
  
  public static void Task3() 
  {
    Console.WriteLine("Напишите программу, которая будет выдавать название дня недели по заданному номеру.");
    
    var d_of_w = new Dictionary<int, string>()
    {
        { 1, "Mon"},
        { 2, "Tue"},
        { 3, "Wen"},
        { 4, "Thu"},
        { 5, "Fri"},
        { 6, "Sat"},
        { 7, "Sun"}
    };
    
    Console.Write("Введите число int в интервале [1,7]: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    if(num < 1 || num > 7)
    {   
        Console.WriteLine("There is no such day of the week");
    }
    else
    {
        foreach(var day in d_of_w)
        {
            if(day.Key == num) Console.WriteLine($"day: {day.Key}  day of week: {day.Value}");
        }
    }
  }
  
  public static void Task5() 
  {
    Console.WriteLine("Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.");
        
    Console.Write("Введите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());  
    
    string a ="";
    
    for(int i = -num; i < num + 1; i++)
    {
        a = a + i.ToString() + ", ";
    }       
    
    Console.WriteLine($"Out: {a}");
  }
  
}
