//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int NaturalNumSum(int n, int a)
{
 if( n == a ) return a; 
 else return n + NaturalNumSum((n - 1), a);
}
Console.WriteLine(NaturalNumSum(b, a));

// 8 -- 8 +  7  +  6  +  5  +  4   -- 4
// b -- b + b-1 + b-1 + b-1 + b-1  -- a