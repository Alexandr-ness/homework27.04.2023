/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введено число " + a);
// int b = a;
// int c = 0;
// while(a > 0)
// {
//     int d = a % 10;
//     c = c * 10 + d;
//     a = a / 10;    
// }

// if(b == c)
// {
//     Console.Write(c + " это палиндром");
// }
// else
// {
//     Console.Write(c + " это не палиндром");
// }






/*
Напишите программу, которая принимает на вход координаты двух
 точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
 
int x1, y1, z1, x2, y2, z2, a, b, c; 
Console.Write("Введите координату x1 - ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 - ");
y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1 - ");
z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2 - ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 - ");
y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2 - ");
z2 = Convert.ToInt32(Console.ReadLine());

a = x2 - x1;
b = y2 - y1;
c = z1 - z2;

double total = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine($"Расстояние {total}");





// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.Write("Введите число N - ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Таблица кубов - ");
// for (int a=1;a<=n;a++)
// {
// int b = a*a*a;
// Console.Write($"{b}, ");
// }

