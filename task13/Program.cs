// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99){

int res=SecondDigit(number);
Console.Write(res);
}
else Console.WriteLine("третьей цифры нет");

int SecondDigit(int num){
    while(num>999){
       num=num/10;
    }
    return num%10;
}