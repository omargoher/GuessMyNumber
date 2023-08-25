using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    internal class Program
    {
        static int guess(int num,int rnum)
        {
            if (num == rnum)
            {
                Console.WriteLine("Corect");
                return 0;
            }
            else if(num > rnum)
            {
                Console.Write($"My number is less than {num}\nEnter your guess: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            else if(num < rnum)
            {
                Console.Write($"My number is greater than {num}\nEnter your guess: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return guess(num,rnum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range of numbers you want the target number to be between");
            Console.Write("Enter The first number in the range ");
            int fnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The second number in the range ");
            int lnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your guess: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rnum = new Random().Next(fnum, lnum);
            guess(num,rnum);
        }
    }
}
