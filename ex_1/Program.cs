﻿//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "4, 2"
//N = 8 -> "8, 6, 4, 2"
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
string Num(int a)
{
 if( a == 0 ) return " ";
 else if( a % 2 == 0) return $"{Num(a-1) + a} \b ";
 else return Num(a-1);
}
Console.Write(Num(a)); 