// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
int Prompt(string msg)
{
    Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if (num >=100 && num < 1000)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Ошибка. Введено не трёхзначное число.");
        return false;
    }
}

int number = Prompt("Введите трёхзначное число");
if (Validate(number))
{
    int middleNum = number / 10 % 10;
    System.Console.WriteLine($"Второй цифрой для числа {number} является {middleNum}");
// Если вывести WriteLine за пределы if, то появляется ошибка CS0103. Почему? 
// Переменная является локальной для области цикла и уничтожается? 
}