// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine($"Введите трёхначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int res = SecondDigit(number);
    Console.WriteLine($"Ответ: {res}");
}
else Console.WriteLine("Ошибка ввода");


int SecondDigit(int num)
{

    // int num1 = num / 10;
    // int num2 = num1 % 10;
    // return num2;
    return num=num/10%10;

}