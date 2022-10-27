// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int PromptInt(string strMessage) 
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

bool ValidateFiveDigit(int num)
{
    if (num / 100000 == 0 && num / 10000 > 0) return true;
    
    else return false;
}


int ReverseNumber(int num)
{
    int intTemp = 0;
    while (num >0)
    {
        intTemp = intTemp * 10 + num % 10;
        num = num / 10;
    }
    return intTemp;
}


bool IsPalindrome(int num)
{
    if (num == ReverseNumber(num)) return true;
    else return false;
}


int num = PromptInt("Enter a five-digit number: ");

if (IsPalindrome(num))
{
    System.Console.WriteLine($"Digit {num} is a palindrome.");
}
else
{
    System.Console.WriteLine($"Digit {num} is not a palindrome.");
}


