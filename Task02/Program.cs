// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
 int Data(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int xa = Data ("Введите координаты xa : ");
int ya = Data ("Введите координаты ya : ");
int za = Data ("Введите координаты za : ");
int xb = Data ("Введите координаты xb : ");
int yb = Data ("Введите координаты yb : ");
int zb = Data ("Введите координаты zb : ");
double result = Math.Sqrt(Math.Pow((xa-xb),2) + Math.Pow((ya-yb),2) + Math.Pow((za-zb),2));
Console.WriteLine("Расстояние между точкми в 3D пространстве  " + result+ ".");