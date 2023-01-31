//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их 
//на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Write("ввод массива a ");
int a= Convert.ToInt32(Console.ReadLine());
int[] arr = GetRandomArray(8);
PrintArray(arr);
int[] GetRandomArray(int Lenght)
{
int[] result = new int[Lenght];

    for (int i=0; i<Lenght; i++)
    {
        Console.Write(" ");
        result[i]=new Random().Next(1, 9);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach(int item in arr)
    
    {
        Console.Write(item + " ");
    }
}
