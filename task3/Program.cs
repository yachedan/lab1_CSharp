using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime input = DateTime.MinValue;
            Console.WriteLine("Введіть дату(MMMM dd): ");
             try
            {
                input = DateTime.Parse(Console.ReadLine());
                switch(input.Month)
                {
                    case 1: //January
                        if(input.Day <= 19)
                            Console.WriteLine("Capricorn");
                        else 
                            Console.WriteLine("Aquarius");
                        break;
                    case 2: //February
                         if(input.Day <= 18)
                            Console.WriteLine("Aquarius");
                        else 
                            Console.WriteLine("Pisces");
                        break;
                    case 3: //March
                        if(input.Day <= 20)
                            Console.WriteLine("Pisces");
                        else 
                            Console.WriteLine("Aries");
                        break;
                    case 4: //April
                        if(input.Day <= 19)
                            Console.WriteLine("Aries");
                        else 
                            Console.WriteLine("Taurus");
                        break;
                    case 5: //May
                        if(input.Day <= 20)
                            Console.WriteLine("Taurus");
                        else 
                            Console.WriteLine("Gemini");
                        break;
                    case 6: //June
                        if(input.Day <= 21)
                            Console.WriteLine("Gemini");
                        else
                            Console.WriteLine("Cancer");
                        break;
                    case 7: //July
                        if(input.Day <=22)
                            Console.WriteLine("Cancer");
                        else
                            Console.WriteLine("Leo");
                        break;
                    case 8: //August
                        if(input.Day <= 22)
                            Console.WriteLine("Leo");
                        else
                            Console.WriteLine("Virgo");
                        break;
                    case 9: //September
                        if(input.Day <= 22)
                            Console.WriteLine("Virgo");
                        else
                            Console.WriteLine("Libra");
                        break;
                    case 10: //October
                        if(input.Day <= 23)
                            Console.WriteLine("Libra");
                        else 
                            Console.WriteLine("Scorpio");
                        break;
                    case 11: //November
                        if(input.Day <= 21)
                            Console.WriteLine("Scorpio");
                        else 
                            Console.WriteLine("Sagittarius");
                        break;
                    case 12: //December
                        if(input.Day <= 19)
                            Console.WriteLine("Sagitarius");
                        else 
                            Console.WriteLine("Capricorn");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Wrong input!");
            }
            //Console.WriteLine(input.ToString("MMMM dd"));
        }
    }
}
