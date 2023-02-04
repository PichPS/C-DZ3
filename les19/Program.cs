// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Введите пятизначное число:  ");
int n = Convert.ToInt32(Console.ReadLine());
string nStr = Convert.ToString(n);
n = nStr.Length;
if (nStr[0]==nStr[4] && nStr[1]==nStr[3])
{
    Console.WriteLine ($"{nStr} -> да");
}
else 

Console.WriteLine ($"{nStr} -> нет");   

// Ниже пытался вывести надпись, если ввели не пятизначное число - но не получилось:(
// if (nStr.Length > 4 || nStr.Length < 4)
// {
// Console.WriteLine ("Нужно ввести пятизначное число!"); 
// } 

