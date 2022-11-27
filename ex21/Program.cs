// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
using static System.Console;
Write("enter coordinate X of point A: ");
int Ax = int.Parse(ReadLine());
Write("enter coordinate Y of point A: ");
int Ay = int.Parse(ReadLine());
Write("enter coordinate Z of point A: ");
int Az = int.Parse(ReadLine());
Write("enter coordinate X of point B: ");
int Bx = int.Parse(ReadLine());
Write("enter coordinate Y of point B: ");
int By = int.Parse(ReadLine());
Write("enter coordinate Z of point B: ");
int Bz = int.Parse(ReadLine());

double Distance_between_points = Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)+Math.Pow(Bz-Az,2));
Write($"Distance between points in 3d = {Distance_between_points}");

