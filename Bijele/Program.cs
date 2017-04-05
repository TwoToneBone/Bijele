using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int[] chessPieces = new int[] { 1, 1, 2, 2, 2, 8 };
            string output = string.Empty;
            for (int i = 0; i < chessPieces.Length; i++)
            {
                int input = int.Parse(inputs[i]);
                int difference = Math.Abs(input - chessPieces[i]);

                if(input < chessPieces[i] && input != 0)
                {
                    difference = difference * -1; // ej klar
                }

                output += difference;
            }
            Console.WriteLine(output);
        }
    }
}
