using System;

class Program
{
    static void Main()
    {
        //1.Написать переводчик из двоичной системы в десятичную до восьми знаков(Ввод: строка, типа "11011100", Вывод: число 220)
        Console.Write("Введите двоичное число: ");
        string number = Console.ReadLine();
        int result = Convert.ToInt32(number, 2);

        Console.WriteLine($"Десятичное число: {result}");
        //2.Написать переводчик из десятичной в двоичную(Ввод: целочисленное число, Вывод: строка, типа "11011100")
        Console.Write("Введите десятичное число: ");
        int num = int.Parse(Console.ReadLine());
        string res = Convert.ToString(num, 2);

        Console.WriteLine($"Двоичное число: {res}");
        //3. 



    }
}