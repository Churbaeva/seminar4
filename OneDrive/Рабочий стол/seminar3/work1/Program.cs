//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

string a= string.Empty;
Console.WriteLine("введите число");
a = Console.ReadLine();
char[]temp = a.ToCharArray();
Array.Reverse(temp);
string b = new string(temp);

if (a.ToLower().Equals(b.ToLower()))
{
System.Console.WriteLine("yes");
}
else 
{
    System.Console.WriteLine("no");
} 