// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); //99+1=100 
Console.WriteLine($"Случайное положительное двузначное чисоо из диапозона 10-99 => {number}");
int res = MaxDigit(number);
Console.WriteLine($"Максимальная цифра числа -> {res}");

int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 / 10 = 7.8 -> 7
    int secondDigit = num % 10; // 78 = 70 + 8
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}