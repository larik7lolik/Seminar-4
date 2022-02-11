// Задача 27: Определить количество цифр в числе.
Console.Write("Введите число: ");
 string str = Console.ReadLine();
 int num = int.Parse(str);
 //Console.WriteLine(str.Length);
 int counter = 0;
 while(num!= 0)
 {
     num = num / 10;
     counter++;
 }
 Console.WriteLine(counter);
