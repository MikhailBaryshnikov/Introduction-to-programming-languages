using System;

class Task {
    
  static void Main() 
  {
    Task60();
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
  
  public static void OrderArrayLines(double[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    double temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
  }
  
  public static void Task54() 
  {
    Console.WriteLine(" Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
       
    Console.WriteLine("введите количество строк");
    int linesVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columnsVol = Convert.ToInt32(Console.ReadLine());
    
    double[,] numbers = new double[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    
    Console.WriteLine($"\nОтсортированный массив: ");
    OrderArrayLines(numbers);
    PrintArray(numbers);

  }
  
  public static double SumLineElements(double[,] array, int i)
  {
    double sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
  }   

  
  public static void Task56() 
  {
    Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
       
    Console.WriteLine("введите количество строк");
    int linesVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columnsVol = Convert.ToInt32(Console.ReadLine());
    
    double[,] numbers = new double[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

    int minSumLine = 0;
    double sumLine = SumLineElements(numbers, 0);
    for (int i = 1; i < numbers.GetLength(0); i++)
    {
        double tempSumLine = SumLineElements(numbers, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }

    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");    

  }
  
  public static void MultiplyMatrix(double[,] firstMartrix, double[,] secomdMartrix, double[,] resultMatrix)
  {
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            double sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i,k] * secomdMartrix[k,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
  }

  public static int InputNumbers(string input)
  {
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
  }
  
  public static void Task58() 
  {
    Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    
    Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
    int m = InputNumbers("Введите число строк 1-й матрицы: ");
    int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
    int p = InputNumbers("Введите число столбцов 2-й матрицы: ");

    double[,] firstMartrix = new double[m, n];
    FillArrayRandomNumbers(firstMartrix);
    Console.WriteLine($"\nПервая матрица:");
    PrintArray(firstMartrix);

    double[,] secomdMartrix = new double[n, p];
    FillArrayRandomNumbers(secomdMartrix);
    Console.WriteLine($"\nВторая матрица:");
    PrintArray(secomdMartrix);
    
    double[,] resultMatrix = new double[m,p];

    MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
    Console.WriteLine($"\nПроизведение первой и второй матриц:");
    PrintArray(resultMatrix);
    
  }
  
  public static void PrintArray (int[,,] array3D)
  {
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write( $"({i},{j},{k}) = {array3D[i,j,k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
  }
  
  public static void CreateArray_numDim2_nonrep(int[,,] array3D)
  {
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int  number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0; 
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
  }
   
  public static void Task60() 
  {
    Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2");
    
    Console.WriteLine($"\nВведите размер массива X x Y x Z:");
    int x = InputNumbers("Введите X: ");
    int y = InputNumbers("Введите Y: ");
    int z = InputNumbers("Введите Z: ");
    Console.WriteLine($"");
    
    if(x*y*z >= 100) Console.WriteLine("Невозможно создать массив такого размера из неповторяющихся двузначных чисел");
    else{
        int[,,] array3D = new int[x, y, z];
        CreateArray_numDim2_nonrep(array3D);
        PrintArray(array3D);
    }

  }   
    
  public static void FillArraySpiral4x4(int[,] array)
  {
    int n = array.GetLength(0);  
      
    int i = 0;
    int j = 0;
    int value = 0;  
    array[i,j] = value;
    while (n != 2)
    {   
        int count = 0;
        if(n == 3) count = 1;
        
        for (int k = 0; k < n - 1; k++ ){
            j = j + 1;
            value = value + 1;
            array[i,j] = value;
            Console.WriteLine($"\narr[{i},{j}] = {array[i,j]};");
        }
        for (int k = 0; k < n - 1 - count; k++ ){
            i = i + 1;
            value = value + 1;
            array[i,j] = value;
            Console.WriteLine($"\narr[{i},{j}] = {array[i,j]};");
        } 
        for (int k = 0; k < n - 1 - count; k++ ) {
            j = j - 1;
            value = value + 1;
            array[i,j] = value;
            Console.WriteLine($"\narr[{i},{j}] = {array[i,j]};");
        }
        for (int k = 1; k < n - 1- count; k++ ) {
            i = i - 1;
            value = value + 1;
            array[i,j] = value;
            Console.WriteLine($"\narr[{i},{j}] = {array[i,j]};");
        }
        n = n - 1;
    }
  }
  
  public static void Task62() 
  {
    Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4. ");
    
    int x = 4;
    int y = 4;
    
    int[,] arr= new int[x, y];
    FillArraySpiral4x4(arr);
    Console.WriteLine("\nSpiral array:");
    PrintArray(arr);
    
  }  
  
}
