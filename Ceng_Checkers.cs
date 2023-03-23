using System;

namespace PBL3
{
    class Program
    {



        static void Main(string[] args)
        {

            bool menu = true;

            while (menu)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(30, 3);

                Console.WriteLine("+---------------  # CENG Checkers # ---------------+");                   //Creating game menu.
                for (int i = 0; i <= 6; i++)
                {
                    Console.SetCursorPosition(30, i + 4);
                    Console.WriteLine("|                                                  |");
                }
                Console.SetCursorPosition(30, 11);
                Console.WriteLine("+--------------------------------------------------+");

                Console.SetCursorPosition(42, 5);
                Console.WriteLine("1 - How To Play?");
                Console.SetCursorPosition(42, 7);
                Console.WriteLine("2 - Start game ");
                Console.SetCursorPosition(42, 9);
                Console.Write("Please select the option [ ]");
                Console.SetCursorPosition(68, 9);




                ConsoleKeyInfo cki;
                cki = Console.ReadKey(true);


                if (cki.KeyChar == 49)
                {

                    Console.Clear();
                    Console.SetCursorPosition(45, 2);                                                   //Printing how to play section.
                    Console.WriteLine("-----# How To Play CENG Checkers #-----");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("GENERAL INFORMATION");
                    Console.WriteLine();
                    Console.WriteLine("1- The game is played on a 8*8 board.");
                    Console.WriteLine("2- Players of the game are human (x) and computer (o).");
                    Console.WriteLine("3- Human player starts the game.");
                    Console.WriteLine("4- The game is turn based.");
                    Console.WriteLine("5- The goal of the game is to be the first player to move all 9 pieces across the board and into their own home area.");
                    Console.WriteLine("6- Each player's home area is the opposing 3*3 area.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIAL BOARD");
                    Console.WriteLine();
                    Console.WriteLine("#At the beginning of the game, each player has 9 pieces (as 3*3).\n" +
                        "#Human player has x pieces in the bottom right 3*3 area of the board and computer player has o pieces in the top left 3*3 area.\n" +
                        "#Each player wants to move his/her pieces to their home (opposite side of the board (3*3 area)).");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("GAME PLAYING RULES");
                    Console.WriteLine();
                    Console.WriteLine("-All the moves are in 4 directions, diagonal moves cannot be used.");
                    Console.WriteLine("-There are 2 move types for a player in each turn: Either a step or jump(s).");
                    Console.WriteLine();
                    Console.WriteLine("Step: If adjacent square of a piece in any direction (left, right, up or down) is empty, that piece can step into the empty square.");
                    Console.WriteLine("Jump: A piece can jump over only a single adjacent piece (his/her or opponent's). Jumping over 2 or more pieces or distant pieces is not allowed.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Move cursor to the location of the piece \n" +
                        "Choose the piece by pressing key Z \n" +
                        "Move cursor to the target location \n" +
                        "Choose target square by pressing key X \n" +
                        "After the move; \n" +
                        "If there is no successive jumps, end the move by pressing key C");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--> Please press ENTER to return to the menu");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }




                else if (cki.KeyChar == 50)
                {

                    menu = false;
                    Console.Clear();
                    int counter = 1;
                    
                    string[,] game = new string[8, 8];                      //creating game board array.
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            game[i, j] = "O";
                        }

                    }

                    for (int i = 5; i < game.GetLength(0); i++)
                    {
                        for (int j = 5; j < game.GetLength(1); j++)
                        {
                            game[i, j] = "X";
                        }

                    }


                    for (int i = 0; i < game.GetLength(0); i++)
                    {
                        for (int j = 0; j < game.GetLength(1); j++)
                        {
                            if (game[i, j] != "O" && game[i, j] != "X")
                            {
                                game[i, j] = ".";
                            }
                        }

                    }



                    Console.SetCursorPosition(2, 0);                                    //printing game board and coloring.
                    for (int a = 1; a <= 8; a++)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(a);
                    }
                    Console.WriteLine();
                    Console.SetCursorPosition(1, 1);
                    Console.WriteLine("+--------+");
                    for (int a = 1; a <= 8; a++)
                    {
                        Console.WriteLine(a + "|");
                    }
                    Console.ResetColor();

                    Console.SetCursorPosition(2, 2);

