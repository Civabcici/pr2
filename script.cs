using System;

class Program
{
    static void Main()
    {
        //1.�������� ���������� �� �������� ������� � ���������� �� ������ ������(����: ������, ���� "11011100", �����: ����� 220)
        Console.Write("������� �������� �����: ");
        string number = Console.ReadLine();
        int result = Convert.ToInt32(number, 2);

        Console.WriteLine($"���������� �����: {result}");

        //2.�������� ���������� �� ���������� � ��������(����: ������������� �����, �����: ������, ���� "11011100")
        Console.Write("������� ���������� �����: ");
        int num = int.Parse(Console.ReadLine());
        string res = Convert.ToString(num, 2);

        Console.WriteLine($"�������� �����: {res}");

        //3. ������� � N ����� � ����� ������ �������� ������� �������� ������ ������. �������� ������, ��� �������� �������� ����� � �����. ������� ����� ������� �� ����������� �����, ����� �������� ������������ �������� ?
        int N = int.Parse(Console.ReadLine()); 
        int M = int.Parse(Console.ReadLine());  
        int T = int.Parse(Console.ReadLine());  

        int totalMinutes = N * 60 + M + T;

        int hours = (totalMinutes / 60) % 24;
        int minutes = totalMinutes % 60;

        Console.WriteLine($"{hours:D2}:{minutes:D2}");


    }
}