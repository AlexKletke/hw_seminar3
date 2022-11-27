// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
using static System.Console;
WriteLine("enter integer: ");
int Number = int.Parse(ReadLine());
for(int i =1; i <= Number; i++)
{
    WriteLine($"{i} * {i} * {i} = {i*i*i}");
}
WriteLine($"table of cubes of numbers from 1 to {Number} is over");
