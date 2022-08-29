using System;

class Task {
    
  static void Main() 
  {
    Task23();
  }
  
  public static void Task19() 
  {
    Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
       
    Console.Write("Введите целое положительное 5-значное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string line  = num.ToString();
    //Console.WriteLine($"line.Length: {line.Length};");
    while(num < 0 || line.Length != 5) {
        Console.Write("Целое положительное 5-значное число: ");
        num = Convert.ToInt32(Console.ReadLine());
        line  = num.ToString();
    }
    if(line[0] == line[4] && line[1] == line[3]) {
        Console.Write($"Число: {num} является палиндромом.");
    }
    else Console.Write($"Число: {num} не является палиндромом.");
  }

  public static int Coordinate(string coorName, string pointName)
    {
        Console.Write($"Введите координату {coorName} точки {pointName}: ");
        return Convert.ToInt16(Console.ReadLine());
    } 
    
  public static double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
    {
        return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    }
    
  public static void Task21() 
  {
 
    Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    double x1 = Coordinate("x", "A");
    double y1 = Coordinate("y", "A");
    double z1 = Coordinate("z", "A");
    
    double x2 = Coordinate("x", "B");
    double y2 = Coordinate("y", "B");
    double z2 = Coordinate("z", "B");

    double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
    
    Console.WriteLine($"Длина отрезка  {segmentLength}");   
  }
    
    
  public static void Cube(int[] cube){
    int counter = 1;
    int length = cube.Length + 1;
    while (counter <  length){
        cube[counter - 1] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
  }
  
  public static void PrintArry(int[] coll){
    int count = coll.Length;
    int index = 0;
    while(index < count){
        Console.Write(coll[index]+ " ");
        index++;
    }
  }
  
  public static void Task23() 
  {
    Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    
    Console.Write("Введите целое положительное число: ");
    int cube = Convert.ToInt32(Console.ReadLine());
    while(cube < 0 ) {
        Console.Write("Целое положительное число: ");
        cube = Convert.ToInt32(Console.ReadLine());
    }

    int[] arry = new int[cube];
    Cube(arry);
    PrintArry(arry);

  }
}
