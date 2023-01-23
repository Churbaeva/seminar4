// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
System.Console.WriteLine("ввод координат точек");
Console.Write("ввод координаты x1");
int x1= Convert.ToInt32(Console.ReadLine());

Console.Write("ввод координаты y1");
int y1= Convert.ToInt32(Console.ReadLine());

Console.Write("ввод координаты z1");
int z1= Convert.ToInt32(Console.ReadLine());

Console.Write("ввод координаты x2");
int x2= Convert.ToInt32(Console.ReadLine());

Console.Write("ввод координаты y2");
int y2= Convert.ToInt32(Console.ReadLine());

Console.Write("ввод координаты z2");
int z2= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"x1 {x1},y1 {y1}, z1 {z1}, x2 {x2}, y2 {y2}, z2 {z2}");

double result = Math.Sqrt((Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2)) + Math.Pow((z1-z2), 2));

System.Console.WriteLine(result);