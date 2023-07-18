// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру: ");
int number=Convert.ToInt32(Console.ReadLine());
if(number>0&&number<8){
bool res= DailyCheck(number);
Console.WriteLine(res? "Да": "Нет");
}
else Console.WriteLine("Ошибка ввода");

bool DailyCheck(int num)
{
    if(num==6||num==7){
        return true;
    }
    return false;
}