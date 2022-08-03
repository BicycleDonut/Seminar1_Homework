// Напишите программу, которая на вход принемает два числа и выдает, 
//какое число большее, а какое меньшее.
Console.WriteLine("Напишите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max=a,min=b;
if(a>b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}