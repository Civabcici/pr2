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
        //3. 



    }
}