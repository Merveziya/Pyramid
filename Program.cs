using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pyramid
{
    class Program
    {
        static void DrawPyramid(int TotalRows)
        {
            for (int CurrentRow = 1; CurrentRow <= TotalRows; CurrentRow++)
            {
                for (int Spaces = CurrentRow; Spaces <= TotalRows; Spaces++)
                {
                    Console.Write("  ");
                }
                for (int Stars = 1; Stars <= 2 * CurrentRow - 1; Stars++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawPyramid(5);
        }

    }

}