                    for (int i = 0; i < game.GetLength(0); i++)
                    {
                        for (int j = 0; j < game.GetLength(1); j++)
                        {
                            if (game[i, j] == "X")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(game[i, j]);
                                Console.ResetColor();
                            }
                            else if (game[i, j] == "O")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(game[i, j]);
                                Console.ResetColor();
                            }
                            else if (game[i, j] == ".")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(game[i, j]);
                                Console.ResetColor();
                            }

                        }
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("|");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.SetCursorPosition(2, i + 3);
                    }

                    Console.WriteLine();
                    Console.SetCursorPosition(1, 10);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("+--------+");
                    Console.ResetColor();

                    void printgameboard()                                               //this function for print game board.
                    {
                        Console.SetCursorPosition(2, 2);

                        for (int i = 0; i < game.GetLength(0); i++)
                        {
                            for (int j = 0; j < game.GetLength(1); j++)
                            {
                                if (game[i, j] == "X")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(game[i, j]);
                                    Console.ResetColor();
                                }
                                else if (game[i, j] == "O")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(game[i, j]);
                                    Console.ResetColor();
                                }
                                else if (game[i, j] == ".")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(game[i, j]);
                                    Console.ResetColor();
                                }

                            }
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("|");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.SetCursorPosition(2, i + 3);
                        }
                    }



                                                                            
                    int compMoveXY = 0;                                         //creating necessary variables.
                    int chosenx = 0;
                    int choseny = 0;

                    bool gameOver = true;
                    bool playerTurn = true;
                    bool compmove = true;
                    bool endTurn = true;
                    bool isPlayerMoved = false;

                    int x = 5, y = 5;

                    ConsoleKeyInfo cki1;
                    ConsoleKeyInfo cki2;

                    bool compstep = true;
                    bool compjump = true;
                    bool compdoublejump = true;
                    bool compturn = true;

                    int flag = 0;



                    while (gameOver)
                    {

                        Console.SetCursorPosition(30, 4);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Round : " + counter);
                        Console.SetCursorPosition(30, 6);
                        Console.WriteLine("Turn : X");
                        Console.ResetColor();
                        while (playerTurn)
                        {


                            cki1 = Console.ReadKey(true);




                            if (cki1.Key == ConsoleKey.RightArrow) //Cursor movement
                            {
                                Console.SetCursorPosition(x + 1, y);
                                x = x + 1;
                                if (x >= 10)
                                    Console.SetCursorPosition(x = 2, y);
                            }
                            else if (cki1.Key == ConsoleKey.LeftArrow) //Cursor movement
                            {
                                Console.SetCursorPosition(x - 1, y);
                                x = x - 1;
                                if (x <= 1)
                                    Console.SetCursorPosition(x = 9, y);
                            }
                            else if (cki1.Key == ConsoleKey.UpArrow) //Cursor movement
                            {
                                Console.SetCursorPosition(x, y - 1);
                                y = y - 1;
                                if (y <= 1)
                                    Console.SetCursorPosition(x, y = 9);
                            }
                            else if (cki1.Key == ConsoleKey.DownArrow) //Cursor movement
                            {
                                Console.SetCursorPosition(x, y + 1);
                                y = y + 1;
                                if (y >= 10)
                                    Console.SetCursorPosition(x, y = 2);
                            }
                            else if (cki1.Key == ConsoleKey.Z && game[y - 2, x - 2] == "X") //Choosing piece
                            {
                                playerTurn = false;
                                endTurn = true;
                                isPlayerMoved = false;
                                chosenx = x;
                                choseny = y;
                                Console.Write(" ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(x, y);
                                Console.Write("X");
                                Console.ResetColor();



                                while (endTurn) // movement of the selected piece
                                {
                                    cki2 = Console.ReadKey(true);
                                    if (cki2.Key == ConsoleKey.X && game[y - 2, x - 2] == ".")
                                    {
                                        if ((((x == chosenx + 1 || x == chosenx - 1) && choseny == y) || ((y == choseny - 1 || y == choseny + 1) && chosenx == x)) && isPlayerMoved == false) //Step Operation
                                        {
                                            game[y - 2, x - 2] = "X";
                                            game[choseny - 2, chosenx - 2] = ".";
                                            playerTurn = false;
                                            printgameboard();
                                            endTurn = false;
                                            compmove = true;
                                        }
                                        if (chosenx < 9)
                                        {
                                            if ((x == chosenx + 2 && (game[choseny - 2, chosenx - 1] == "X" || game[choseny - 2, chosenx - 1] == "O")) || ((x == chosenx - 2) && (game[choseny - 2, chosenx - 3] == "X" || game[choseny - 2, chosenx - 3] == "O")) && y == choseny) //Jump Operation
                                            {
                                                game[y - 2, x - 2] = "X";
                                                game[choseny - 2, chosenx - 2] = ".";
                                                playerTurn = true;
                                                printgameboard();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.SetCursorPosition(x, y);
                                                Console.Write("X");
                                                Console.ResetColor();
                                                chosenx = x;
                                                choseny = y;
                                                isPlayerMoved = true;
                                            }
                                        }
                                        else if (chosenx == 9)
                                        {
                                            if (x == chosenx - 2 && (game[choseny - 2, chosenx - 3] == "X" || game[choseny - 2, chosenx - 3] == "O") && choseny == y) //Another check for last column as it goes out of array

                                            {
                                                game[y - 2, x - 2] = "X";
                                                game[choseny - 2, chosenx - 2] = ".";
                                                playerTurn = true;
                                                printgameboard();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.SetCursorPosition(x, y);
                                                Console.Write("X");
                                                Console.ResetColor();
                                                chosenx = x;
                                                choseny = y;
                                                isPlayerMoved = true;

                                            }
                                        }
                                        if (choseny < 9)
                                        {
                                            if ((y == choseny + 2 && (game[choseny - 1, chosenx - 2] == "X" || game[choseny - 1, chosenx - 2] == "O")) || (y == choseny - 2 && (game[choseny - 3, chosenx - 2] == "X" || game[choseny - 3, chosenx - 2] == "O")) && chosenx == x) // Vertical Jump Operation
                                            {
                                                game[y - 2, x - 2] = "X";
                                                game[choseny - 2, chosenx - 2] = ".";
                                                playerTurn = true;
                                                printgameboard();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.SetCursorPosition(x, y);
                                                Console.Write("X");
                                                Console.ResetColor();
                                                chosenx = x;
                                                choseny = y;
                                                isPlayerMoved = true;
                                            }
                                        }
                                        else if (choseny == 9)
                                        {
                                            if (y == choseny - 2 && (game[choseny - 3, chosenx - 2] == "X" || game[choseny - 3, chosenx - 2] == "O") && chosenx == x) //Vertical jump, another check for last column as it goes out of array
                                            {
                                                game[y - 2, x - 2] = "X";
                                                game[choseny - 2, chosenx - 2] = ".";
                                                playerTurn = true;
                                                printgameboard();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.SetCursorPosition(x, y);
                                                Console.Write("X");
                                                Console.ResetColor();
                                                chosenx = x;
                                                choseny = y;
                                                isPlayerMoved = true;
                                            }
                                        }
                                    }
                                    if (cki2.Key == ConsoleKey.C) // End Turn/Cancel select.
                                    {
                                        if (isPlayerMoved == true)
                                        {
                                            endTurn = false;
                                            playerTurn = false;
                                            compmove = true;
                                        }
                                        else if (isPlayerMoved == false)
                                        {
                                            endTurn = false;
                                            playerTurn = true;
                                            compmove = false;
                                            printgameboard();
                                        }
                                    }
                                    if (cki2.Key == ConsoleKey.RightArrow)//Cursor movement
                                    {
                                        Console.SetCursorPosition(x + 1, y);
                                        x = x + 1;
                                        if (x >= 10)
                                            Console.SetCursorPosition(x = 2, y);
                                    }
                                    else if (cki2.Key == ConsoleKey.LeftArrow)//Cursor movement
                                    {
                                        Console.SetCursorPosition(x - 1, y);
                                        x = x - 1;
                                        if (x <= 1)
                                            Console.SetCursorPosition(x = 9, y);
                                    }
                                    else if (cki2.Key == ConsoleKey.UpArrow)//Cursor movement
                                    {
                                        Console.SetCursorPosition(x, y - 1);
                                        y = y - 1;
                                        if (y <= 1)
                                            Console.SetCursorPosition(x, y = 9);
                                    }
                                    else if (cki2.Key == ConsoleKey.DownArrow)//Cursor movement
                                    {
                                        Console.SetCursorPosition(x, y + 1);
                                        y = y + 1;
                                        if (y >= 10)
                                            Console.SetCursorPosition(x, y = 2);
                                    }
                                    Console.SetCursorPosition(x, y);
                                }
                            }
                        }

                        Console.SetCursorPosition(30, 4);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Round : " + counter);
                        Console.SetCursorPosition(30, 6);
                        Console.WriteLine("Turn : O");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(1000);


                        while (compmove)
                        {


                            Random rand = new Random();
                            int n = rand.Next(0, 8);
                            int m = rand.Next(0, 8);


                            if ((game[5, 7] == "O" ||
                            game[6, 7] == "O" ||
                            game[7, 5] == "O" ||
                            game[7, 6] == "O" ||
                            game[7, 7] == "O") && game[n, m] == "0")
                            {
                                compdoublejump = false;
                                compjump = false;
                                compstep = false;
                                compturn = false;
                            }


                            while (compdoublejump) //It checks if there is a double jump and puts it in the array and prints it.
                            {
                                for (int a = 0; a < game.GetLength(0); a++)
                                {
                                    for (int c = 0; c < game.GetLength(1); c++)
                                    {
                                        if ((a < 6 && game[a, c] == "O" && game[a + 2, c] == "." && game[a + 1, c] != ".") && (a < 4 && game[a + 2, c] == "." && game[a + 4, c] == "." && game[a + 3, c] != "."))
                                        {
                                            game[a, c] = ".";
                                            game[a + 4, c] = "O";
                                            compdoublejump = false;
                                            printgameboard();

                                        }
                                        if (compdoublejump == false)
                                            break;
                                        if ((a < 6 && game[a, c] == "O" && game[a + 2, c] == "." && game[a + 1, c] != ".") && (a < 6 && c < 6 && game[a + 2, c] == "." && game[a + 2, c + 2] == "." && game[a + 2, c + 1] != "."))
                                        {
                                            game[a, c] = ".";
                                            game[a + 2, c + 2] = "O";
                                            compdoublejump = false;
                                            printgameboard();

                                        }
                                        if (compdoublejump == false)
                                            break;
                                        if ((c < 6 && game[a, c] == "O" && game[a, c + 2] == "." && game[a, c + 1] != ".") && (c < 4 && game[a, c + 2] == "." && game[a, c + 4] == "." && game[a, c + 3] != "."))
                                        {
                                            game[a, c] = ".";
                                            game[a, c + 4] = "O";
                                            compdoublejump = false;
                                            printgameboard();
                                        }
                                        if (compdoublejump == false)
                                            break;
                                        if ((c < 6 && game[a, c] == "O" && game[a, c + 2] == "." && game[a, c + 1] != ".") && (a < 6 && c < 6 && game[a, c + 2] == "." && game[a + 2, c + 2] == "." && game[a + 1, c + 2] != "."))
                                        {
                                            game[a, c] = ".";
                                            game[a + 2, c + 2] = "O";
                                            compdoublejump = false;
                                            printgameboard();
                                        }
                                        if (compdoublejump == false)
                                            break;
                                    }
                                    if (compdoublejump == false)
                                        break;
                                }
                                if (compdoublejump == false)
                                    break;
                                flag++;    //if there is no double jump, it exits the loop.
                                if (flag == 1)
                                {

                                    break;
                                }
                                flag = 0;
                            }

                            if (compdoublejump == false)
                                break;


                            while (compjump) //It checks if there is a jump and puts it in the array and prints it.
                            {
                                for (int a = 0; a < game.GetLength(0); a++)
                                {
                                    for (int c = 0; c < game.GetLength(1); c++)
                                    {
                                        if (compMoveXY % 2 == 0 && a < 6 && game[a, c] == "O" && game[a + 2, c] == "." && game[a + 1, c] != ".")
                                        {
                                            game[a, c] = ".";
                                            game[a + 2, c] = "O";
                                            compjump = false;
                                            printgameboard();

                                        }
                                        if (compjump == false)
                                            break;

                                        if (compMoveXY % 2 == 1 && c < 6 && game[a, c] == "O" && game[a, c + 2] == "." && game[a, c + 1] != ".")
                                        {
                                            game[a, c] = ".";
                                            game[a, c + 2] = "O";
                                            compjump = false;
                                            printgameboard();
                                        }
                                        if (compjump == false)
                                            break;

                                    }
                                    if (compjump == false)
                                        break;
                                }
                                if (compjump == false)
                                    break;
                                flag++;    //if there is no jump, it exits the loop.
                                if (flag == 1)
                                {

                                    break;
                                }
                                flag = 0;
                            }

                            if (compjump == false)
                                break;

                            while (compstep) //It checks if there is a step and puts it in the array and prints it.
                            {
                                if (compMoveXY % 2 == 0 && n < 7 && game[n, m] == "O" && game[n + 1, m] == ".")
                                {
                                    game[n, m] = ".";
                                    game[n + 1, m] = "O";
                                    compstep = false;
                                    printgameboard();
                                }
                                if (compstep == false)
                                    break;

                                if (compMoveXY % 2 == 1 && m < 7 && game[n, m] == "O" && game[n, m + 1] == ".")
                                {
                                    game[n, m] = ".";
                                    game[n, m + 1] = "O";
                                    compstep = false;
                                    printgameboard();
                                }
                                if (compstep == false)
                                    break;

                                if (compMoveXY % 2 == 0 && m < 7 && n < 7 && game[n, m] == "O" && game[n + 1, m] != "." && game[n, m + 1] == ".")
                                {
                                    game[n, m] = ".";
                                    game[n, m + 1] = "O";
                                    compstep = false;
                                    printgameboard();
                                }
                                if (compstep == false)
                                    break;

                                if (compMoveXY % 2 == 1 && m < 7 && n < 7 && game[n, m] == "O" && game[n, m + 1] != "." && game[n + 1, m] == ".")
                                {
                                    game[n, m] = ".";
                                    game[n + 1, m] = "O";
                                    compstep = false;
                                    printgameboard();
                                }
                                if (compstep == false)
                                    break;
                                flag++;
                                if (flag == 1)
                                {

                                    break;
                                }
                                flag = 0;
                            }
                            if (compstep == false)
                                break;

                            //if there is no valid move it makes move backwards
                            while (compturn)
                            {



                                if (0 < n && n < 7 && m < 7 && game[n, m] == "O" && game[n + 1, m] != "." && game[n, m + 1] != "." && game[n - 1, m] == ".")
                                {
                                    game[n, m] = ".";
                                    game[n - 1, m] = "O";
                                    compmove = false;
                                    printgameboard();
                                }
                                if (compmove == false)
                                    break;

                                if (n == 7 && m < 7 && game[n, m] == "O" && game[n, m + 1] != "." && game[n - 1, m] == ".")
                                {
                                    game[n, m] = ".";
                                    game[n - 1, m] = "O";
                                    compmove = false;
                                    printgameboard();
                                }
                                if (compmove == false)
                                    break;

                                if (0 < m && n < 7 && m < 7 && game[n, m] == "O" && game[n + 1, m] != "." && game[n, m + 1] != "." && game[n, m - 1] == ".")
                                {
                                    game[n, m] = ".";
                                    game[n, m - 1] = "O";
                                    compmove = false;
                                    printgameboard();
                                }
                                if (compmove == false)
                                    break;

                                if (m == 7 && n < 7 && game[n, m] == "O" && game[n + 1, m] != "." && game[n, m - 1] == ".")
                                {
                                    game[n, m] = ".";
                                    game[n, m - 1] = "O";
                                    compmove = false;
                                    printgameboard();
                                }
                                if (compmove == false)
                                    break;
                                flag++;
                                if (flag == 1)
                                {

                                    break;
                                }
                                flag = 0;
                            }
                        }
                        compMoveXY++;    //it makes move sequentially one to the other and one to the right.
                        counter++;

                        playerTurn = true;
                        compmove = true;
                        compstep = true;
                        compjump = true;
                        compdoublejump = true;

                        if (game[0, 0] == "X" &&
                        game[0, 1] == "X" &&
                        game[0, 2] == "X" &&
                        game[1, 0] == "X" &&
                        game[1, 1] == "X" &&
                        game[1, 2] == "X" &&
                        game[2, 0] == "X" &&
                        game[2, 1] == "X" &&
                        game[2, 2] == "X"
                        )
                        {
                            Console.SetCursorPosition(30, 4);
                            Console.WriteLine("                             ");
                            Console.SetCursorPosition(30, 6);
                            Console.WriteLine("                             ");
                            Console.SetCursorPosition(30, 5);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("The Winner is X");
                            Console.ResetColor();
                            gameOver = false;
                        }

                        else if (game[5, 5] == "O" &&
                        game[5, 6] == "O" &&
                        game[5, 7] == "O" &&
                        game[6, 5] == "O" &&
                        game[6, 6] == "O" &&
                        game[6, 7] == "O" &&
                        game[7, 5] == "O" &&
                        game[7, 6] == "O" &&
                        game[7, 7] == "O")
                        {
                            Console.SetCursorPosition(30, 4);
                            Console.WriteLine("                             ");
                            Console.SetCursorPosition(30, 6);
                            Console.WriteLine("                             ");
                            Console.SetCursorPosition(30, 5);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The Winner is O");
                            Console.ResetColor();
                            gameOver = false;
                        }

                    }

                    Console.ReadLine();


                }
                else
                {
                    Console.SetCursorPosition(40, 14);
                    Console.WriteLine("Please enter a valid option!");
                    Console.SetCursorPosition(65, 7);
                }

            }
        }
    }
}



