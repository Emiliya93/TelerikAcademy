namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Mines
    {
        private const int MaxPoints = 35;

        private const string TopCommand = "top";
        private const string RestartCommand = "restart";
        private const string ExitCommand = "exit";
        private const string TurnCommand = "turn";
       
        private const char BombSymbol = '*';
        private const char NoBombSymbol = '-';
        private const char DefaultHiddenFieldSymbol = '?';
   
        private const int BoardRows = 5;
        private const int BoardColumns = 10;

        // TODO: Refactor Main method
        public static void Main()
        {
            string command = string.Empty;
            char[,] board = InitializeGameBoard();
            char[,] bombs = LoadBombs();
            int pointsCount = 0;
            bool isPlayerOnBomb = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            bool isGameAimedWithMaxPoints = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play the game \"Mines\". Try your luck to find field without mines/bombs.");
                    Console.WriteLine(
                        "Command {0} shows rating, {1} starts new game, {2} to exit the game!", 
                        TopCommand, 
                        RestartCommand, 
                        ExitCommand);

                    PrintBoard(board);
                    isNewGame = false;
                }

                Console.Write("Enter row and column: ");
                string input = Console.ReadLine();
                command = input.Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= board.GetLength(0) &&
                        col <= board.GetLength(1))
                    {
                        command = TurnCommand;
                    }
                }

                switch (command)
                {
                    case TopCommand:
                        PrintRating(champions);
                        break;
                    case RestartCommand:
                        board = InitializeGameBoard();
                        bombs = LoadBombs();
                        PrintBoard(board);
                        isPlayerOnBomb = false;
                        isNewGame = false;
                        break;
                    case ExitCommand:
                        Console.WriteLine("You have exited the game. Hope you enjoyed it, come again!");
                        break;
                    case TurnCommand:
                        if (bombs[row, col] != BombSymbol)
                        {
                            if (bombs[row, col] == NoBombSymbol)
                            {
                                PlayerTurn(board, bombs, row, col);
                                pointsCount++;
                            }

                            if (MaxPoints == pointsCount)
                            {
                                isGameAimedWithMaxPoints = true;
                            }
                            else
                            {
                                PrintBoard(board);
                            }
                        }
                        else
                        {
                            isPlayerOnBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (isPlayerOnBomb)
                {
                    PrintBoard(bombs);
                    Console.WriteLine("\nUups! Game over with {0} points. ", pointsCount);

                    // TODO: Extract in method AddPlayerInRatingList
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, pointsCount);

                    if (champions.Count < 5)
                    {
                        champions.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < player.Points)
                            {
                                champions.Insert(i, player);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player p1, Player p2) => p2.Name.CompareTo(p1.Name));
                    champions.Sort((Player p1, Player p2) => p2.Points.CompareTo(p1.Points));

                    PrintRating(champions);

                    board = InitializeGameBoard();
                    bombs = LoadBombs();
                    pointsCount = 0;
                    isPlayerOnBomb = false;
                    isNewGame = true;
                }

                if (isGameAimedWithMaxPoints)
                {
                    Console.WriteLine("\nPerfect! You found {0} cells in a game.", MaxPoints);
                    PrintBoard(bombs);

                    // TODO: Extract in method AddPlayerInRatingList
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, pointsCount);
                    champions.Add(player);

                    PrintRating(champions);

                    board = InitializeGameBoard();
                    bombs = LoadBombs();
                    pointsCount = 0;
                    isGameAimedWithMaxPoints = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("See you next time.");
            Console.Read();
        }

        private static void PrintRating(List<Player> player)
        {
            Console.WriteLine("\nResults: ");
            if (player.Count > 0)
            {
                for (int i = 0; i < player.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, player[i].Name, player[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rating!\n");
            }
        }

        private static void PlayerTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = CountPoints(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void PrintBoard(char[,] board)
        {
            // int BoardRows = board.GetLength(0);
            // int BoardColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < BoardRows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < BoardColumns; col++)
                {
                    Console.Write("{0} ", board[row, col]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] InitializeGameBoard()
        {
            char[,] board = new char[BoardRows, BoardColumns];

            for (int row = 0; row < BoardRows; row++)
            {
                for (int col = 0; col < BoardColumns; col++)
                {
                    board[row, col] = DefaultHiddenFieldSymbol;
                }
            }

            return board;
        }

        private static char[,] LoadBombs()
        {
            // int BoardRows = 5;
            // int BoardColumns = 10;
            char[,] board = new char[BoardRows, BoardColumns];

            for (int row = 0; row < BoardRows; row++)
            {
                for (int col = 0; col < BoardColumns; col++)
                {
                    board[row, col] = NoBombSymbol;
                }
            }

            List<int> randNums = new List<int>();

            while (randNums.Count < 15)
            {
                Random random = new Random();
                int rand = random.Next(50);
                if (!randNums.Contains(rand))
                {
                    randNums.Add(rand);
                }
            }

            foreach (int randNum in randNums)
            {
                int col = randNum / BoardColumns;
                int row = randNum % BoardColumns;

                if (row == 0 && randNum != 0)
                {
                    col--;
                    row = BoardColumns;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = BombSymbol;
            }

            return board;
        }

        private static void GetPoints(char[,] board)
        {
            int cols = board.GetLength(0);
            int rows = board.GetLength(1);

            for (int row = 0; row < cols; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (board[row, col] != BombSymbol)
                    {
                        char pointsCount = CountPoints(board, row, col);
                        board[row, col] = pointsCount;
                    }
                }
            }
        }

        private static char CountPoints(char[,] board, int currentRow, int currentCol)
        {
            int count = 0;
            //int BoardRows = board.GetLength(0);
            //int BoardColumns = board.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (board[currentRow - 1, currentCol] == BombSymbol)
                {
                    count++;
                }
            }

            if (currentRow + 1 < BoardRows)
            {
                if (board[currentRow + 1, currentCol] == BombSymbol)
                {
                    count++;
                }
            }

            if (currentCol - 1 >= 0)
            {
                if (board[currentRow, currentCol - 1] == BombSymbol)
                {
                    count++;
                }
            }

            if (currentCol + 1 < BoardColumns)
            {
                if (board[currentRow, currentCol + 1] == BombSymbol)
                {
                    count++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (board[currentRow - 1, currentCol - 1] == BombSymbol)
                {
                    count++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol + 1 < BoardColumns))
            {
                if (board[currentRow - 1, currentCol + 1] == BombSymbol)
                {
                    count++;
                }
            }

            if ((currentRow + 1 < BoardRows) && (currentCol - 1 >= 0))
            {
                if (board[currentRow + 1, currentCol - 1] == BombSymbol)
                {
                    count++;
                }
            }

            if ((currentRow + 1 < BoardRows) && (currentCol + 1 < BoardColumns))
            {
                if (board[currentRow + 1, currentCol + 1] == BombSymbol)
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}