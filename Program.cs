/* Задача 1: Напишите цикл, который принимает
 на вход два числа (A и B)
  и возводит число A в натуральную степень B. 
  Не использовать функцию Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = A * A;
/*int i = 2;
while (i < B)
{
    count = count * A;
    i++;
}
Console.WriteLine(count);*/

for(int i = 2; i < B; i++)
{
    count = count * A;    
}
Console.WriteLine(count);
