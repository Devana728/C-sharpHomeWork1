// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает скорсоли строку
    int result = int.Parse(readValue);// преобразует стоку в целое число
    return result;//возвращает результат
}
int value;//обьявление переменной

value = Prompt("Введите число = ");//вводим значение

int result = value % 2;
if (result <= 0)
{
   Console.WriteLine(" - четное число ");
}
else 
{
   Console.WriteLine(" - нечетное число ");
}
