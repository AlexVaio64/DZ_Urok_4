// Программа принимает на вход целое или дробное число и выдаёт количество цифр 
// в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (A > 0)
{
    A = A/10;
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}");