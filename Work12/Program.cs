using System;

namespace Work12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число -> ");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            do{
                sum += x % 10;
                x /= 10;                      
            }while(x!=0);
            Console.WriteLine("Сумма = {0}",sum);
        }
    }
}
