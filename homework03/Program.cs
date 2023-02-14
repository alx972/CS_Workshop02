// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int minNumber = 1, maxNumber = 7;
int saturday = 6, sunday = 7; // weekend в европейском варианте
int dayofweek = 0;

int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num) // Проверка валидности введенного числа
{
    if (num >=minNumber && num <= maxNumber)
    {
        return true;
    }
    else
    {
        return false;
    }
}

while (!Validate(dayofweek)) // ввод числа с проверкой на валидность
{
    dayofweek = Prompt("Введите номер дня недели (число от 1 до 7)");
};

if (dayofweek == saturday | dayofweek == sunday ) // проверка дня недели
{
    System.Console.WriteLine($"{dayofweek} - выходной день");
}
else
{
    System.Console.WriteLine($"{dayofweek} - рабочий день");
}