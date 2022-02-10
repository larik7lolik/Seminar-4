// 
Console.WriteLine("Ввести число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Ввести число: 1");
int numA = 1;
int result = 0;
while(numA <= num )
{
    result = result + numA;
    numA++;
}
Console.WriteLine("Сумма " + result);



