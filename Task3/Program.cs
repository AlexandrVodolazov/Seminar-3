// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message) // Функция ввода числа с консоли.
{
    Console.Write(message);                  // Выводит сообщение в консоли.
    return int.Parse(Console.ReadLine());    //Считать строку с консоли и преобразовать в целое значение.
}

int x1 = Prompt("Enter x1: ");
int y1 = Prompt("Enter y1: ");
int x2 = Prompt("Enter x2: ");
int y2 = Prompt("Enter y2: ");


int x = x1 - x2;
int y = y1 - y2;

double Lenght = Math.Sqrt(x * x + y * y);    // Возводим в квадрат.
Console.Write(Lenght);

