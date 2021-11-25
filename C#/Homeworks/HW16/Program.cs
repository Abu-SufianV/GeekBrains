// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num == 6) || (num == 7))
{
    Console.WriteLine("Данный день недели - выходной");
}
else
{
    Console.WriteLine("Данный день недели - будни");
}