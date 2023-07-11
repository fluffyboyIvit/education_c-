// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int counter = 0;
if(n>1)
 {
      while(counter <= n)
    {  
        counter=counter + 2;
        if(counter<=n){
        Console.Write(counter + " ");
        }
    }
}
 
  
else{
    Console.WriteLine("Ошибка ввода");
}