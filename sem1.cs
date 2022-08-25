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
  
  public static void Task7() 
  {
    Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");
        
    Console.Write("Введите целое трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string line  = num.ToString();
    char[] ch = line.ToCharArray();
    
    Console.WriteLine($"Out: {ch[ch.Length - 1]}");
  }
  
  public static void Task2() 
  {
    Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее..");
        
    Console.Write("Введите 1-ое число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Введите 2-ое число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    if (num1 > num2)
        Console.WriteLine($"1-ое число {num1} больше 2-го числа {num2}");
    else
    {
        if (num1 == num2)
            Console.WriteLine($"1-ое число {num1} равно 2-ому числу {num2}");
        else Console.WriteLine($"2-ое число {num2} больше 1-го числа {num1}");
    } 
  }
  
  public static void Task4() 
  {
    Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
        
    Console.Write("Введите 1-ое число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Введите 2-ое число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Введите 3-е число: ");
    double num3 = Convert.ToDouble(Console.ReadLine());

    if (num1 > num2)
        if (num1 > num3) Console.WriteLine($"1-ое число {num1} больше 2-го числа {num2} и 3-го числа {num3}");
        else
        {
            if (num1 == num3) Console.WriteLine($"1-ое число {num1} больше 2-го числа {num2}, но равно 3-му числу {num3}");
            else Console.WriteLine($"3-ое число {num3} больше 2-го числа {num2} и 1-го числа {num1}");
        }
    else
    {
        if (num1 == num2)
        {
            if (num2 > num3) Console.WriteLine($"2-ое число {num1} больше 3-го числа {num3} и равно 1-му числу {num1}");
            else
            {
                if (num2 == num3) Console.WriteLine($"1-ое число {num1} равно 2-му числу {num2} и равно 3-му числу {num3}");
                else Console.WriteLine($"3-ое число {num3} больше 2-го числа {num2} и 1-го числа {num1}");
            }
        }
        else{
            if (num2 > num3) Console.WriteLine($"2-ое число {num2} больше 1-го числа {num1} и 3-го числа {num3}");
            else
            {
                if (num1 == num3) Console.WriteLine($"2-ое число {num2} больше 1-го числа {num1}, но равно 3-му числу {num3}");
                else Console.WriteLine($"3-ое число {num3} больше 2-го числа {num2} и 1-го числа {num1}");
            }
        }
    } 
  }    
  
}
