// Задача 47  
// Задайте двумерный массив размером m x n , заполненный случайными вещественными числами.  
  
// m = 3, n = 4.  
// 0,5    7       -2     -0,2   
// 1    -3,3      8      -9,9  
// 8     7,8     -7,1       9  
  
Console.Write("Введите число m: ");  
int m = Convert.ToInt32(Console.ReadLine());  
  
Console.Write("Введите число n: ");  
int n = Convert.ToInt32(Console.ReadLine());  
  
Console.Clear();  
Console.WriteLine($"m = {m}, n = {n}.");  
  
double[,] arrey = new double[m, n];  
  
void CreateArrayDouble(double[,] arrey)  
{  
    for(int i = 0; i < m; i++)  
    {  
        for(int j = 0; j < n; j++)  
        {  
            arrey[i, j] = new Random().NextDouble() * 20 - 10;  
        }  
    }  
}  
  
void PrintArray(double[,] arrey)  
{  
    for(int i = 0; i < m; i++)  
    {  
        for (int j = 0; j < n; j++)  
        {  
          double number = Math.Round(arrey[i, j], 1);  
          Console.Write(number + "   ");  
        }  
        Console.WriteLine();  
    }  
}  
 
Console.WriteLine(); 
  
CreateArrayDouble(arrey);  
  
PrintArray(arrey);