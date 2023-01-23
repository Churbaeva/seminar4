// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
System.Console.WriteLine("ввод числа");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"num = {num}");

for( int i = 1; i <= num; i++)
{
    double result = (Math.Pow( i, 3));
    System.Console.WriteLine(result);
}