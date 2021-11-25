// 21. Программа проверяет пятизначное число на палиндромом

string palindrome(string number)
{
    string past_1 = $"{number[0]}{number[1]}";
    string past_2 = $"{number[4]}{number[3]}";

    if (past_1 == past_2)
    {
        return "Число является палиндромом";
    }
    return "Число НЕ является палиндромом";

}

Console.Write("\nВведите число: ");
Console.WriteLine(palindrome(Console.ReadLine()));

Console.WriteLine();