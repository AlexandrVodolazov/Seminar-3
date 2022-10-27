// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message) // Функция ввода числа с консоли.
{
    Console.Write(message);                  // Выводит сообщение в консоли.
    return int.Parse(Console.ReadLine());    //Считать строку с консоли и преобразовать в целое значение.
}

int x1 = Prompt("Enter x1: ");
int y1 = Prompt("Enter y1: ");
int z1 = Prompt("Enter z1: ");
int x2 = Prompt("Enter x2: ");
int y2 = Prompt("Enter y2: ");
int z2 = Prompt("Enter z2: ");

int x = x1 - x2;
int y = y1 - y2;
int z = z1 - z2;


double Lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));   // Возводим в квадрат.
Console.Write($"Расстояние между точками: {Lenght:f2}");





