// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
using static System.Console;
WriteLine("enter 5-digit number: ");
String Number = ReadLine();
if (Number[0] == Number[4] && Number[1] == Number[3])
    WriteLine("5-digit number is palindrome");
else
    WriteLine("5-digit number is not palindrome");

