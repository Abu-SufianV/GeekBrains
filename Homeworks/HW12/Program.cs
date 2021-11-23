// 12. Удалить вторую цифру трёхзначного числа

int num_delete(int number)
{
    int num_1 = number / 100 * 10;
    int num_2 = number % 10;

    return num_1 + num_2;
}

Console.WriteLine("Введите число: ");
Console.WriteLine(num_delete(Convert.ToInt32(Console.ReadLine())));