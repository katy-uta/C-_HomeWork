/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/ 

Console.WriteLine("Введите число"); 
string A = Console.ReadLine(); 
int numberA = int.Parse(A);

if (numberA % 2 == 0)
{
    Console.WriteLine("Введенное число является четным (делится на 2 без остатка)");
}
else
{
Console.WriteLine("Введенное число не является четным (не делится на 2 без остатка)");
} 

