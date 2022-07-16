// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
static void Main(){


//   if (number1 <= 0 || number2 <= 0)
//      Console.WriteLine("Возможен ввод только натуральных чисел");
//else
//{
//   Console.WriteLine(Math.Pow(number1, number2));
//}
   
    Console.WriteLine("Введите число (A): ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (B): ");
int number2 = Convert.ToInt32(Console.ReadLine());
  
//   if (number1 <= 0 || number2 <= 0)
//      Console.WriteLine("Возможен ввод только натуральных чисел");
//else
//{
//   Console.WriteLine(Math.Pow(number1, number2));
//}

switch (number1 <= 0 || number2 <= 0)
{
  case true:
    Console.WriteLine("Возможен ввод только натуральных чисел");
    // Запуск метода Main, если условие некорректно
    Main();
    break;
  case false:
    Console.WriteLine(Math.Pow(number1, number2));
    break;
}   
}
Main();