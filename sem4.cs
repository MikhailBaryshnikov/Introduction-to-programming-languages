using System;

class Task {
    
  static void Main() 
  {
    Task29();
  }
  
  public static int Exponentiation(int numberA, int numberB){
    int result = 1;
    for(int i=1; i <= numberB; i++){
        result = result * numberA;
    }
    return result;
  }

  public static void Task25() 
  {
    Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. ");
       
    Console.Write("Введите число A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

    int exponentiation = Exponentiation(numberA, numberB);
    Console.WriteLine("Ответ: " + exponentiation);

  }
  
  public static int SumNumber(int numberN){

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
  }
  
  public static void Task27() 
  {
    Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
    
    int numberN = Convert.ToInt32(Console.ReadLine());

    int sumNumber = SumNumber(numberN);
    Console.WriteLine("Сумма цифр в числе равна:" + sumNumber );
  }
  
  public static void PrintArry(double [] coll){
    int count = coll.Length;
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
  
  public static void Task29() 
  {
    Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
    
    int digit = 8;
    
    double[] array = new double[digit];
    
    for(int i = 0; i < digit; i ++){
        Console.WriteLine($"Введите {i+1}-ое число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        array[i] = number;
    }
    Console.WriteLine("\nВыводим массив. \n ");
    PrintArry(array);

  }
}
