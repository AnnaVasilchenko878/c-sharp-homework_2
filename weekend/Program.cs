// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня в недели: ");
int number = Convert.ToInt32(Console.ReadLine());

  if (number>=1 && number<=5) Console.WriteLine("Это будний день");
  else if (number>5 && number<=7) Console.WriteLine("Это выходной день");
  else Console.WriteLine("В недели всего 7 дней");