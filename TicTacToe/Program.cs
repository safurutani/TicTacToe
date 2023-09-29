namespace TicTacToe
{
    internal class Program
    {
        /* 
        
        board visualization 11x11
        
           |   |  
         1 | 2 | 3 
        ___|___|___
           |   |  
         4 | 5 | 6 
        ___|___|___
           |   |
         7 | 8 | 9 
           |   |

        */
        static readonly string[,] board =
        {
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " },
            {" ", "1", " ", "|", " ", "2", " ", "|", " ", "3", " " },
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " },
            {"_", "_", "_", "|", "_", "_", "_", "|", "_", "_", "_" },
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " },
            {" ", "4", " ", "|", " ", "5", " ", "|", " ", "6", " " },
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " },
            {"_", "_", "_", "|", "_", "_", "_", "|", "_", "_", "_" },
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " },
            {" ", "7", " ", "|", " ", "8", " ", "|", " ", "9", " " },
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " },

        };

        static bool gameOver = false;
        static int turns = 1;
        static bool player1Turn = true;
        static void Main(string[] args)
        {
            string stop;
            do
            {
                PlayTicTacToe(board);
                stop = Console.ReadLine();
            }
            while (stop != "stop");

        }
        static void PlayTicTacToe(string[,] board)
        {
            string[,] tempBoard = new string[board.GetLength(0), board.GetLength(1)];
            ShowBoard(board);
            Array.Copy(board, tempBoard, board.Length);
            while (!gameOver)
            {
                if (player1Turn)
                {
                    Console.WriteLine("Player 1 choose where to play: ");
                    string choice = Console.ReadLine();
                    int placeholder;
                    if (int.TryParse(choice, out placeholder))
                    {
                        switch (choice)
                        {
                            case "1":
                                if (Playable(tempBoard[1, 1]))
                                {
                                    tempBoard[1, 1] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "2":
                                if (Playable(tempBoard[1, 5]))
                                {
                                    tempBoard[1, 5] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                };
                            case "3":
                                if (Playable(tempBoard[1, 9]))
                                {
                                    tempBoard[1, 9] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "4":
                                if (Playable(tempBoard[5, 1]))
                                {
                                    tempBoard[5, 1] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "5":
                                if (Playable(tempBoard[5, 5]))
                                {
                                    tempBoard[5, 5] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "6":
                                if (Playable(tempBoard[5, 9]))
                                {
                                    tempBoard[5, 9] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "7":
                                if (Playable(tempBoard[9, 1]))
                                {
                                    tempBoard[9, 1] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "8":
                                if (Playable(tempBoard[9, 5]))
                                {
                                    tempBoard[9, 5] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "9":
                                if (Playable(tempBoard[9, 9]))
                                {
                                    tempBoard[9, 9] = "X";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            default:
                                Console.WriteLine("Choose a valid number");
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choose a valid number");
                        continue;
                    }
                    gameOver = CheckWin(tempBoard);
                    player1Turn = !player1Turn;
                    turns++;
                    if (turns == 10)
                    {
                        gameOver = true;
                    }
                    ShowBoard(tempBoard);
                }
                else
                {
                    Console.WriteLine("Player 2 choose where to play: ");
                    string choice = Console.ReadLine();
                    int placeholder;
                    if (int.TryParse(choice, out placeholder))
                    {
                        switch (choice)
                        {
                            case "1":
                                if (Playable(tempBoard[1, 1]))
                                {
                                    tempBoard[1, 1] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "2":
                                if (Playable(tempBoard[1, 5]))
                                {
                                    tempBoard[1, 5] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "3":
                                if (Playable(tempBoard[1, 9]))
                                {
                                    tempBoard[1, 9] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "4":
                                if (Playable(tempBoard[5, 1]))
                                {
                                    tempBoard[5, 1] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "5":
                                if (Playable(tempBoard[5, 5]))
                                {
                                    tempBoard[5, 5] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "6":
                                if (Playable(tempBoard[5, 9]))
                                {
                                    tempBoard[5, 9] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "7":
                                if (Playable(tempBoard[9, 1]))
                                {
                                    tempBoard[9, 1] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "8":
                                if (Playable(tempBoard[9, 5]))
                                {
                                    tempBoard[9, 5] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            case "9":
                                if (Playable(tempBoard[9, 9]))
                                {
                                    tempBoard[9, 9] = "O";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This spot is already taken");
                                    continue;
                                }
                            default:
                                Console.WriteLine("Choose a valid number");
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choose a valid number");
                        continue;
                    }

                    gameOver = CheckWin(tempBoard);
                    player1Turn = !player1Turn;
                    turns++;
                    if (turns == 10)
                    {
                        gameOver = true;
                    }
                    ShowBoard(tempBoard);
                }
            }
            if (turns == 10 && CheckWin(tempBoard) == false)
            {
                Console.WriteLine("It's a draw");
            }
            else if (!player1Turn)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }

            while (gameOver)
            {
                Console.WriteLine("Type 'restart' to start a new game or 'stop' to end program");
                string restart = Console.ReadLine();
                if (restart == "restart")
                {
                    gameOver = false;
                    turns = 1;
                    player1Turn = true;
                    PlayTicTacToe(board);
                }
                else if (restart == "stop")
                {
                    Environment.Exit(0);
                }
            }

        }
        static void ShowBoard(string[,] board)
        {
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    Console.Write(board[r, c]);
                }
                Console.WriteLine();

            }
        }
        static bool CheckWin(string[,] board)
        {
            /*int[,] playableSpots = { 
                {1,1}, {1,5}, {1,9},
                {5,1}, {5,5}, {5,9},
                {9,1}, {9,5}, {9,9}
                };
            */
            int[] playableSpots = { 1, 5, 9 };
            //horizontal wins
            for (int r = 1; r < 10; r += 4)
            {
                string horizontal = "";
                for (int c = 1; c < 10; c += 4)
                {
                    horizontal += board[r, c];
                }
                if (horizontal == "OOO" || horizontal == "XXX")
                {
                    return true;
                }
            }
            //vertical wins
            for (int c = 1; c < 10; c += 4)
            {
                string vertical = "";
                for (int r = 1; r < 10; r += 4)
                {
                    vertical += board[r, c];
                }
                if (vertical == "OOO" || vertical == "XXX")
                {
                    return true;
                }
            }
            //diagonal wins
            if (
                (board[1, 1] == "O" && board[5, 5] == "O" && board[9, 9] == "O") ||
                (board[1, 1] == "X" && board[5, 5] == "X" && board[9, 9] == "X") ||
                (board[1, 9] == "X" && board[5, 5] == "X" && board[9, 1] == "X") ||
                (board[1, 9] == "O" && board[5, 5] == "O" && board[9, 1] == "O")
            )
            {
                return true;
            }
            return false;
        }
        static bool Playable(string spot)
        {
            if (spot == "O" || spot == "X")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}