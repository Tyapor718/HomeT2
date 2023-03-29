//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета (решать только при помощи операций % и /).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int ReadInt (string message)
{
    Console.WriteLine($"{message} ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int N = ReadInt ("Введите число");
int ThirdNumber (int number)
{
    int result = -1;
    if (number >=100 )
    {
        while (number >999)
        {
            number = number/10;
        }
        result= number%10;
    }
     return result;
}
int K = ThirdNumber (N);
if (K<0)
{
    Console.Write ("Третьей цифры нет");
}
else 
{
    Console.Write (K);
}  


