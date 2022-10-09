// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int[] a = {0, 0, 0};
int[] b = {0, 0, 0};
Console.WriteLine("Введите координату X точки A");
int.TryParse(Console.ReadLine(), out a[0]);
Console.WriteLine("Введите координату Y точки A");
int.TryParse(Console.ReadLine(), out a[1]);
Console.WriteLine("Введите координату Z точки A");
int.TryParse(Console.ReadLine(), out a[2]);
Console.WriteLine("Введите координату X точки B");
int.TryParse(Console.ReadLine(), out b[0]);
Console.WriteLine("Введите координату Y точки B");
int.TryParse(Console.ReadLine(), out b[1]);
Console.WriteLine("Введите координату Z точки B");
int.TryParse(Console.ReadLine(), out b[2]);
double i = Math.Sqrt((a[0]-b[0])*(a[0]-b[0])+(a[1]-b[1])*(a[1]-b[1])+(a[2]-b[2])*(a[2]-b[2]));
i = Math.Round(i, 2);
Console.WriteLine($"Расстояние между точками: {i}");