// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}
int value1;//обьявление переменной
int value2;

value1 = Prompt("Введите число 1 ");//вводим значение
value2 = Prompt("Введите число 2 ");


int max = value1;
int min = value2;
if (value1 < value2 ) 
    { 
      max = value2; min = value1; 
    }


Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min);