
using KP_DOLG_5;

MyClass myClass = new MyClass();
Console.WriteLine("Введите 3 значения int для подсчета суммы элементов : ");
Console.WriteLine("a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("c:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма 3 элементов: " + myClass.MySum(a, b, c));

Console.WriteLine("Введите значение int для возведения в 3 степень : ");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Значение в 3 степени: " + myClass.MyPow(pow));

Console.WriteLine("Введите 2 значение для получения наибольшего: ");
Console.WriteLine("a:");
int maxA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b:");
int maxB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Наибольшее значение: " + myClass.MyMax(maxA, maxB));