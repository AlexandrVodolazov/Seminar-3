// Программа, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message) // Функция ввода числа с консоли.
{
    Console.Write(message);                  // Выводит сообщение в консоли.
    return int.Parse(Console.ReadLine());    //Считать строку с консоли и преобразовать в целое значение.
}

int N = Prompt("Enter a number greater 0: ");

int count = 1;                                    // Счетчик.

for (int i = 1; i <= N; i++)                      // 
{
    Console.WriteLine(Math.Pow(i, 2));
}


