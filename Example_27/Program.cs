// Задача 27.
Console.Write("Введите число: ");
 string str = Console.ReadLine();
 int num = int.Parse(str);
 int counter = 0;
 while(num! = 0)
 {
     num = num / 10;
     counter++;
 }
 Console.WriteLine(counter);
