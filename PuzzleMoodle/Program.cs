using System;

namespace PuzzleMoodle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linje1 = 8;
            var linje2 = 8;
            var linje3 = 6;
            var linje4 = 5;

            LineOne(linje1);

            Console.WriteLine("");

            LineTwo(linje2);

            Console.WriteLine("");

            LineThree(linje3);

            Console.WriteLine("");

            LineFour(linje4);
        }

        private static void LineFour(int linje4)
        {
            for (int u = 0; u < linje4; u++)
            {
                if (u == 0 || u == 1 || u == 2)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }



            }
        }

        private static void LineThree(int linje3)
        {
            for (int u = 0; u < linje3; u++)
            {
                if (u == 0 || u == 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }


            }
        }

        private static void LineTwo(int linje2)
        {
            for (int u = 0; u < linje2; u++)
            {
                if (u == 0 || u == 7)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }

            }
        }

        private static void LineOne(int linje1)
        {
            for (int i = 0; i < linje1; i++)
            {

                Console.Write("#");

            }
        }
    }
}
