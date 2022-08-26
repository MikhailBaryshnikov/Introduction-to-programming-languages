using System;

class Task {
    
  static void Main() 
  {
    Task15();
  }
  
  public static void Task10() 
  {
    Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
       
    Console.Write("Введите целое трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string line  = num.ToString();
    if (line.Length == 3){
        Console.WriteLine("Вторая цифра этого числа -> "+ line[1]);
    }
    else {
        Console.WriteLine("Число не 3-х значное");
    }
  }
  public static void Task13() 
  {
    Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
       
    Console.Write("Введите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string line  = num.ToString();
    if (line.Length > 2){
        Console.WriteLine("Третья цифра -> " + line[2]);
    }
    else {
        Console.WriteLine("-> третьей цифры нет");
    }
  }
    public static void Task15() 
  {
    Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    
    Console.Write("Введи цифру, обозначающую день недели: ");
    int dayNumber = Convert.ToInt32(Console.ReadLine());

    if (dayNumber == 6 || dayNumber == 7) {
        Console.WriteLine("(этот день выходной?) -> да");
    }
    else if (dayNumber < 1 || dayNumber > 7) {
        Console.WriteLine("это вообще не день недели");
    }
    else Console.WriteLine("(этот день выходной?) -> нет");
  }
}
