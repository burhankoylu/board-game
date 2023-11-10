using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace program_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------------------variables--------------------------*/
            int a1;
            int a2;
            int a3;
            int b1;
            int b2;
            int b3;
            int c1;
            int c2;
            int c3;
            int temp;
            int move;
            int turn;
            int round = 0;
            int board_score = 0;
            int player_score = 0;
            int computer_score = 0;
            int computer_move;

            while (round < 5)
            {
                round = round + 1;
                turn = 1;



                /*--------------------------first roun blank table--------------------------*/
                if (round == 1)
                {
                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| * _ _ |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| _ _ _ |");
                    Console.WriteLine($"3| _ _ _ |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    a1 = Convert.ToInt32(Console.ReadLine());
                    while (a1 < 1 || a1 > 9)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9");
                        Console.Write("enter a number between 1 to 9 = ");
                        a1 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.Clear();

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} * _ |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| _ _ _ |");
                    Console.WriteLine($"3| _ _ _ |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    a2 = Convert.ToInt32(Console.ReadLine());
                    while (a2 < 1 || a2 > 9 || a2 == a1)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9 and It cannot be same with  previous numbers");
                        Console.Write("enter a number between 1 to 9 = ");
                        a2 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.Clear();

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} * |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| _ _ _ |");
                    Console.WriteLine($"3| _ _ _ |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    a3 = Convert.ToInt32(Console.ReadLine());
                    while (a3 < 1 || a3 > 9 || a3 == a1 || a3 == a2)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9 and It cannot be same with  previous numbers");
                        Console.Write("enter a number between 1 to 9 = ");
                        a3 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.Clear();

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| * _ _ |");
                    Console.WriteLine($"3| _ _ _ |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    b1 = Convert.ToInt32(Console.ReadLine());
                    while (b1 < 1 || b1 > 9 || b1 == a1 || b1 == a2 || b1 == a3)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9 and It cannot be same with  previous numbers");
                        Console.Write("enter a number between 1 to 9 = ");
                        b1 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.Clear();

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} * _ |");
                    Console.WriteLine($"3| _ _ _ |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    b2 = Convert.ToInt32(Console.ReadLine());
                    while (b2 < 1 || b2 > 9 || b2 == a1 || b2 == a2 || b2 == a3 || b2 == b1)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9 and It cannot be same with  previous numbers");
                        Console.Write("enter a number between 1 to 9 = ");
                        b2 = Convert.ToInt16(Console.ReadLine());
                    }

                    Console.Clear();

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} {b2} * |");
                    Console.WriteLine($"3| _ _ _ |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    b3 = Convert.ToInt32(Console.ReadLine());
                    while (b3 < 1 || b3 > 9 || b3 == a1 || b3 == a2 || b3 == a3 || b3 == b1 || b3 == b2)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9 and It cannot be same with  previous numbers");
                        Console.Write("enter a number between 1 to 9 = ");
                        b3 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.Clear();

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| * _ _ |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    c1 = Convert.ToInt32(Console.ReadLine());
                    while (c1 < 1 || c1 > 9 || c1 == a1 || c1 == a2 || c1 == a3 || c1 == b1 || c1 == b2 || c1 == b3)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9 and It cannot be same with  previous numbers");
                        Console.Write("enter a number between 1 to 9 = ");
                        c1 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.Clear();

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} * _ |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    c2 = Convert.ToInt32(Console.ReadLine());
                    while (c2 < 1 || c2 > 9 || c2 == a1 || c2 == a2 || c2 == a3 || c2 == b1 || c2 == b2 || c2 == b3 || c2 == c1)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9 and It cannot be same with  previous numbers");
                        Console.Write("enter a number between 1 to 9 = ");
                        c2 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.Clear();

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} * |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("enter a number between 1 to 9 = ");

                    c3 = Convert.ToInt32(Console.ReadLine());
                    while (c3 < 1 || c3 > 9 || c3 == a1 || c3 == a2 || c3 == a3 || c3 == b1 || c3 == b2 || c3 == b3 || c3 == c1 || c3 == c2)
                    {
                        Console.WriteLine("You Can Only get a number from 1 to 9 and It cannot be same with  previous numbers");
                        Console.Write("enter a number between 1 to 9 = ");
                        c3 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.Clear();
                }



                /*--------------------------random values for table--------------------------*/
                else
                {
                    Random rnd = new Random();

                    a1 = rnd.Next(1, 10);

                    a2 = rnd.Next(1, 10);
                    while (a2 == a1) { a2 = rnd.Next(1, 10); }

                    a3 = rnd.Next(1, 10);
                    while (a3 == a1 || a3 == a2) { a3 = rnd.Next(1, 10); }

                    b1 = rnd.Next(1, 10);
                    while (b1 == a1 || b1 == a2 || b1 == a3) { b1 = rnd.Next(1, 10); }

                    b2 = rnd.Next(1, 10);
                    while (b2 == a1 || b2 == a2 || b2 == a3 || b2 == b1) { b2 = rnd.Next(1, 10); }

                    b3 = rnd.Next(1, 10);
                    while (b3 == a1 || b3 == a2 || b3 == a3 || b3 == b1 || b3 == b2) { b3 = rnd.Next(1, 10); }

                    c1 = rnd.Next(1, 10);
                    while (c1 == a1 || c1 == a2 || c1 == a3 || c1 == b1 || c1 == b2 || c1 == b3) { c1 = rnd.Next(1, 10); }

                    c2 = rnd.Next(1, 10);
                    while (c2 == a1 || c2 == a2 || c2 == a3 || c2 == b1 || c2 == b2 || c2 == b3 || c2 == c1) { c2 = rnd.Next(1, 10); }

                    c3 = rnd.Next(1, 10);
                    while (c3 == a1 || c3 == a2 || c3 == a3 || c3 == b1 || c3 == b2 || c3 == b3 || c3 == c1 || c3 == c2) { c3 = rnd.Next(1, 10); }
                }



                /*--------------------------board score cleaner--------------------------*/
                board_score = 0;



                /*--------------------------goal reader--------------------------*/

                /*-----line goals-----*/
                if (a1 == a2 + 1 && a2 == a3 + 1) { board_score = board_score + 1; }

                else if (a3 == a2 + 1 && a2 == a1 + 1) { board_score = board_score + 1; }
                //----------------------------------------//
                if (b1 == b2 + 1 && b2 == b3 + 1) { board_score = board_score + 1; }

                else if (b3 == b2 + 1 && b2 == b1 + 1) { board_score = board_score + 1; }
                //----------------------------------------//
                if (c1 == c2 + 1 && c2 == c3 + 1) { board_score = board_score + 1; }

                else if (c3 == c2 + 1 && c2 == c1 + 1) { board_score = board_score + 1; }


                /*-----column goals-----*/
                if (a1 == b1 + 1 && b1 == c1 + 1) { board_score = board_score + 1; }

                else if (c1 == b1 + 1 && b1 == a1 + 1) { board_score = board_score + 1; }
                //----------------------------------------//
                if (a2 == b2 + 1 && b2 == c2 + 1) { board_score = board_score + 1; }

                else if (c2 == b2 + 1 && b2 == a2 + 1) { board_score = board_score + 1; }
                //----------------------------------------//
                if (a3 == b3 + 1 && b3 == c3 + 1) { board_score = board_score + 1; }

                else if (c3 == b3 + 1 && b3 == a3 + 1) { board_score = board_score + 1; }


                /*-----diagonal goals-----*/
                if (a1 == b2 + 1 && b2 == c3 + 1) { board_score = board_score + 1; }

                else if (c3 == b2 + 1 && b2 == a1 + 1) { board_score = board_score + 1; }
                //----------------------------------------//
                if (a3 == b2 + 1 && b2 == c1 + 1) { board_score = board_score + 1; }

                else if (c1 == b2 + 1 && b2 == a3 + 1) { board_score = board_score + 1; }



                /*--------------------------without goal space--------------------------*/
                while (board_score != 0)
                {

                    /*--------------------------player table--------------------------*/
                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} {c3} |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.Write("Command: ");
                    move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();



                    /*--------------------------player moves--------------------------*/

                        /*-----false moves from player-----*/
                    while (move < 1 || move > 6)
                    {
                        Console.WriteLine("please enter a number between 1 to 6");
                        Console.WriteLine();
                        Console.Write("Command: ");
                        move = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }

                    if (move == 1)
                    {
                        temp = a3;
                        a3 = a2;
                        a2 = a1;
                        a1 = temp;
                    }

                    else if (move == 2)
                    {
                        temp = b3;
                        b3 = b2;
                        b2 = b1;
                        b1 = temp;
                    }

                    else if (move == 3)
                    {
                        temp = c3;
                        c3 = c2;
                        c2 = c1;
                        c1 = temp;
                    }

                    else if (move == 4)
                    {
                        temp = c1;
                        c1 = b1;
                        b1 = a1;
                        a1 = temp;
                    }

                    else if (move == 5)
                    {
                        temp = c2;
                        c2 = b2;
                        b2 = a2;
                        a2 = temp;
                    }

                    else if (move == 6)
                    {
                        temp = c3;
                        c3 = b3;
                        b3 = a3;
                        a3 = temp;
                    }

                    

                    turn = (turn + 1);



                    board_score = 0;

                    /*--------------------------goal reader--------------------------*/

                    /*-----line goals-----*/
                    if (a1 == a2 + 1 && a2 == a3 + 1) { board_score = board_score + 1; }

                    else if (a3 == a2 + 1 && a2 == a1 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (b1 == b2 + 1 && b2 == b3 + 1) { board_score = board_score + 1; }

                    else if (b3 == b2 + 1 && b2 == b1 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (c1 == c2 + 1 && c2 == c3 + 1) { board_score = board_score + 1; }

                    else if (c3 == c2 + 1 && c2 == c1 + 1) { board_score = board_score + 1; }


                    /*-----column goals-----*/
                    if (a1 == b1 + 1 && b1 == c1 + 1) { board_score = board_score + 1; }

                    else if (c1 == b1 + 1 && b1 == a1 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (a2 == b2 + 1 && b2 == c2 + 1) { board_score = board_score + 1; }

                    else if (c2 == b2 + 1 && b2 == a2 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (a3 == b3 + 1 && b3 == c3 + 1) { board_score = board_score + 1; }

                    else if (c3 == b3 + 1 && b3 == a3 + 1) { board_score = board_score + 1; }


                    /*-----diagonal goals-----*/
                    if (a1 == b2 + 1 && b2 == c3 + 1) { board_score = board_score + 1; }

                    else if (c3 == b2 + 1 && b2 == a1 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (a3 == b2 + 1 && b2 == c1 + 1) { board_score = board_score + 1; }

                    else if (c1 == b2 + 1 && b2 == a3 + 1) { board_score = board_score + 1; }



                    /*--------------------------loop breaker--------------------------*/
                    if (board_score == 0) { break; }


                    
                    /*--------------------------computer table--------------------------*/
                    computer_move = new Random().Next(1, 7);

                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn} / Computer");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} {c3} |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.WriteLine($"Command: {computer_move}");
                    Console.WriteLine();



                    /*--------------------------computer moves--------------------------*/
                    if (computer_move == 1)
                    {
                        temp = a3;
                        a3 = a2;
                        a2 = a1;
                        a1 = temp;
                    }

                    else if (computer_move == 2)
                    {
                        temp = b3;
                        b3 = b2;
                        b2 = b1;
                        b1 = temp;
                    }

                    else if (computer_move == 3)
                    {
                        temp = c3;
                        c3 = c2;
                        c2 = c1;
                        c1 = temp;
                    }

                    else if (computer_move == 4)
                    {
                        temp = c1;
                        c1 = b1;
                        b1 = a1;
                        a1 = temp;
                    }

                    else if (computer_move == 5)
                    {
                        temp = c2;
                        c2 = b2;
                        b2 = a2;
                        a2 = temp;
                    }

                    else
                    {
                        temp = c3;
                        c3 = b3;
                        b3 = a3;
                        a3 = temp;
                    }

                    turn = (turn + 1);



                    board_score = 0;

                    /*--------------------------goal reader--------------------------*/

                    /*-----line goals-----*/
                    if (a1 == a2 + 1 && a2 == a3 + 1) { board_score = board_score + 1; }

                    else if (a3 == a2 + 1 && a2 == a1 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (b1 == b2 + 1 && b2 == b3 + 1) { board_score = board_score + 1; }

                    else if (b3 == b2 + 1 && b2 == b1 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (c1 == c2 + 1 && c2 == c3 + 1) { board_score = board_score + 1; }

                    else if (c3 == c2 + 1 && c2 == c1 + 1) { board_score = board_score + 1; }


                    /*-----column goals-----*/
                    if (a1 == b1 + 1 && b1 == c1 + 1) { board_score = board_score + 1; }

                    else if (c1 == b1 + 1 && b1 == a1 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (a2 == b2 + 1 && b2 == c2 + 1) { board_score = board_score + 1; }

                    else if (c2 == b2 + 1 && b2 == a2 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (a3 == b3 + 1 && b3 == c3 + 1) { board_score = board_score + 1; }

                    else if (c3 == b3 + 1 && b3 == a3 + 1) { board_score = board_score + 1; }


                    /*-----diagonal goals-----*/
                    if (a1 == b2 + 1 && b2 == c3 + 1) { board_score = board_score + 1; }

                    else if (c3 == b2 + 1 && b2 == a1 + 1) { board_score = board_score + 1; }
                    //----------------------------------------//
                    if (a3 == b2 + 1 && b2 == c1 + 1) { board_score = board_score + 1; }

                    else if (c1 == b2 + 1 && b2 == a3 + 1) { board_score = board_score + 1; }



                    /*--------------------------loop breaker--------------------------*/
                    if (board_score == 0) { break; }
                }


















                /*--------------------------normal game--------------------------*/
                while (board_score == 0)
                {
                    if (turn % 2 != 0)
                    {
                        /*--------------------------player table--------------------------*/
                        Console.WriteLine($"--------------- Round {round} ---------------");
                        Console.WriteLine();
                        Console.WriteLine($"   1 2 3        Turn {turn} / Player");
                        Console.WriteLine($" + - - - +");
                        Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                        Console.WriteLine($"2| {b1} {b2} {b3} |");
                        Console.WriteLine($"3| {c1} {c2} {c3} |      Player Score    :   {player_score}");
                        Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                        Console.WriteLine();
                        Console.Write("Command: ");
                        move = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();



                        /*--------------------------player moves--------------------------*/

                        /*-----false moves from player-----*/
                        while (move < 1 || move > 6)
                        {
                            Console.WriteLine("please enter a number between 1 to 6");
                            Console.WriteLine();
                            Console.Write("Command: ");
                            move = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }

                        if (move == 1)
                        {
                            temp = a3;
                            a3 = a2;
                            a2 = a1;
                            a1 = temp;
                        }

                        else if (move == 2)
                        {
                            temp = b3;
                            b3 = b2;
                            b2 = b1;
                            b1 = temp;
                        }

                        else if (move == 3)
                        {
                            temp = c3;
                            c3 = c2;
                            c2 = c1;
                            c1 = temp;
                        }

                        else if (move == 4)
                        {
                            temp = c1;
                            c1 = b1;
                            b1 = a1;
                            a1 = temp;
                        }

                        else if (move == 5)
                        {
                            temp = c2;
                            c2 = b2;
                            b2 = a2;
                            a2 = temp;
                        }

                        else if (move == 6)
                        {
                            temp = c3;
                            c3 = b3;
                            b3 = a3;
                            a3 = temp;
                        }



                        /*--------------------------goal reader--------------------------*/

                        /*-----line goals-----*/
                        if (a1 == a2 + 1 && a2 == a3 + 1) { board_score = board_score + 1; }

                        else if (a3 == a2 + 1 && a2 == a1 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (b1 == b2 + 1 && b2 == b3 + 1) { board_score = board_score + 1; }

                        else if (b3 == b2 + 1 && b2 == b1 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (c1 == c2 + 1 && c2 == c3 + 1) { board_score = board_score + 1; }

                        else if (c3 == c2 + 1 && c2 == c1 + 1) { board_score = board_score + 1; }


                        /*-----column goals-----*/
                        if (a1 == b1 + 1 && b1 == c1 + 1) { board_score = board_score + 1; }

                        else if (c1 == b1 + 1 && b1 == a1 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (a2 == b2 + 1 && b2 == c2 + 1) { board_score = board_score + 1; }

                        else if (c2 == b2 + 1 && b2 == a2 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (a3 == b3 + 1 && b3 == c3 + 1) { board_score = board_score + 1; }

                        else if (c3 == b3 + 1 && b3 == a3 + 1) { board_score = board_score + 1; }


                        /*-----diagonal goals-----*/
                        if (a1 == b2 + 1 && b2 == c3 + 1) { board_score = board_score + 1; }

                        else if (c3 == b2 + 1 && b2 == a1 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (a3 == b2 + 1 && b2 == c1 + 1) { board_score = board_score + 1; }

                        else if (c1 == b2 + 1 && b2 == a3 + 1) { board_score = board_score + 1; }



                        turn = (turn + 1);



                        /*--------------------------loop breaker--------------------------*/
                        if (board_score != 0) { player_score = player_score + (board_score * board_score); break; }
                    }









                    else
                    {
                        /*--------------------------computer table--------------------------*/
                        computer_move = new Random().Next(1, 7);

                        Console.WriteLine($"--------------- Round {round} ---------------");
                        Console.WriteLine();
                        Console.WriteLine($"   1 2 3        Turn {turn} / Computer");
                        Console.WriteLine($" + - - - +");
                        Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                        Console.WriteLine($"2| {b1} {b2} {b3} |");
                        Console.WriteLine($"3| {c1} {c2} {c3} |      Player Score    :   {player_score}");
                        Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                        Console.WriteLine();
                        Console.WriteLine($"Command: {computer_move}");
                        Console.WriteLine();



                        /*--------------------------computer moves--------------------------*/
                        if (computer_move == 1)
                        {
                            temp = a3;
                            a3 = a2;
                            a2 = a1;
                            a1 = temp;
                        }

                        else if (computer_move == 2)
                        {
                            temp = b3;
                            b3 = b2;
                            b2 = b1;
                            b1 = temp;
                        }

                        else if (computer_move == 3)
                        {
                            temp = c3;
                            c3 = c2;
                            c2 = c1;
                            c1 = temp;
                        }

                        else if (computer_move == 4)
                        {
                            temp = c1;
                            c1 = b1;
                            b1 = a1;
                            a1 = temp;
                        }

                        else if (computer_move == 5)
                        {
                            temp = c2;
                            c2 = b2;
                            b2 = a2;
                            a2 = temp;
                        }

                        else
                        {
                            temp = c3;
                            c3 = b3;
                            b3 = a3;
                            a3 = temp;
                        }



                        /*--------------------------goal reader--------------------------*/

                        /*-----line goals-----*/
                        if (a1 == a2 + 1 && a2 == a3 + 1) { board_score = board_score + 1; }

                        else if (a3 == a2 + 1 && a2 == a1 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (b1 == b2 + 1 && b2 == b3 + 1) { board_score = board_score + 1; }

                        else if (b3 == b2 + 1 && b2 == b1 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (c1 == c2 + 1 && c2 == c3 + 1) { board_score = board_score + 1; }

                        else if (c3 == c2 + 1 && c2 == c1 + 1) { board_score = board_score + 1; }


                        /*-----column goals-----*/
                        if (a1 == b1 + 1 && b1 == c1 + 1) { board_score = board_score + 1; }

                        else if (c1 == b1 + 1 && b1 == a1 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (a2 == b2 + 1 && b2 == c2 + 1) { board_score = board_score + 1; }

                        else if (c2 == b2 + 1 && b2 == a2 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (a3 == b3 + 1 && b3 == c3 + 1) { board_score = board_score + 1; }

                        else if (c3 == b3 + 1 && b3 == a3 + 1) { board_score = board_score + 1; }


                        /*-----diagonal goals-----*/
                        if (a1 == b2 + 1 && b2 == c3 + 1) { board_score = board_score + 1; }

                        else if (c3 == b2 + 1 && b2 == a1 + 1) { board_score = board_score + 1; }
                        //----------------------------------------//
                        if (a3 == b2 + 1 && b2 == c1 + 1) { board_score = board_score + 1; }

                        else if (c1 == b2 + 1 && b2 == a3 + 1) { board_score = board_score + 1; }



                        turn = (turn + 1);



                        /*--------------------------loop breaker--------------------------*/
                        if (board_score != 0) { computer_score = computer_score + (board_score * board_score); break; }
                    }
                }





                /*--------------------------end of round--------------------------*/
                if (turn % 2 != 0)
                {
                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn - 1} / Computer");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} {c3} |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.WriteLine($"End of round.");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"--------------- Round {round} ---------------");
                    Console.WriteLine();
                    Console.WriteLine($"   1 2 3        Turn {turn - 1} / Player");
                    Console.WriteLine($" + - - - +");
                    Console.WriteLine($"1| {a1} {a2} {a3} |      Board Score     :   {board_score * board_score}");
                    Console.WriteLine($"2| {b1} {b2} {b3} |");
                    Console.WriteLine($"3| {c1} {c2} {c3} |      Player Score    :   {player_score}");
                    Console.WriteLine($" + - - - +      Computer Score  :   {computer_score}");
                    Console.WriteLine();
                    Console.WriteLine($"End of round.");
                    Console.ReadLine();
                }
            }


            /*--------------------------end screen--------------------------*/
            if (computer_score < player_score)
            {
                Console.WriteLine("Winner: Player");
            }

            else
            {
                Console.WriteLine("Winner: Computer");
            }
            Console.ReadLine();
        }
    }
}
