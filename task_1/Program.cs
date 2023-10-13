Console.Write("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (num1 > num2)
{
    max = num1;
    Console.WriteLine(num1);
}
else
{
    max = num2;
    Console.WriteLine(num2);
}