// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.
int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt ("Введите любое целое число");
int result = Math.Abs(number);

if (result > 100)
{
    while (result > 1000)
    {
        result /= 10;
    }
    System.Console.WriteLine($"{number} -> третья цифра {result % 10}");
}
else
{
    System.Console.WriteLine($"{number} -> третьей цифры нет");
}