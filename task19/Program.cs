﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 10000 && N <= 99999)
{
 if (N%10 == N/10000 && N%100/10 == N%10000/1000)
  {
   Console.WriteLine("ПАЛИНДРОМ");
  }

  else
  {
    Console.WriteLine("Это число не является палиндромом");
  }
}

else
{
 Console.WriteLine("Введённое Вами число не совсем пятизначное");  
}
