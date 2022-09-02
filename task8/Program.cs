//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int a = 1;
for (a = 1; a < num1; a++)  
if(a % 2 == 0) 
Console.WriteLine(a);
