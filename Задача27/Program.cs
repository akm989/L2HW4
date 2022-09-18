// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введиет число :  ");
int number = int.Parse(Console.ReadLine());

  int NumSum(int numA)
  {
    
    int count = Convert.ToString(numA).Length;
    int Digit1 = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      
      Digit1 = numA - numA % 10;
      result = result + (numA - Digit1);
      numA = numA / 10;
    }
   return result;
  }

int Total = NumSum(number);
Console.WriteLine("Сумма цифр в числе: " + Total);