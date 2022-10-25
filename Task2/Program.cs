// Программа, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


int PromptInt(string strDescription) //Ввод целого числа
{
    try
    {
        Console.Write(strDescription);
        int intTemp = int.Parse(Console.ReadLine());
        return intTemp;
    }
    catch
    {
        Console.WriteLine("Invalid value entered, please try again!");
        int intException = PromptInt(strDescription);
        return intException;
    }
}

bool ValidateQuarter(int Quarter)
{
    if (Quarter > 0 && Quarter < 5)
    {
        return true;
    }
    return false;
}

(int, int) FindCoords(int Quarter) // функция поиска шаблона координат
{
    if (Quarter == 1) return (1, 1);
    if (Quarter == 2) return (-1, 1);
    if (Quarter == 3) return (-1, -1);
    return (1, -1);
}

int Quarter = PromptInt(strDescription: "Enter quarter number: ");
if (ValidateQuarter(Quarter))
{
    (int x, int y) = FindCoords(Quarter);
    Console.WriteLine($"for a quarter: {Quarter} use coordinate pattern: ({x}, {y}");
}
else
{
    Console.WriteLine("Invalid value entered, try again!");
}




