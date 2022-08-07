// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int Prompt(string message) 
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает скорсоли строку
    int result = int.Parse(readValue);// преобразует стоку в целое число
    return result;//возвращает результат
}
int N;//обьявление переменной

N = Prompt("Введите число N = ");//вводим значение
for (int i = 2; i <= N; i = i + 2)
{
  Console.WriteLine(i);
}

