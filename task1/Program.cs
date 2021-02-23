using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default; //Українська
            double x,y;
            Console.WriteLine("Input x and y"); 
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToDouble(Console.ReadLine()); 
            double R;
            Console.WriteLine("Input R");
            R = Convert.ToDouble(Console.ReadLine());
            if(x>=0)                                 //Права частина графіку
            {
                double distance;
                distance = Math.Sqrt(x*x+y*y);
                if(distance<R)
                    Console.WriteLine("Так");
                else
                {
                    if(distance==R)
                        Console.WriteLine("На межі"); //1.4142135623730951
                    else
                        Console.WriteLine("Ні");
                }
            }
            if(x<0)                                   //Ліва частина графіку
            {
                if(y<x || -y<x && Math.Abs(y)<R && x>-5)
                    Console.WriteLine("Так");
                else
                {
                    if(y<=x || -y<=x && Math.Abs(y)<=R && x>=-5)
                        Console.WriteLine("На межі");
                    else
                        Console.WriteLine("Ні");
                }
            }
            //Console.WriteLine("x = " + x +" y = " + y);
        }
    }
}
