// Задача 29
/*Console.Write21("Введите число 1: ");
int n = int.Parse(Console.ReadLine());
int m = 1;
for(int i = 1; i <= n; i++)
{
    m = n * i;
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