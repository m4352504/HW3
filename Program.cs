// принимает число и выдает таблицу кубов от 1 до N
/*
Console.WriteLine("Введите число");
int end = Convert.ToInt32(Console.ReadLine());
for (int start = 1; start <= end; start++)
{
    Console.WriteLine(Math.Pow(start, 3));
}
*/

// принимает координаты 2х точек и находит расстояние между ними в 3D пространстве 

Console.WriteLine("Введите координаты точки А");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

double ans = Math.Sqrt(Math.Pow(xb-xa, 2)+Math.Pow(yb-ya, 2)+Math.Pow(zb-za,2));
Console.WriteLine("Расстояние " + Math.Round(ans,2));
