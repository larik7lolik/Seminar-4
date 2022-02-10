// Задача 31. Нужно создать массив из восьми элементов и вывести на экран
/*int [] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
Console.WriteLine(array);
int num = 0;
while(num < array.Length)
{
    Console.Write(array[num]);
    num++;
}*/

void Print(int[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i]);
    }
}

int [] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
Print(array);

