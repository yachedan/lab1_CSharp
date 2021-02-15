using System;
using System.Linq;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] whiteKing = new byte[2] {0, 0};
            byte[] whiteHorse = new byte[2] {0, 0};
            byte[] blackKing = new byte[2] {0, 0};
            bool flag = false;


            Console.WriteLine("Input coordinates(x,y): ");
            Console.Write("White King: ");
            string input = Console.ReadLine();
            whiteKing[0] = (byte)Char.GetNumericValue(input[0]);
            whiteKing[1] = (byte)Char.GetNumericValue(input[2]);
            if(whiteKing[0]<1 || whiteKing[0]>8 || whiteKing[1]<1 || whiteKing[1]>8)
                flag = true;
            Console.Write("White Horse: ");
            input = Console.ReadLine();
            whiteHorse[0] = (byte)Char.GetNumericValue(input[0]);
            whiteHorse[1] = (byte)Char.GetNumericValue(input[2]);
            if(whiteHorse[0]<1 || whiteHorse[0]>8 || whiteHorse[1]<1 || whiteHorse[1]>8)
                flag = true;
            Console.Write("Black King: ");
            input = Console.ReadLine();
            blackKing[0] = (byte)Char.GetNumericValue(input[0]);
            blackKing[1] = (byte)Char.GetNumericValue(input[2]);

            
            if(blackKing[0]<1 || blackKing[0]>8 || blackKing[1]<1 || blackKing[1]>8)
                flag = true;
            if (whiteHorse.SequenceEqual(whiteKing) || whiteKing.SequenceEqual(blackKing)
                || flag == true)
                Console.WriteLine("Wrong input! Try again.");
             else
           {
                if(Math.Abs(whiteKing[0]-whiteHorse[0])==1 && Math.Abs(whiteKing[1]-whiteHorse[1])==2
                    || Math.Abs(whiteKing[0]-whiteHorse[0])==2 && Math.Abs(whiteKing[1]-whiteHorse[1])==1)
                    Console.WriteLine("Білий кінь захищає білого короля");
                if(Math.Abs(blackKing[0]-whiteHorse[0])==1 && Math.Abs(blackKing[1]-whiteHorse[1])==2
                    || Math.Abs(blackKing[0]-whiteHorse[0])==2 && Math.Abs(blackKing[1]-whiteHorse[1])==1)
                    Console.WriteLine("Білий кінь атакує чорного короля");
                if(Math.Abs(whiteKing[0]-whiteHorse[0])==1 && Math.Abs(whiteKing[1]-whiteHorse[1])==0
                    || Math.Abs(whiteKing[0]-whiteHorse[0])==0 && Math.Abs(whiteKing[1]-whiteHorse[1])==1
                    || Math.Abs(whiteKing[0]-whiteHorse[0])==1 && Math.Abs(whiteKing[1]-whiteHorse[1])==1)
                    Console.WriteLine("Білий король захищає білого коня");
                if(Math.Abs(whiteKing[0]-blackKing[0])==1 && Math.Abs(whiteKing[1]-blackKing[1])==0
                    || Math.Abs(whiteKing[0]-blackKing[0])==0 && Math.Abs(whiteKing[1]-blackKing[1])==1
                    || Math.Abs(whiteKing[0]-blackKing[0])==1 && Math.Abs(whiteKing[1]-blackKing[1])==1)
                    Console.WriteLine("Білий король атакує чорного короля\n" 
                                        +"Чорний король атакує білого короля");
               
           }
            //Console.WriteLine(whiteKing[0]+", "+whiteKing[1]);
             
        }
    }   
}
