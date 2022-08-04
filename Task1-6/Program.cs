// Напишите программу, которая на вход принемает число и выдает,
// является ли число четным (делится ли оно на 2 без остатка).
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N%2==0) 
{
    Console.WriteLine("ДА");
}
else
{
   Console.WriteLine("НЕТ"); 
}
