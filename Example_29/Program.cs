// Задача 29: Написать программу вычисления чисел от 1 до N.
/*Console.Write("Введите число 1: ");
int n = int.Parse(Console.ReadLine());
int m = 1;
for(int i = 1; i <= n; i++)
{
    m = m * i;
}
Console.WriteLine(m);*/


int Factorial(int num)
{
  int m = 1;
  for(int i = 1; i <= num; i++)
  {
     m = m * i;
  }
return m;
}
Console.Write("Введите число 1: ");
int n = int.Parse(Console.ReadLine());
int f = Factorial(n);
Console.Write(f); 