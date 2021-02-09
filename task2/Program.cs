using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime input = DateTime.MinValue;
            DateTime min = DateTime.Parse("7:00");
            DateTime max = DateTime.Parse("12:00");
            Console.WriteLine("Введіть час(HH:mm): ");
            try
            {
                input = DateTime.Parse(Console.ReadLine());
                if (input>min && input<max)
                    Console.WriteLine("Йти в гості");
                else 
                    Console.WriteLine("Не йти в гості");
            }
            catch
            {
                Console.WriteLine("Wrong input!");
            }
            
            /*if(input != DateTime.MinValue)
            Console.WriteLine(input.ToString("HH:mm"));*/

        }
    }
}
