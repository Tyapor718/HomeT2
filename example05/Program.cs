//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета (решать только при помощи операций % и /).
//456 -> 5
//782 -> 8
//918 -> 1
int ReadInt (string message)
{
    Console.WriteLine($"{message} ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int N = ReadInt ("Введите трехзначное число");
if (N <1000 && N>-1000)
{
    int digit = N/10 %10;
    Console.WriteLine($"Вторая цифра числа {N} равна {digit} ");
}
else 
{
    Console.WriteLine($"Введено не трехзначное число");
}

