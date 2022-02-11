// Задача 25: Найти сумму чисел от 1 до А.
/*Console.WriteLine("Ввести число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Ввести число: 1");
int numA = 1;
int result = 0;
while(numA <= num )
{
    result = result + numA;
    numA++;
}
Console.WriteLine("Сумма " + result);*/

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Число: ");
int B = 0;
for(int i = 1; i <= A; i++)
{
    B = B + i;
}
Console.Write(B);
