// Напишите программу, которая на вход принемает число (N),
//а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 2;
if(count < N)
{
    while(count<=N)
    {
        Console.WriteLine(count);
        count+=2;
    }
}
else
    {
        Console.WriteLine("Введите целое число больше 2");
    }
