using System;

class Task {
    
  static void Main() 
  {
    Task68();
  }
  
  public static void PrintNumber(int n, int count)
  {
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
  }
  
  public static double InputNumbers(string input) 
  {
    Console.Write(input);
    double output = Convert.ToDouble(Console.ReadLine());
    return output;
  }
  
  public static void Task64() 
  {
    Console.WriteLine(" Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
    
    int n = (int)InputNumbers("Введите n: ");
    if(n>1)
    {
        int count = 2;
        PrintNumber(n, count);
        Console.Write(1);
    }
  }
  
  public static void Task66() 
  {
    Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N включительно.");
 
    int m = (int)InputNumbers("Введите m: ");   
    int n = (int)InputNumbers("Введите n: ");
    
    if(n>1 && m > 1)
    {
        for(int i = m; i < n + 1; i++) Console.Write($"{i}, ");
        
    }
  }
  
  public static int Ack(int m, int n)
  {
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
  }

  
  public static void Task68() 
  {
    Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
 
    int m = (int)InputNumbers("Введите m: ");
    int n = (int)InputNumbers("Введите n: ");

    int functionAkkerman = 0;
    if(m >=0 && n >= 0) functionAkkerman = Ack(m, n);

    Console.Write($"Функция Аккермана = {functionAkkerman} ");

  }
}
