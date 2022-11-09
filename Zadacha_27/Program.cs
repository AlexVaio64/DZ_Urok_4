// Программа принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число X: ");
int numberX = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberX)
  {    
    int counter = Convert.ToString(numberX).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberX - numberX % 10;
      result = result + (numberX - advance);
      numberX = numberX / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberX);
Console.WriteLine("Сумма цифр в числе = " + sumNumber);