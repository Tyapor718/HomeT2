//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int ReadInt (string message)
{
    Console.WriteLine($"{message} ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int N = ReadInt ("Введите число");
if (N <6 && N>0)
{
    Console.WriteLine(" День не выходной ");
}
if (N>=6 && N<=7)
{
    Console.WriteLine(" День выходной ");
}
if (N>7)
{
    Console.WriteLine("-1");
}

