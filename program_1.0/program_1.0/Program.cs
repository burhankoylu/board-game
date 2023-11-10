using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1;
            int a2;
            int a3;
            int b1;
            int b2;
            int b3;
            int c1;
            int c2;
            int c3;

            Console.WriteLine("      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine("   1| * _ _ |");
            Console.WriteLine("   2| _ _ _ |                                                  enter zero to exit");
            Console.WriteLine("   3| _ _ _ |");
            Console.WriteLine("    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine($"   1| {a1} * _ |");
            Console.WriteLine($"   2| _ _ _ |                                                  enter zero to exit");
            Console.WriteLine($"   3| _ _ _ |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine($"   1| {a1} {a2} * |");
            Console.WriteLine($"   2| _ _ _ |                                                  enter zero to exit");
            Console.WriteLine($"   3| _ _ _ |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            a3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine($"   1| {a1} {a2} {a3} |");
            Console.WriteLine($"   2| * _ _ |                                                  enter zero to exit");
            Console.WriteLine($"   3| _ _ _ |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine($"   1| {a1} {a2} {a3} |");
            Console.WriteLine($"   2| {b1} * _ |                                                  enter zero to exit");
            Console.WriteLine($"   3| _ _ _ |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            b2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine($"   1| {a1} {a2} {a3} |");
            Console.WriteLine($"   2| {b1} {b2} * |                                                  enter zero to exit");
            Console.WriteLine($"   3| _ _ _ |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            b3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine($"   1| {a1} {a2} {a3} |");
            Console.WriteLine($"   2| {b1} {b2} {b3} |                                                  enter zero to exit");
            Console.WriteLine($"   3| * _ _ |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine($"   1| {a1} {a2} {a3} |");
            Console.WriteLine($"   2| {b1} {b2} {b3} |                                                  enter zero to exit");
            Console.WriteLine($"   3| {c1} * _ |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            c2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"      4 5 6");
            Console.WriteLine("    + - - - +                                                  please enter the board with random numbers");
            Console.WriteLine($"   1| {a1} {a2} {a3} |");
            Console.WriteLine($"   2| {b1} {b2} {b3} |                                                  enter zero to exit");
            Console.WriteLine($"   3| {c1} {c2} * |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter a number between 1 to 9 = ");

            c3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //----------------------------------------------------------------------------------------------------------//

            int temp;

            Console.WriteLine($"      4 5 6");
            Console.WriteLine($"    + - - - +                                                  choose your move between 1 to 6");
            Console.WriteLine($"   1| {a1} {a2} {a3} |");
            Console.WriteLine($"   2| {b1} {b2} {b3} |                                                  enter zero to exit");
            Console.WriteLine($"   3| {c1} {c2} {c3} |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter your move = ");
            bool over = false;

            while (!over)
            {
                int move = Convert.ToInt32(Console.ReadLine());

                if (move == 0)
                {
                    over = true;
                }

                else if (move == 1)
                {
                    temp = a1;
                    a1 = a3;
                    a3 = a2;
                    a2 = temp;
                }

                else if (move == 2)
                {
                    temp = b1;
                    b1 = b3;
                    b3 = b2;
                    b2 = temp;
                }

                else if (move == 3)
                {
                    temp = c1;
                    c1 = c3;
                    c3 = c2;
                    c2 = temp;

                }

                else if (move == 4)
                {
                    temp = a1;
                    a1 = c1;
                    c1 = b1;
                    b1 = temp;
                }

                else if (move == 5)
                {
                    temp = a2;
                    a2 = c2;
                    c2 = b2;
                    b2 = temp;
                }

                else if (move == 6)
                {
                    temp = a3;
                    a3 = c3;
                    c3 = b3;
                    b3 = temp;
                }

                else
                {
                    Console.WriteLine("Please choose a move between 1 to 6");
                }

                PrintBoard(a1, a2, a3, b1, b2, b3, c1, c2, c3);
            }

        }

        static void PrintBoard(int a1, int a2, int a3, int b1, int b2, int b3, int c1, int c2, int c3)
        {
            Console.Clear();


            Console.WriteLine($"      4 5 6");
            Console.WriteLine($"    + - - - +                                                  choose your move between 1 to 6");
            Console.WriteLine($"   1| {a1} {a2} {a3} |");
            Console.WriteLine($"   2| {b1} {b2} {b3} |                                                  enter zero to exit");
            Console.WriteLine($"   3| {c1} {c2} {c3} |");
            Console.WriteLine($"    + - - - +");
            Console.WriteLine();
            Console.Write("enter your move = ");
            Console.ReadLine();
        }
    }
}
