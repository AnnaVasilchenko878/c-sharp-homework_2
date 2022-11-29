// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99)
{
  Console.WriteLine("В вашем числе нет третьей цифры");
}
else
{
  while (number > 999)
  {
    number = number / 10;
  }
  Console.WriteLine(number % 10);
}

