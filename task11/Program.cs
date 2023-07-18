// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхначное число{number}");

int res = RemoveSecondDigit(number);
Console.WriteLine($"Ответ: {res}");

int RemoveSecondDigit(int num)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    int resultDigit = firstDigit * 10 + secondDigit;
    return resultDigit;
}