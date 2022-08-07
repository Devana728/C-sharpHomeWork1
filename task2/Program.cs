// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает скорсоли строку
    int result = int.Parse(readValue);// преобразует стоку в целое число
    return result;//возвращает результат
}
int value1;//обьявление переменной
int value2;
int value3;
value1 = Prompt("Введите число 1 ");//вводим значение
value2 = Prompt("Введите число 2 ");
value3 = Prompt("Введите число 3 ");

int max = value1;
if (value2 > max ) max = value2;
if (value3 > max ) max = value3;


Console.Write("max=");
Console.WriteLine(max);