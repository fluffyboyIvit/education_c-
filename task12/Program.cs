// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int reminder = IsMyltiplisity(firstNumber, secondNumber);
// if(reminder==0)Console.Write("Кратно");
// else Console.Write($"не кратно, остаток {reminder}");
Console.Write(reminder == 0 ? "кратно" : $"не кратно, остаток {reminder}");

int IsMyltiplisity(int firstNum, int secondNum)
{
    return firstNum % secondNum;
}