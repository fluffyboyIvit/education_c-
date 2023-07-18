// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("ВВедите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
bool res = IsSquareTwo(firstDigit, secondDigit);
Console.WriteLine(res ? "да" : "нет");
bool IsSquareTwo(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}