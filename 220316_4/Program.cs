using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220316_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stars;
            Console.Write("Stars:");
            stars = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < stars; i++)
            {
                Console.Write("★");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
