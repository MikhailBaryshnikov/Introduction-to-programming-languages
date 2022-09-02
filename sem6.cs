using System;

class Task {
    
  static void Main() 
  {
    Task45();
  }
  
  public static void FillArray(int[] array, int min, int max){
    for (int i = 0; i<array.Length; i++ ){
        array[i] = new Random().Next(min, max);
    }
  }
  
  public static void UserFillArray(double[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i}-ое число: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
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
  
  public static int Comparison(double[] massiveNumbers)
  {
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if(massiveNumbers[i] > 0 ) count += 1; 
    }
    return count;
  }

  public static void Task41() 
  {
    Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
       
    Console.Write($"Введите число М(количество чисел): ");
    int m = Convert.ToInt32(Console.ReadLine());
    double[] massiveNumbers = new double[m];
    
    UserFillArray(massiveNumbers);
    
    Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");

  }
  
  public static void InputCoefficients(double[,] coeff){
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if(j==0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
                coeff[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
  }

  public static double[] Decision(double[,] coeff, double[] crossPoint){
    crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
    crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
    return crossPoint;
  }

  public static void OutputResponse(double[,] coeff, double[] crossPoint){
    if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
    {
        Console.Write($"\nПрямые параллельны");
    }
    else 
    {
        Decision(coeff, crossPoint);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
  }
  
  public static void Task43() 
  {
    Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");

    double[,] coeff = new double[2, 2];
    double[] crossPoint = new double[2];
    
    InputCoefficients(coeff);
    OutputResponse(coeff, crossPoint);
    
  }
  
  public static int[] Fibonacci_Numbers(int N)
  {
      int [] Fib = new int[N];
      if(N == 1) {
          Fib[N - 1] = 0;
          return Fib;
      }
      if(N == 2) {
          Fib[N-2] = 0;
          Fib[N - 1] = 1;
          return Fib;
      }
      Fib[0] = 0;
      Fib[1] = 1;
      for(int i = 2; i < N; i++) Fib[i] = Fib[i-1] + Fib[i-2];
      return Fib;
  }

  public static void Task44() 
  {
    Console.WriteLine("Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.");
    
    Console.Write($"Введите количество чисел Фибоначчи: ");
    int num = Convert.ToInt32(Console.ReadLine()); 
    if(num == 0) Console.WriteLine("0 чисел Фибоначчи");
    else {
        PrintArray(Fibonacci_Numbers(num));
    }
  }

  public static int[]  copy_arr(int[] arr){
    
    int[] num = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++){
        num[i] = arr[i];
    }
    return num;
  }

  public static void Task45() 
  {
    Console.WriteLine("Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.");
    
    Console.Write($"\nCлучайный массив.");
    int size_arr = new Random().Next(1, 21);
    int[] numbers1 = new int[size_arr];
    FillArray(numbers1, -10, 10);
    PrintArray(numbers1);
    
    Console.Write($"\nКопия массива.");
    int[] num = copy_arr(numbers1);
    PrintArray(num);
  }
}
